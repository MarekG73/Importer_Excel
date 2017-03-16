using System.Windows.Forms;
using System.Collections.Generic;
using Importer.Classes_File;
using Importer.Classes_Excel;

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
                //cleaned_content = file.getCleanFile();//pobranie zawartości po czyszczeniu

                document_header = file.getHeader();
                columns_names_in_array = file.getColumnsNames();
                data_in_array = file.getDataLines();
                summary_in_array = file.getSummary();

                textBoxRaportTitle.Text = document_header[0];
                //excelFile = new ExcelOperationCenter(ref file_in_array);
                if(document_header.Count > 0)
                {
                    buttonRunExcel.Enabled = true;
                    buttonSaveXLS.Enabled = true;
                }
                makeColumnsNames();
                //richTextBox1.Lines = document_header.ToArray();//temp
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
            int ile = columns_names_in_array.Count;
            tablePanel1.ColumnCount = ile;
            this.tablePanel1.Size = new System.Drawing.Size(ile * 87, 24);

            for (int i = 0; i < ile; i++)
            {
                fields.Add(new TextBox());
                tablePanel1.Controls.Add(this.fields[i], i, 0);
                this.fields[i].AllowDrop = true;
                this.fields[i].BackColor = System.Drawing.Color.White;
                this.fields[i].BorderStyle = BorderStyle.FixedSingle;
                this.fields[i].Cursor = System.Windows.Forms.Cursors.Hand;
                this.fields[i].Dock = System.Windows.Forms.DockStyle.Fill;
                this.fields[i].Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.fields[i].Location = new System.Drawing.Point(1 + i * 86, 1);
                this.fields[i].Margin = new System.Windows.Forms.Padding(0);
                this.fields[i].MaximumSize = new System.Drawing.Size(85, 20);
                this.fields[i].MinimumSize = new System.Drawing.Size(85, 20);
                this.fields[i].Multiline = true;
                this.fields[i].Name = "A" + i;
                this.fields[i].Size = new System.Drawing.Size(85, 20);
                this.fields[i].TabIndex = 100 + i;
                this.fields[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.fields[i].DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
                this.fields[i].DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_DragEnter);
                this.fields[i].MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseDown);
                this.fields[i].Text = columns_names_in_array[i];
                this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));

                data_fields.Add(new TextBox());
                tablePanel1.Controls.Add(this.data_fields[i], i, 1);
                this.data_fields[i].AllowDrop = true;
                this.data_fields[i].BackColor = System.Drawing.Color.White;
                this.data_fields[i].BorderStyle = BorderStyle.FixedSingle;
                this.data_fields[i].Cursor = System.Windows.Forms.Cursors.Hand;
                this.data_fields[i].Dock = System.Windows.Forms.DockStyle.Fill;
                this.data_fields[i].Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.data_fields[i].Location = new System.Drawing.Point(1 + i * 86, 1);
                this.data_fields[i].Margin = new System.Windows.Forms.Padding(0);
                this.data_fields[i].MaximumSize = new System.Drawing.Size(85, 20);
                this.data_fields[i].MinimumSize = new System.Drawing.Size(85, 20);
                this.data_fields[i].Multiline = true;
                this.data_fields[i].Name = "A" + i;
                this.data_fields[i].Size = new System.Drawing.Size(85, 20);
                this.data_fields[i].TabIndex = 200 + i;
                this.data_fields[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.data_fields[i].DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
                this.data_fields[i].DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_DragEnter);
                this.data_fields[i].MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseDown);
                this.data_fields[i].Text = data_in_array[0][i];//do zmiany, to tylko jedna linia próbna!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));

            }
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

        private void button1_MouseClick(object sender, MouseEventArgs e)//element temp, treść do metody sumującej dokument
        {
            columns_names_in_array.Clear();

            for (int i = 0; i < fields.Count; i++)
            {
                string colname = fields[i].Text;
                columns_names_in_array.Add(colname);
            }
            foreach (string col in columns_names_in_array)
            {
                //richTextBox1.AppendText(col);
            }
        }

    }
}
