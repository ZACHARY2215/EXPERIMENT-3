namespace BAUTISTA_DAMALERIO_JIMENEZ_IT201_CRUD_DEMO_08
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnRead = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtMake = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtModel = new TextBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            label3 = new Label();
            label4 = new Label();
            chkIsElectric = new CheckBox();
            label5 = new Label();
            txtColor = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            txtSearch = new TextBox();
            picVehicleImage = new PictureBox();
            btnBrowseImage = new Button();
            pictureBox1 = new PictureBox();
            txtYear = new MaskedTextBox();
            btnAbout = new Button();
            txtPrice = new MaskedTextBox();
            clear = new Button();
            ToggleTheme1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVehicleImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(952, 220);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(28, 283);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 37);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Create";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(506, 16);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(106, 37);
            btnRead.TabIndex = 2;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(140, 283);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(106, 37);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(252, 283);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 37);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(140, 365);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(100, 23);
            txtMake.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 368);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 6;
            label1.Text = "Make";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 408);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 8;
            label2.Text = "Model";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(140, 405);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 7;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 451);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 10;
            label3.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 368);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 12;
            label4.Text = "Price";
            // 
            // chkIsElectric
            // 
            chkIsElectric.AutoSize = true;
            chkIsElectric.Location = new Point(364, 408);
            chkIsElectric.Name = "chkIsElectric";
            chkIsElectric.Size = new Size(80, 19);
            chkIsElectric.TabIndex = 13;
            chkIsElectric.Text = "Is Electric?";
            chkIsElectric.UseVisualStyleBackColor = true;
            chkIsElectric.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(310, 451);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 15;
            label5.Text = "Color";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(364, 448);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 23);
            txtColor.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(651, 365);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(152, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(544, 368);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 17;
            label6.Text = "Created Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 27);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 18;
            label7.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(106, 24);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(394, 23);
            txtSearch.TabIndex = 19;
            // 
            // picVehicleImage
            // 
            picVehicleImage.BorderStyle = BorderStyle.FixedSingle;
            picVehicleImage.Location = new Point(544, 405);
            picVehicleImage.Name = "picVehicleImage";
            picVehicleImage.Size = new Size(88, 80);
            picVehicleImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picVehicleImage.TabIndex = 20;
            picVehicleImage.TabStop = false;
            picVehicleImage.Click += picVehicleImage_Click;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Location = new Point(651, 405);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(126, 27);
            btnBrowseImage.TabIndex = 21;
            btnBrowseImage.Text = "Browse Image";
            btnBrowseImage.UseVisualStyleBackColor = true;
            btnBrowseImage.Click += btnBrowseImage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ccis_logo;
            pictureBox1.Location = new Point(2, 462);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(140, 448);
            txtYear.Mask = "99999";
            txtYear.Name = "txtYear";
            txtYear.PromptChar = ' ';
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 23;
            txtYear.ValidatingType = typeof(int);
            txtYear.Click += txtYear_Click;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(891, 5);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(106, 37);
            btnAbout.TabIndex = 24;
            btnAbout.Text = "About Us";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(364, 365);
            txtPrice.Mask = "99999";
            txtPrice.Name = "txtPrice";
            txtPrice.PromptChar = ' ';
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 25;
            txtPrice.ValidatingType = typeof(int);
            txtPrice.Click += txtPrice_Click;
            // clear
            // 
            clear.Location = new Point(364, 283);
            clear.Name = "clear";
            clear.Size = new Size(106, 37);
            clear.TabIndex = 23;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += Button1_Click;
            // 
            // ToggleTheme1
            // 
            ToggleTheme1.Location = new Point(874, 16);
            ToggleTheme1.Name = "ToggleTheme1";
            ToggleTheme1.Size = new Size(106, 37);
            ToggleTheme1.TabIndex = 24;
            ToggleTheme1.Text = "Toggle Theme";
            ToggleTheme1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 514);
            Controls.Add(txtPrice);
            Controls.Add(btnAbout);
            Controls.Add(txtYear);
            Controls.Add(ToggleTheme1);
            Controls.Add(clear);
            Controls.Add(pictureBox1);
            Controls.Add(btnBrowseImage);
            Controls.Add(picVehicleImage);
            Controls.Add(txtSearch);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(txtColor);
            Controls.Add(chkIsElectric);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtModel);
            Controls.Add(label1);
            Controls.Add(txtMake);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnRead);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BAUTISTA_DAMALERIO_JIMENEZ_IT201_CRUD_DEMO_08";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVehicleImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnRead;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtMake;
        private Label label1;
        private Label label2;
        private TextBox txtModel;
        private FileSystemWatcher fileSystemWatcher1;
        private CheckBox chkIsElectric;
        private Label label4;
        private Label label3;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox txtColor;
        private TextBox txtSearch;
        private Label label7;
        private Button btnBrowseImage;
        private PictureBox picVehicleImage;
        private PictureBox pictureBox1;
        private MaskedTextBox txtYear;
        private Button btnAbout;
        private MaskedTextBox txtPrice;
        private Button clear;
        private Button ToggleTheme1;
    }
}
