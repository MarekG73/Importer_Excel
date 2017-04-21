namespace Importer_dla_Excela
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.boxFilename = new System.Windows.Forms.TextBox();
            this.buttonSaveXLS = new System.Windows.Forms.Button();
            this.buttonRunExcel = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.textBoxRaportTitle = new System.Windows.Forms.TextBox();
            this.labelRaportTitle = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Pliki raportów (*.HTM, *.HTML)|*.htm; *.html\"";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.Image")));
            this.buttonOpenFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(80, 55);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Otwórz HTM";
            this.buttonOpenFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonOpenFile_MouseClick);
            this.buttonOpenFile.MouseEnter += new System.EventHandler(this.buttonOpenFile_MouseEnter);
            this.buttonOpenFile.MouseLeave += new System.EventHandler(this.anyItem_MouseLeave);
            // 
            // boxFilename
            // 
            this.boxFilename.Cursor = System.Windows.Forms.Cursors.Default;
            this.boxFilename.Enabled = false;
            this.boxFilename.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxFilename.ForeColor = System.Drawing.Color.Black;
            this.boxFilename.Location = new System.Drawing.Point(105, 73);
            this.boxFilename.Name = "boxFilename";
            this.boxFilename.ReadOnly = true;
            this.boxFilename.Size = new System.Drawing.Size(347, 23);
            this.boxFilename.TabIndex = 5;
            this.boxFilename.TabStop = false;
            this.boxFilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxFilename.WordWrap = false;
            // 
            // buttonSaveXLS
            // 
            this.buttonSaveXLS.Enabled = false;
            this.buttonSaveXLS.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveXLS.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveXLS.Image")));
            this.buttonSaveXLS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSaveXLS.Location = new System.Drawing.Point(99, 12);
            this.buttonSaveXLS.Name = "buttonSaveXLS";
            this.buttonSaveXLS.Size = new System.Drawing.Size(80, 55);
            this.buttonSaveXLS.TabIndex = 2;
            this.buttonSaveXLS.Text = "Zapisz XLS";
            this.buttonSaveXLS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSaveXLS.UseVisualStyleBackColor = true;
            this.buttonSaveXLS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSaveXLS_MouseClick);
            this.buttonSaveXLS.MouseEnter += new System.EventHandler(this.buttonSaveXLS_MouseEnter);
            this.buttonSaveXLS.MouseLeave += new System.EventHandler(this.anyItem_MouseLeave);
            // 
            // buttonRunExcel
            // 
            this.buttonRunExcel.Enabled = false;
            this.buttonRunExcel.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRunExcel.Image = ((System.Drawing.Image)(resources.GetObject("buttonRunExcel.Image")));
            this.buttonRunExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRunExcel.Location = new System.Drawing.Point(186, 12);
            this.buttonRunExcel.Name = "buttonRunExcel";
            this.buttonRunExcel.Size = new System.Drawing.Size(80, 55);
            this.buttonRunExcel.TabIndex = 8;
            this.buttonRunExcel.Text = "Startuj Excel";
            this.buttonRunExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRunExcel.UseVisualStyleBackColor = true;
            this.buttonRunExcel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonRunExcel_MouseClick);
            this.buttonRunExcel.MouseEnter += new System.EventHandler(this.buttonRunExcel_MouseEnter);
            this.buttonRunExcel.MouseLeave += new System.EventHandler(this.anyItem_MouseLeave);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.Location = new System.Drawing.Point(377, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 54);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Wyjście";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonExit_MouseClick);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.anyItem_MouseLeave);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSettings.Location = new System.Drawing.Point(272, 12);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(80, 55);
            this.buttonSettings.TabIndex = 18;
            this.buttonSettings.Text = "Ustawienia";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSettings_MouseClick);
            this.buttonSettings.MouseEnter += new System.EventHandler(this.buttonSettings_MouseEnter);
            this.buttonSettings.MouseLeave += new System.EventHandler(this.anyItem_MouseLeave);
            // 
            // infoBox
            // 
            this.infoBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.infoBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.infoBox.Cursor = System.Windows.Forms.Cursors.No;
            this.infoBox.Enabled = false;
            this.infoBox.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.infoBox.Location = new System.Drawing.Point(12, 299);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.ShortcutsEnabled = false;
            this.infoBox.Size = new System.Drawing.Size(440, 79);
            this.infoBox.TabIndex = 19;
            this.infoBox.TabStop = false;
            // 
            // textBoxRaportTitle
            // 
            this.textBoxRaportTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxRaportTitle.Enabled = false;
            this.textBoxRaportTitle.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRaportTitle.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxRaportTitle.Location = new System.Drawing.Point(121, 107);
            this.textBoxRaportTitle.Name = "textBoxRaportTitle";
            this.textBoxRaportTitle.ReadOnly = true;
            this.textBoxRaportTitle.Size = new System.Drawing.Size(331, 22);
            this.textBoxRaportTitle.TabIndex = 20;
            this.textBoxRaportTitle.TabStop = false;
            this.textBoxRaportTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRaportTitle
            // 
            this.labelRaportTitle.AutoSize = true;
            this.labelRaportTitle.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRaportTitle.Location = new System.Drawing.Point(12, 110);
            this.labelRaportTitle.Name = "labelRaportTitle";
            this.labelRaportTitle.Size = new System.Drawing.Size(103, 16);
            this.labelRaportTitle.TabIndex = 21;
            this.labelRaportTitle.Text = "Nazwa raportu:";
            this.labelRaportTitle.MouseEnter += new System.EventHandler(this.labelRaportTitle_MouseEnter);
            this.labelRaportTitle.MouseLeave += new System.EventHandler(this.anyItem_MouseLeave);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFileName.Location = new System.Drawing.Point(12, 75);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(87, 16);
            this.labelFileName.TabIndex = 23;
            this.labelFileName.Text = "Nazwa pliku:";
            this.labelFileName.MouseEnter += new System.EventHandler(this.labelFileName_MouseEnter);
            this.labelFileName.MouseLeave += new System.EventHandler(this.anyItem_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelFileName);
            this.panel1.Controls.Add(this.labelRaportTitle);
            this.panel1.Controls.Add(this.textBoxRaportTitle);
            this.panel1.Controls.Add(this.infoBox);
            this.panel1.Controls.Add(this.buttonSettings);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonRunExcel);
            this.panel1.Controls.Add(this.buttonSaveXLS);
            this.panel1.Controls.Add(this.boxFilename);
            this.panel1.Controls.Add(this.buttonOpenFile);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(1280, 555);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 525);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(12, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 99);
            this.panel2.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(14, 57);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(14, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 20);
            this.textBox3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(225, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 56);
            this.button1.TabIndex = 25;
            this.button1.Text = "Przerób plik";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(464, 523);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1280, 594);
            this.MinimumSize = new System.Drawing.Size(480, 550);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importer";
            this.TransparencyKey = System.Drawing.Color.White;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox boxFilename;
        private System.Windows.Forms.Button buttonSaveXLS;
        private System.Windows.Forms.Button buttonRunExcel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.TextBox textBoxRaportTitle;
        private System.Windows.Forms.Label labelRaportTitle;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}

