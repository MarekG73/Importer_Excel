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

        public MainWindow()
        {
            InitializeComponent();
        }
        private void buttonOpenFile_MouseClick(object sender, MouseEventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = new FileOperationCenter(openFileDialog1);
                boxFilename.Text = file.getBoxFilenameText();
                
                document_header = file.getHeader()[0];
                textBoxRaportTitle.Text = document_header[0].ToString();
                if (document_header.Count > 0)
                {
                    makeFile.Enabled = true;
                }
            }
        }
        private void buttonSettings_MouseClick(object sender, MouseEventArgs e)
        {
            SettingsWindow SettingsWindow = new SettingsWindow();
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
        }

        private void buttonRunExcel_MouseClick(object sender, MouseEventArgs e)
        {
            excelFile.openFileInExcel();
            buttonRunExcel.Enabled = false;
            buttonSaveXLS.Enabled = false;
        }

        private void makeFile_MouseClick(object sender, MouseEventArgs e)
        {
            data_in_array = file.getDataLines();
            excelFile = new ExcelOperationCenter(data_in_array);

            labelReady.Visible = false;
            buttonRunExcel.Enabled = true;
            buttonSaveXLS.Enabled = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            setupApp = new SetupOperationCenter();//sprawdzenie i odczyt ustawień

        }

        private void makeFile_EnabledChanged(object sender, EventArgs e)
        {
            if (makeFile.Enabled == true)
            {
                labelReady.Visible = true;
            }
            else
            {
                labelReady.Visible = false;
            }
            
        }

        private void buttonRunExcel_EnabledChanged(object sender, EventArgs e)
        {
            if (buttonRunExcel.Enabled == true)
            {
                labelReady.Text = "Plik gotowy ->";
                labelReady.Visible = true;
            }
            else
            {
                labelReady.Visible = false;
            }
        }
    }
}
