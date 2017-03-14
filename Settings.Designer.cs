namespace Importer_dla_Excela
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.SettingsButtonExit = new System.Windows.Forms.Button();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxExcelPath = new System.Windows.Forms.TextBox();
            this.buttonFindExcel = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxPathXLS = new System.Windows.Forms.TextBox();
            this.textBoxPathHTM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPathHTM = new System.Windows.Forms.Button();
            this.buttonPathXLS = new System.Windows.Forms.Button();
            this.folderBrowserSettings = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControlSettings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsButtonExit
            // 
            this.SettingsButtonExit.Location = new System.Drawing.Point(481, 6);
            this.SettingsButtonExit.Name = "SettingsButtonExit";
            this.SettingsButtonExit.Size = new System.Drawing.Size(60, 30);
            this.SettingsButtonExit.TabIndex = 18;
            this.SettingsButtonExit.Text = "Wyjście";
            this.SettingsButtonExit.UseVisualStyleBackColor = true;
            this.SettingsButtonExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button3_MouseClick);
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.AllowDrop = true;
            this.tabControlSettings.Controls.Add(this.tabPage1);
            this.tabControlSettings.Controls.Add(this.tabPage2);
            this.tabControlSettings.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControlSettings.Location = new System.Drawing.Point(6, 44);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(532, 332);
            this.tabControlSettings.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.textBoxExcelPath);
            this.tabPage1.Controls.Add(this.buttonFindExcel);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(524, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Excel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tu jest Excel:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(9, 11);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(501, 57);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // textBoxExcelPath
            // 
            this.textBoxExcelPath.Location = new System.Drawing.Point(113, 85);
            this.textBoxExcelPath.Name = "textBoxExcelPath";
            this.textBoxExcelPath.Size = new System.Drawing.Size(397, 23);
            this.textBoxExcelPath.TabIndex = 1;
            // 
            // buttonFindExcel
            // 
            this.buttonFindExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindExcel.Location = new System.Drawing.Point(216, 132);
            this.buttonFindExcel.MaximumSize = new System.Drawing.Size(100, 60);
            this.buttonFindExcel.MinimumSize = new System.Drawing.Size(100, 60);
            this.buttonFindExcel.Name = "buttonFindExcel";
            this.buttonFindExcel.Size = new System.Drawing.Size(100, 60);
            this.buttonFindExcel.TabIndex = 0;
            this.buttonFindExcel.Text = "Szukaj Excela";
            this.buttonFindExcel.UseVisualStyleBackColor = true;
            this.buttonFindExcel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonFindExcel_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.buttonPathXLS);
            this.tabPage2.Controls.Add(this.buttonPathHTM);
            this.tabPage2.Controls.Add(this.textBoxPathXLS);
            this.tabPage2.Controls.Add(this.textBoxPathHTM);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(524, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pliki danych";
            // 
            // textBoxPathXLS
            // 
            this.textBoxPathXLS.Location = new System.Drawing.Point(164, 103);
            this.textBoxPathXLS.Name = "textBoxPathXLS";
            this.textBoxPathXLS.Size = new System.Drawing.Size(349, 23);
            this.textBoxPathXLS.TabIndex = 4;
            // 
            // textBoxPathHTM
            // 
            this.textBoxPathHTM.Location = new System.Drawing.Point(164, 52);
            this.textBoxPathHTM.Name = "textBoxPathHTM";
            this.textBoxPathHTM.Size = new System.Drawing.Size(349, 23);
            this.textBoxPathHTM.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jeżeli nie chcesz, aby program pytał za każdym razem gdzie szukać/zapisać\r\nplik, " +
    "ustaw poniższe opcje.";
            // 
            // buttonPathHTM
            // 
            this.buttonPathHTM.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPathHTM.Location = new System.Drawing.Point(9, 50);
            this.buttonPathHTM.Name = "buttonPathHTM";
            this.buttonPathHTM.Size = new System.Drawing.Size(144, 27);
            this.buttonPathHTM.TabIndex = 5;
            this.buttonPathHTM.Text = "Tu szukaj plików HTM:";
            this.buttonPathHTM.UseVisualStyleBackColor = true;
            this.buttonPathHTM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonPathHTM_MouseClick);
            // 
            // buttonPathXLS
            // 
            this.buttonPathXLS.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPathXLS.Location = new System.Drawing.Point(9, 101);
            this.buttonPathXLS.Name = "buttonPathXLS";
            this.buttonPathXLS.Size = new System.Drawing.Size(144, 27);
            this.buttonPathXLS.TabIndex = 6;
            this.buttonPathXLS.Text = "Tu zapisz pliki XLS:";
            this.buttonPathXLS.UseVisualStyleBackColor = true;
            // 
            // folderBrowserSettings
            // 
            this.folderBrowserSettings.RootFolder = System.Environment.SpecialFolder.Recent;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(544, 381);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.SettingsButtonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ustawienia";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControlSettings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SettingsButtonExit;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxExcelPath;
        private System.Windows.Forms.Button buttonFindExcel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPathXLS;
        private System.Windows.Forms.TextBox textBoxPathHTM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPathXLS;
        private System.Windows.Forms.Button buttonPathHTM;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserSettings;
    }
}