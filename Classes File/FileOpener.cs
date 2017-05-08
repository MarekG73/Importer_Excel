using System.Windows.Forms;
using System.IO;
using System.Text;
using System;

namespace Importer.Classes_File
{
    class FileOpener : IDisposable
    {
        //Otwiera plik na podstawie nazwy uzyskanej z okienka dialogowego.
        private string filename, filepath;
        private OpenFileDialog openDialog;
        private FileStream file;
        private StreamReader stream;
        
        // Instancja okienka używanego do wyszukania pliku przekazywana jest jako parametr do konstruktora.
        public FileOpener(OpenFileDialog dialog)
        {
            Encoding enc = Encoding.GetEncoding(1250);
            openDialog = dialog;
            filename = openDialog.SafeFileName;
            filepath = openDialog.FileName;
            file = new FileStream(filepath, FileMode.Open);
            stream = new StreamReader(file, enc);
        }

        public string getFilename()
        {
            // tylko nazwa, bez ścieżki
            return filename;
        }
        public string getFilepath()
        {
            //nazwa ze ścieżką
            return filepath;
        }
        public StreamReader getStream()
        {
            // Zwraca otworzony strumień do odczytu danych z pliku.
            return stream;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
