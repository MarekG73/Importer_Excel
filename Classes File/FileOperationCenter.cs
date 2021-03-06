﻿using System.Windows.Forms;
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

        private string pattern = "[>]{1}[-\\s*\\d*\\w{2,}]+\\s*[-:;.,&|/\\s*\\d*\\w*]*[<]{1}";
        private string title;

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
                    cleanFile = new CleanerDostawca(readedFile, findPattern);
                    break;
                case "Nabywca - saldo na dzień":
                    cleanFile = new CleanerNabywca(readedFile, findPattern);
                    break;
                case "STAN ZAPASÓW":
                    cleanFile = new CleanerStan(readedFile, findPattern);
                    break;
                default:
                    break;
            }
        }
        public List<List<string>> getHeader()
        {
            return cleanFile.getHeader();
        }
        public List<List<string>> getDataLines()
        {
            return cleanFile.getDataLines();
        }
    }    
}
