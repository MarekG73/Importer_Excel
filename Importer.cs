using System.Windows.Forms;
using System.Collections.Generic;
using Importer.Classes_File;
using Importer.Classes_Excel;
using System;

namespace Importer_dla_Excela
{
    public partial class MainWindow : Form
    {
        private FileOperationCenter file;
        private ExcelOperationCenter excelFile;
        private SetupOperationCenter setupApp;

        private List<List<string>> cleaned_content = new List<List<string>>();
        private List<TextBox> fields = new List<TextBox>();
        private List<TextBox> data_fields = new List<TextBox>();

        private List<string> columns_names_in_array = new List<string>();
        private List<List<string>> data_in_array = new List<List<string>>();
        private List<string> summary_in_array = new List<string>();
        private List<string> document_header = new List<string>();

        Control current_textbox;
        Control prev_textbox;

        public MainWindow()
        {
            setupApp = new SetupOperationCenter();//sprawdzenie istnienia i odczyt pliku .ini
            InitializeComponent();
        }
        private void buttonOpenFile_MouseClick(object sender, MouseEventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = new FileOperationCenter(openFileDialog1);
                boxFilename.Text = file.getBoxFilenameText();
                
                document_header = file.getHeader()[0];
                columns_names_in_array = file.getColumnsNames();
                data_in_array = file.getDataLines();
                summary_in_array = file.getSummary();
                
                textBoxRaportTitle.Text = document_header[0].ToString();
                ////////////////////////////////////////////
                textBox3.Text = DateTime.Now.ToLongTimeString();
                excelFile = new ExcelOperationCenter(data_in_array);
                textBox4.Text = DateTime.Now.ToLongTimeString();
                ////////////////////////////////////////////
                if (document_header.Count > 0)
                {
                    buttonRunExcel.Enabled = true;
                    buttonSaveXLS.Enabled = true;
                }
            }
        }
        private void buttonSettings_MouseClick(object sender, MouseEventArgs e)
        {
            Settings SettingsWindow = new Settings();
            SettingsWindow.Show();
        }
        private void buttonExit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void buttonOpenFile_MouseEnter(object sender, System.EventArgs e)
        {
            infoBox.Text = "Otwórz plik raportu, w formacie HTML, do przerobienia na plik Excela. Można ustalić domyślnie otwierany folder (Ustawienia->Folder HTML)";
        }

        private void anyItem_MouseLeave(object sender, System.EventArgs e)
        {
            infoBox.Text = "";
        }

        private void buttonSaveXLS_MouseEnter(object sender, System.EventArgs e)
        {
            infoBox.Text = "Zapisz plik w formacie XLS. Można ustalić domyślnie otwierany folder (Ustawienia->Folder XML)";
        }

        private void buttonRunExcel_MouseEnter(object sender, System.EventArgs e)
        {
            infoBox.Text = "Zapisz plik w formacie XLS i otwórz go w Excelu. ";
            infoBox.AppendText("Aby można było używać tej opcji, konieczne jest wyszukanie lub ręczne ustawienie ścieżki  (Ustawienia->Folder Excel)");
        }
        private void buttonSettings_MouseEnter(object sender, System.EventArgs e)
        {
            infoBox.Text = "Ustawienia programu.";
        }

        private void labelFileName_MouseEnter(object sender, System.EventArgs e)
        {
            infoBox.Text = "Nazwa otworzonego pliku raportu, w formacie HTML, do przerobienia na plik Excela.";
        }

        private void buttonExit_MouseEnter(object sender, System.EventArgs e)
        {
            infoBox.Text = "Wyjście z programu";
        }

        private void labelRaportTitle_MouseEnter(object sender, System.EventArgs e)
        {
            infoBox.Text = "Odczytana z pliku HTML nazwa raportu.";
        }

        private void buttonSaveXLS_MouseClick(object sender, MouseEventArgs e)
        {
            excelFile.saveExcelFile();
            buttonRunExcel.Enabled = false;
            buttonSaveXLS.Enabled = false;
            //richTextBox1.Clear();
        }

        private void buttonRunExcel_MouseClick(object sender, MouseEventArgs e)
        {
            excelFile.openFileInExcel();
            buttonRunExcel.Enabled = false;
            buttonSaveXLS.Enabled = false;
            //richTextBox1.Clear();
        }

        private void makeColumnsNames()
        {
            //int cols = columns_names_in_array.Count;
            //int rows = data_in_array.Count;
            //tablePanel1.ColumnCount = cols;
            //tablePanel1.RowCount = rows;
            //this.tablePanel1.Size = new System.Drawing.Size(cols * 87, 24);

            //for (int i = 0; i < cols; i++)
            //{
            //    fields.Add(new TextBox());
            //    fields[i].AllowDrop = true;
            //    fields[i].BorderStyle = BorderStyle.FixedSingle;
            //    fields[i].Cursor = System.Windows.Forms.Cursors.Hand;
            //    fields[i].Dock = System.Windows.Forms.DockStyle.Fill;
            //    fields[i].Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //    fields[i].Location = new System.Drawing.Point(1 + i * 86, 1);
            //    fields[i].Margin = new System.Windows.Forms.Padding(0);
            //    fields[i].Multiline = true;
            //    fields[i].Size = new System.Drawing.Size(85, 20);
            //    fields[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //    fields[i].DragDrop += new System.Windows.Forms.DragEventHandler(TextBox_DragDrop);
            //    fields[i].DragEnter += new System.Windows.Forms.DragEventHandler(TextBox_DragEnter);
            //    fields[i].MouseDown += new System.Windows.Forms.MouseEventHandler(TextBox_MouseDown);
            //    fields[i].Text = columns_names_in_array[i];
                
            //    ///////////////////////////////////////////////////////////////////////////////////////////////////
            //    data_fields.Add(new TextBox());
            //    data_fields[i].AllowDrop = true;
            //    data_fields[i].BorderStyle = BorderStyle.FixedSingle;
            //    data_fields[i].Cursor = System.Windows.Forms.Cursors.Hand;
            //    data_fields[i].Dock = System.Windows.Forms.DockStyle.Fill;
            //    data_fields[i].Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //    data_fields[i].Location = new System.Drawing.Point(1 + i * 86, 1);
            //    data_fields[i].Margin = new System.Windows.Forms.Padding(0);
            //    data_fields[i].Multiline = true;
            //    data_fields[i].Size = new System.Drawing.Size(85, 20);
            //    data_fields[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //    data_fields[i].DragDrop += new System.Windows.Forms.DragEventHandler(TextBox_DragDrop);
            //    data_fields[i].DragEnter += new System.Windows.Forms.DragEventHandler(TextBox_DragEnter);
            //    data_fields[i].MouseDown += new System.Windows.Forms.MouseEventHandler(TextBox_MouseDown);
            //    data_fields[i].Text = data_in_array[0][i];
            //}
            //for (int i = 0; i < cols; i++)
            //{
            //    tablePanel1.Controls.Add(fields[i], i, 0);
            //    tablePanel1.Controls.Add(data_fields[i], i, 1);
            //}
            //tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        }
        private void TextBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs args)
        {
            current_textbox = (TextBox)sender;
            
            if (args.Button == MouseButtons.Left)
            {
                current_textbox.DoDragDrop(current_textbox.Text, DragDropEffects.Copy);
                
                if (prev_textbox != null)
                {
                    prev_textbox.BackColor = System.Drawing.Color.White;
                }
                current_textbox.BackColor = System.Drawing.Color.AliceBlue;
                prev_textbox = current_textbox;
            }
            if (args.Button == MouseButtons.Right)
            {
                //txt.DoDragDrop(txt.Select(txt.ScrollToCaret(), txt.Text.Length - txt.ScrollToCaret()));

            }

        }
        private void TextBox_DragEnter(object sender, System.Windows.Forms.DragEventArgs args)
        {
            if (args.Data.GetDataPresent(DataFormats.Text))
            {
                args.Effect = DragDropEffects.Copy;
            }
            else
            {
                args.Effect = DragDropEffects.None;
            }
        }

        private void TextBox_DragDrop(object sender, System.Windows.Forms.DragEventArgs args)
        {
            TextBox txt = (TextBox)sender;

            TextBox source = (TextBox)current_textbox;
            source.Text = txt.Text;
            txt.Text = (string)args.Data.GetData(DataFormats.Text);
        }

    }
}
