using System.IO;
using System.Text;

namespace Importer.Classes_File
{
    class FileReader
    {
        //Odczytuje z pliku wiersz
        StreamReader stream;
        private string line;
        private string title;

        public FileReader(StreamReader strm)
        {
            stream = strm;
        }

        public string getLine()
        {
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;
            Encoding utf8 = Encoding.UTF8;

            if (!stream.EndOfStream)
            {
                byte[] sourceBytes = Encoding.GetEncoding(1250).GetBytes(stream.ReadLine());
                byte[] destBytes = Encoding.Convert(Encoding.GetEncoding(1250), Encoding.GetEncoding("utf-8"), sourceBytes);
                line = Encoding.GetEncoding("utf-8").GetString(destBytes);
                return line;
            }
            return "EOF";
        }
    }
}