using System;
using System.Windows.Forms;
using Importer_dla_Excela;

namespace Importer_dla_Excela
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void buttonFindExcel_MouseClick(object sender, MouseEventArgs e)
        {
            OfficeFinderExcel path = new OfficeFinderExcel();

            Cursor.Current = Cursors.WaitCursor;

            path.findPath();
            textBoxExcelPath.Text = path.getPath();
            //path.findVersion();
            //textBoxExcelVersion.AppendText(path.getVersion());

            Cursor.Current = Cursors.Default;
        }

        private void buttonPathHTM_MouseClick(object sender, MouseEventArgs e)
        {
            string HTMPath = folderBrowserSettings.SelectedPath;
        }
    }
}