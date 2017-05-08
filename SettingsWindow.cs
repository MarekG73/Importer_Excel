using System;
using System.Windows.Forms;
using Importer.Properties;

namespace Importer_dla_Excela
{
    public partial class SettingsWindow : Form
    {
        private Settings appSettings;

        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            appSettings = new Settings();

            textBoxExcelPath.Text = appSettings.ExcelPath;

            textBoxPathHTM.Text = appSettings.HTMPath;
            checkBoxAskHTM.Checked = appSettings.HTMPathAsk;

            textBoxPathXLS.Text = appSettings.XLSPath;
            checkBoxAskXLS.Checked = appSettings.XLSPathAsk;

            textBoxXLSFileName.Text = appSettings.xlsFilename;
            checkBoxAskFilename.Checked = appSettings.xlsFilenameAsk;

            checkBoxReset.Checked = false;
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            appSettings.ExcelPath = textBoxExcelPath.Text;
            if (textBoxExcelPath.Text != "")//zmienić w sprawdzenie ścieżki
            {
                appSettings.isExcelPathSet = true;
            }
            
            appSettings.HTMPath = textBoxPathHTM.Text;
            appSettings.HTMPathAsk = checkBoxAskHTM.Checked;

            appSettings.XLSPath = textBoxPathXLS.Text;
            appSettings.XLSPathAsk = checkBoxAskXLS.Checked;

            appSettings.xlsFilename = textBoxXLSFileName.Text;
            appSettings.xlsFilenameAsk = checkBoxAskFilename.Checked;
            appSettings.Save();
            Close();
        }

        private void buttonFindExcel_MouseClick(object sender, MouseEventArgs e)
        {
            OfficeFinderExcel path = new OfficeFinderExcel();

            Cursor.Current = Cursors.WaitCursor;

            path.findPath();
            textBoxExcelPath.Text = path.getPath();
            
            Cursor.Current = Cursors.Default;
        }

        private void buttonPathHTM_MouseClick(object sender, MouseEventArgs e)
        {
            if (folderBrowserHTM.ShowDialog() == DialogResult.OK)
            {
                textBoxPathHTM.Text = folderBrowserHTM.SelectedPath;
            }
            
        }
        private void buttonPathXLS_MouseClick(object sender, MouseEventArgs e)
        {
            if (folderBrowserXLS.ShowDialog() == DialogResult.OK)
            {
                textBoxPathXLS.Text = folderBrowserXLS.SelectedPath;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReset.Checked == true)
            {
                buttonReset.Enabled = true;
                return;
            }
            buttonReset.Enabled = false;
        }

        private void buttonReset_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxExcelPath.Text = "Brak";
            appSettings.isExcelPathSet = false;

            textBoxPathHTM.Text = "Brak";
            checkBoxAskHTM.Checked = false;

            textBoxPathXLS.Text = "C:\\Users\\Media\\Desktop\\";
            checkBoxAskXLS.Checked = false;

            textBoxXLSFileName.Text = "";
            checkBoxAskFilename.Checked = true;
        }
    }
}