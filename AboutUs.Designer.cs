namespace BALAMAN_IT201_CRUD_DEMO_08
{
    partial class AboutUs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            picVehicleImage = new PictureBox();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)picVehicleImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // picVehicleImage
            // 
            picVehicleImage.BorderStyle = BorderStyle.FixedSingle;
            picVehicleImage.Location = new Point(45, 52);
            picVehicleImage.Name = "picVehicleImage";
            picVehicleImage.Size = new Size(88, 80);
            picVehicleImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picVehicleImage.TabIndex = 21;
            picVehicleImage.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(45, 177);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(45, 310);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 177);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 24;
            label1.Text = "Jonathan Damalerio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 52);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 25;
            label2.Text = "Zachary Ian Pelayo Bautista";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 310);
            label3.Name = "label3";
            label3.Size = new Size(146, 15);
            label3.TabIndex = 26;
            label3.Text = "Thomas Harvey S. Jimenez";
            // 
            // AboutUs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(picVehicleImage);
            Name = "AboutUs";
            Text = "AboutUs";
            ((System.ComponentModel.ISupportInitialize)picVehicleImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picVehicleImage;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}