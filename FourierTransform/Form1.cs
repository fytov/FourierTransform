using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FourierTransform
{
    public partial class Form1 : Form
    {
        const string PREPARING_STATUS = "Preparing images... Please, wait";
        const string READY_STATUS = "Ready. Click \"Start Proccess\"";
        Bitmap inputImage;
        double firstParameter;
        double secondParameter;
        public Form1()
        {
            InitializeComponent();
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.TIF;*.PNG)|*.BMP;*.JPG;*.TIF;*.PNG;";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                inputImage = new Bitmap(openFileDialog.OpenFile());
                SelectedImage.Image = inputImage;
                statusLabel.Text = READY_STATUS;
                startButton.Enabled = true;
            }

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Thread creatingFilteredImages = new Thread(ImageProcessing);
            creatingFilteredImages.Start();
        }

        private void ImageProcessing()
        {
            ChangeStatus();
            firstParameter = Convert.ToInt32(firstParam.Value);
            secondParameter = Convert.ToInt32(secondParam.Value);
            FourierTransform ft = new FourierTransform(inputImage);

            ft.FormardDFT();
            ft.FourierForm(ft.fourierArray);
            fourierMag.Image = ft.ConvertArrayToImage(ft.fourierFormArray);

            ft.LowPassFilter(new Complex(firstParameter, secondParameter));
            ft.FourierForm(ft.lowPassFilterArray);
            lowFourier.Image = ft.ConvertArrayToImage(ft.fourierFormArray);
            ft.InverseDFT(ft.lowPassFilterArray);
            ft.ImageForm(ft.invFourierArray);
            lowFilter.Image = ft.ConvertArrayToImage(ft.fourierFormArray);


            ft.HighPassFilter(new Complex(firstParameter, secondParameter));
            ft.FourierForm(ft.highPassFilterArray);
            highFourier.Image = ft.ConvertArrayToImage(ft.fourierFormArray);
            ft.InverseDFT(ft.highPassFilterArray);
            ft.ImageForm(ft.invFourierArray);
            highFilter.Image = ft.ConvertArrayToImage(ft.fourierFormArray);
            ChangeStatus();
        }

        private void ChangeStatus()
        {
            statusLabel.Text = (statusLabel.Text.Equals(PREPARING_STATUS)) 
                ? READY_STATUS 
                : PREPARING_STATUS;

            startButton.Enabled = !startButton.Enabled;
            firstParam.Enabled = !firstParam.Enabled;
            secondParam.Enabled = !secondParam.Enabled;
            openImageToolStripMenuItem.Enabled = !openImageToolStripMenuItem.Enabled;
        }
    }
}
