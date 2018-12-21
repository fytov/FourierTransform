namespace FourierTransform
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectedImage = new System.Windows.Forms.PictureBox();
            this.imageOpenMenu = new System.Windows.Forms.MenuStrip();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fourierMag = new System.Windows.Forms.PictureBox();
            this.lowFilter = new System.Windows.Forms.PictureBox();
            this.highFilter = new System.Windows.Forms.PictureBox();
            this.inputImageLabel = new System.Windows.Forms.Label();
            this.fourierMagnitudeLabel = new System.Windows.Forms.Label();
            this.lowPassFilterLabel = new System.Windows.Forms.Label();
            this.highPassFilterLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.highFourier = new System.Windows.Forms.PictureBox();
            this.lowFourier = new System.Windows.Forms.PictureBox();
            this.lowFourierLabel = new System.Windows.Forms.Label();
            this.highFourierLabel = new System.Windows.Forms.Label();
            this.paramLabel = new System.Windows.Forms.Label();
            this.firstParam = new System.Windows.Forms.NumericUpDown();
            this.secondParam = new System.Windows.Forms.NumericUpDown();
            this.statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedImage)).BeginInit();
            this.imageOpenMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fourierMag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highFourier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowFourier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondParam)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedImage
            // 
            this.SelectedImage.Location = new System.Drawing.Point(29, 43);
            this.SelectedImage.Name = "SelectedImage";
            this.SelectedImage.Size = new System.Drawing.Size(270, 270);
            this.SelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelectedImage.TabIndex = 0;
            this.SelectedImage.TabStop = false;
            // 
            // imageOpenMenu
            // 
            this.imageOpenMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem});
            this.imageOpenMenu.Location = new System.Drawing.Point(0, 0);
            this.imageOpenMenu.Name = "imageOpenMenu";
            this.imageOpenMenu.Size = new System.Drawing.Size(1282, 24);
            this.imageOpenMenu.TabIndex = 1;
            this.imageOpenMenu.Text = "menuStrip1";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // fourierMag
            // 
            this.fourierMag.Location = new System.Drawing.Point(344, 43);
            this.fourierMag.Name = "fourierMag";
            this.fourierMag.Size = new System.Drawing.Size(270, 270);
            this.fourierMag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fourierMag.TabIndex = 2;
            this.fourierMag.TabStop = false;
            // 
            // lowFilter
            // 
            this.lowFilter.Location = new System.Drawing.Point(344, 361);
            this.lowFilter.Name = "lowFilter";
            this.lowFilter.Size = new System.Drawing.Size(270, 270);
            this.lowFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lowFilter.TabIndex = 4;
            this.lowFilter.TabStop = false;
            // 
            // highFilter
            // 
            this.highFilter.Location = new System.Drawing.Point(664, 361);
            this.highFilter.Name = "highFilter";
            this.highFilter.Size = new System.Drawing.Size(270, 270);
            this.highFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.highFilter.TabIndex = 5;
            this.highFilter.TabStop = false;
            // 
            // inputImageLabel
            // 
            this.inputImageLabel.AutoSize = true;
            this.inputImageLabel.Location = new System.Drawing.Point(26, 327);
            this.inputImageLabel.Name = "inputImageLabel";
            this.inputImageLabel.Size = new System.Drawing.Size(81, 13);
            this.inputImageLabel.TabIndex = 6;
            this.inputImageLabel.Text = "Selected Image";
            // 
            // fourierMagnitudeLabel
            // 
            this.fourierMagnitudeLabel.AutoSize = true;
            this.fourierMagnitudeLabel.Location = new System.Drawing.Point(341, 327);
            this.fourierMagnitudeLabel.Name = "fourierMagnitudeLabel";
            this.fourierMagnitudeLabel.Size = new System.Drawing.Size(39, 13);
            this.fourierMagnitudeLabel.TabIndex = 7;
            this.fourierMagnitudeLabel.Text = "Fourier";
            // 
            // lowPassFilterLabel
            // 
            this.lowPassFilterLabel.AutoSize = true;
            this.lowPassFilterLabel.Location = new System.Drawing.Point(344, 638);
            this.lowPassFilterLabel.Name = "lowPassFilterLabel";
            this.lowPassFilterLabel.Size = new System.Drawing.Size(78, 13);
            this.lowPassFilterLabel.TabIndex = 9;
            this.lowPassFilterLabel.Text = "Low Pass Filter";
            // 
            // highPassFilterLabel
            // 
            this.highPassFilterLabel.AutoSize = true;
            this.highPassFilterLabel.Location = new System.Drawing.Point(664, 638);
            this.highPassFilterLabel.Name = "highPassFilterLabel";
            this.highPassFilterLabel.Size = new System.Drawing.Size(80, 13);
            this.highPassFilterLabel.TabIndex = 10;
            this.highPassFilterLabel.Text = "High Pass Filter";
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(29, 544);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(270, 87);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "Start Process";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // highFourier
            // 
            this.highFourier.Location = new System.Drawing.Point(988, 43);
            this.highFourier.Name = "highFourier";
            this.highFourier.Size = new System.Drawing.Size(270, 270);
            this.highFourier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.highFourier.TabIndex = 12;
            this.highFourier.TabStop = false;
            // 
            // lowFourier
            // 
            this.lowFourier.Location = new System.Drawing.Point(664, 43);
            this.lowFourier.Name = "lowFourier";
            this.lowFourier.Size = new System.Drawing.Size(270, 270);
            this.lowFourier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lowFourier.TabIndex = 13;
            this.lowFourier.TabStop = false;
            // 
            // lowFourierLabel
            // 
            this.lowFourierLabel.AutoSize = true;
            this.lowFourierLabel.Location = new System.Drawing.Point(664, 327);
            this.lowFourierLabel.Name = "lowFourierLabel";
            this.lowFourierLabel.Size = new System.Drawing.Size(113, 13);
            this.lowFourierLabel.TabIndex = 14;
            this.lowFourierLabel.Text = "Fourier Low Pass Filter";
            // 
            // highFourierLabel
            // 
            this.highFourierLabel.AutoSize = true;
            this.highFourierLabel.Location = new System.Drawing.Point(985, 327);
            this.highFourierLabel.Name = "highFourierLabel";
            this.highFourierLabel.Size = new System.Drawing.Size(115, 13);
            this.highFourierLabel.TabIndex = 15;
            this.highFourierLabel.Text = "Fourier High Pass Filter";
            // 
            // paramLabel
            // 
            this.paramLabel.AutoSize = true;
            this.paramLabel.Location = new System.Drawing.Point(26, 415);
            this.paramLabel.Name = "paramLabel";
            this.paramLabel.Size = new System.Drawing.Size(55, 13);
            this.paramLabel.TabIndex = 16;
            this.paramLabel.Text = "Parameter";
            // 
            // firstParam
            // 
            this.firstParam.Location = new System.Drawing.Point(29, 449);
            this.firstParam.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.firstParam.Name = "firstParam";
            this.firstParam.Size = new System.Drawing.Size(120, 20);
            this.firstParam.TabIndex = 17;
            // 
            // secondParam
            // 
            this.secondParam.Location = new System.Drawing.Point(29, 490);
            this.secondParam.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.secondParam.Name = "secondParam";
            this.secondParam.Size = new System.Drawing.Size(120, 20);
            this.secondParam.TabIndex = 18;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(25, 361);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(115, 24);
            this.statusLabel.TabIndex = 19;
            this.statusLabel.Text = "Open image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 663);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.secondParam);
            this.Controls.Add(this.firstParam);
            this.Controls.Add(this.paramLabel);
            this.Controls.Add(this.highFourierLabel);
            this.Controls.Add(this.lowFourierLabel);
            this.Controls.Add(this.lowFourier);
            this.Controls.Add(this.highFourier);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.highPassFilterLabel);
            this.Controls.Add(this.lowPassFilterLabel);
            this.Controls.Add(this.fourierMagnitudeLabel);
            this.Controls.Add(this.inputImageLabel);
            this.Controls.Add(this.highFilter);
            this.Controls.Add(this.lowFilter);
            this.Controls.Add(this.fourierMag);
            this.Controls.Add(this.SelectedImage);
            this.Controls.Add(this.imageOpenMenu);
            this.MainMenuStrip = this.imageOpenMenu;
            this.Name = "Form1";
            this.Text = "Fourier Transform";
            ((System.ComponentModel.ISupportInitialize)(this.SelectedImage)).EndInit();
            this.imageOpenMenu.ResumeLayout(false);
            this.imageOpenMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fourierMag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highFourier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowFourier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondParam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SelectedImage;
        private System.Windows.Forms.MenuStrip imageOpenMenu;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox fourierMag;
        private System.Windows.Forms.PictureBox lowFilter;
        private System.Windows.Forms.PictureBox highFilter;
        private System.Windows.Forms.Label inputImageLabel;
        private System.Windows.Forms.Label fourierMagnitudeLabel;
        private System.Windows.Forms.Label lowPassFilterLabel;
        private System.Windows.Forms.Label highPassFilterLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox highFourier;
        private System.Windows.Forms.PictureBox lowFourier;
        private System.Windows.Forms.Label lowFourierLabel;
        private System.Windows.Forms.Label highFourierLabel;
        private System.Windows.Forms.Label paramLabel;
        private System.Windows.Forms.NumericUpDown firstParam;
        private System.Windows.Forms.NumericUpDown secondParam;
        private System.Windows.Forms.Label statusLabel;
    }
}

