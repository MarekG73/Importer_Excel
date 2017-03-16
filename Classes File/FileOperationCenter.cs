using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Importer.Classes_File
{
    class FileOperationCenter
    {
        private FileOpener openedFile;
        private StreamReader stream;
        private FileReader readedForTitleFile;
        private FileReader readedFile;
        private PatternFinder findPattern;
        private TitleFinder findTitle;
        private FileCleaner cleanFile;

        private string pattern = "[>]{1}[\\s*\\d*\\w{2,}]+\\s*[-:;.,|\\s*\\d*\\w*]*[<]{1}";
        private string title;

        private List<List<string>> data_content = new List<List<string>>();
        private List<string> columns_names;

        public FileOperationCenter(OpenFileDialog openFileDialog1)
        {
            findPattern = new PatternFinder(pattern);
            openedFile = new FileOpener(openFileDialog1);

            stream = openedFile.getStream();
            readedForTitleFile = new FileReader(stream);
            findTitle = new TitleFinder(readedForTitleFile, findPattern);
            stream.Close();

            openedFile = new FileOpener(openFileDialog1);
            stream = openedFile.getStream();
            readedFile = new FileReader(stream);
            chooseCleaner();
            stream.Close();


        }
        public string getBoxFilenameText()
        {
            return openedFile.getFilename(); //nazwa pliku w oknie
        }
        public void chooseCleaner()
        {
            title = findTitle.getReportTitle();

            switch (title)
            {
                case "Dostawca - saldo na dzień":
                    break;
                case "Nabywca - saldo na dzień":
                    break;
                case "STAN ZAPASÓW":
                    cleanFile = new CleanerNabywca(readedFile, findPattern);
                    break;
                default:
                    break;
            }
        }
        public List<string> getHeader()
        {
            return cleanFile.getHeader();
        }
        public List<string> getColumnsNames()
        {
            return cleanFile.getColumnsNames();
        }
        public List<List<string>> getDataLines()
        {
            return cleanFile.getDataLines();
        }
        public List<string> getSummary()
        {
            return cleanFile.getSummary();
        }
    }    
}
