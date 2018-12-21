using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourierTransform
{
    struct Complex
    {
        public double real, imag;
        public Complex(double r, double i)
        {
            real = r;
            imag = i;
        }
        public float Magnitude()
        {
            return ((float)Math.Sqrt(real * real + imag * imag));
        }
        public float Phase()
        {
            return ((float)Math.Atan(imag / real));
        }
    };
    class FourierTransform
    {
        public Bitmap inputImage;      
        public Complex[,] fourierArray;
        public Complex[,] invFourierArray;
        public double[,] fourierFormArray;
        public Complex[,] lowPassFilterArray;
        public Complex[,] highPassFilterArray;

        public FourierTransform(Bitmap inputImage)
        {
            this.inputImage = inputImage;
            ConvertImageToArray();
        }

        private void ConvertImageToArray()
        {
            int width = inputImage.Width;
            int height = inputImage.Height;
            fourierArray = new Complex[height, width];

            BitmapData inputData = inputImage.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, inputImage.PixelFormat);

            int offset = inputData.Stride - ((inputImage.PixelFormat == PixelFormat.Format8bppIndexed) ? width : width * 3);

            unsafe
            {
                byte* src = (byte*)inputData.Scan0.ToPointer();

                if (inputImage.PixelFormat == PixelFormat.Format8bppIndexed)
                { // greyscale image
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++, src++)
                        {
                            fourierArray[i, j].real = (double)*src / 255;
                        }
                        src += offset;
                    }
                }
                else
                { // RGB image
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++, src += 3)
                        {
                            fourierArray[i, j].real = (0.2125 * src[2] + 0.7154 * src[1] + 0.0721 * src[0]) / 255;
                        }
                        src += offset;
                    }
                }
            }
            inputImage.UnlockBits(inputData);
        }

        public Bitmap ConvertArrayToImage(double[,] array)
        {
            int width = array.GetLength(1);
            int height = array.GetLength(0);

            Bitmap outputImage = new Bitmap(width, height, PixelFormat.Format8bppIndexed);
            ColorPalette cp = outputImage.Palette;
            for (int i = 0; i < 256; i++)
            {
                cp.Entries[i] = Color.FromArgb(i, i, i);
            }
            outputImage.Palette = cp;
            BitmapData dstData = outputImage.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);

            int offset = dstData.Stride - width;

            unsafe
            {
                byte* src = (byte*)dstData.Scan0.ToPointer();
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++, src++)
                    {
                        *src = (byte)System.Math.Max(0, System.Math.Min(255, array[i, j] * 255));
                    }
                    src += offset;
                }
            }
            outputImage.UnlockBits(dstData);

            return outputImage;
        }

        public void FormardDFT()
        {
            int n = fourierArray.GetLength(0);
            int m = fourierArray.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((i + j) % 2 != 0)
                    {
                        fourierArray[i, j].real *= -1;
                        fourierArray[i, j].imag *= -1;
                    }
                }
            }
            DiscreteFourierTransform2d(fourierArray, false);
        }

        public void InverseDFT(Complex[,] array)
        {
            int n = array.GetLength(0);
            int m = array.GetLength(1);

            invFourierArray = new Complex[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                        invFourierArray[i, j] = array[i, j];
                }
            }

            DiscreteFourierTransform2d(invFourierArray, true);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((i + j) % 2 != 0)
                    {
                        invFourierArray[i, j].real *= -1;
                        invFourierArray[i, j].imag *= -1;
                    }
                }
            }
        }       

        private void DiscreteFourierTransform2d(Complex[,] array, bool isReversed)
        {
            int n = array.GetLength(0);
            int m = array.GetLength(1);
            double arg, cos, sin;
            Complex[] dft = new Complex[System.Math.Max(n, m)];
            int dir = isReversed ? -1 : 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dft[j] = new Complex (0.0, 0.0);                    
                    arg = -(int)dir * 2.0 * System.Math.PI * (double)j / (double)m;

                    for (int k = 0; k < m; k++)
                    {
                        cos = System.Math.Cos(k * arg);
                        sin = System.Math.Sin(k * arg);

                        dft[j].real += (array[i, k].real * cos - array[i, k].imag * sin);
                        dft[j].imag += (array[i, k].real * sin + array[i, k].imag * cos);
                    }
                }

                if (dir == 1)
                {
                    for (int j = 0; j < m; j++)
                    {
                        array[i, j].real = dft[j].real / m;
                        array[i, j].imag = dft[j].imag / m;
                    }
                }
                else
                {
                    for (int j = 0; j < m; j++)
                    {
                        array[i, j].real = dft[j].real;
                        array[i, j].imag = dft[j].imag;
                    }
                }
            }

            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    dft[i] = new Complex(0.0, 0.0);
                    arg = -(int)dir * 2.0 * System.Math.PI * (double)i / (double)n;

                    for (int k = 0; k < n; k++)
                    {
                        cos = System.Math.Cos(k * arg);
                        sin = System.Math.Sin(k * arg);

                        dft[i].real += (array[k, j].real * cos - array[k, j].imag * sin);
                        dft[i].imag += (array[k, j].real * sin + array[k, j].imag * cos);
                    }
                }

                if (dir == 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        array[i, j].real = dft[i].real / n;
                        array[i, j].imag = dft[i].imag / n;
                    }
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        array[i, j].real = dft[i].real;
                        array[i, j].imag = dft[i].imag;
                    }
                }
            }
        }

        public void FourierForm(Complex[,] array)
        {
            int n = array.GetLength(0);
            int m = array.GetLength(1);
            fourierFormArray = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    fourierFormArray[i, j] = array[i, j].Magnitude() * Math.Sqrt(n * m);
                }
            }
        }

        public void ImageForm(Complex[,] array)
        {
            int n = array.GetLength(0);
            int m = array.GetLength(1);
            fourierFormArray = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    fourierFormArray[i, j] = array[i, j].Magnitude();
                }
            }
        }

        public void LowPassFilter(Complex param)
        {
            int width = fourierArray.GetLength(1);
            int height = fourierArray.GetLength(0);
            lowPassFilterArray = new Complex[height, width];
            double D0 = Math.Sqrt(Math.Pow((param.imag - width / 2), 2) +
                Math.Pow((param.real - height / 2), 2));
            //double D0 = param.Magnitude();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    double D = Math.Sqrt(Math.Pow((j - width / 2), 2) +
                        Math.Pow((i - height / 2), 2));
                    //double D = fourierArray[i, j].Magnitude();
                    if (D0 > D)
                    {
                        lowPassFilterArray[i, j] = fourierArray[i, j];
                    }
                    else
                    {
                        lowPassFilterArray[i, j] = new Complex(0.0, 0.0);
                    }
                }
            }
        }

        public void HighPassFilter(Complex param)
        {
            int width = fourierArray.GetLength(1);
            int height = fourierArray.GetLength(0);
            highPassFilterArray = new Complex[height, width];
            //double D0 = param.Magnitude();
            double D0 = Math.Sqrt(Math.Pow((param.imag - width / 2), 2) +
                Math.Pow((param.real - height / 2), 2));
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    //double D = fourierArray[i, j].Magnitude();
                    double D = Math.Sqrt(Math.Pow((j - width / 2), 2) +
                        Math.Pow((i - height / 2), 2));
                    if (D0 <= D)
                    {
                        highPassFilterArray[i, j] = fourierArray[i, j];
                    }
                    else
                    {
                        highPassFilterArray[i, j] = new Complex(0.0, 0.0);
                    }
                }
            }
        }       
    }
}
