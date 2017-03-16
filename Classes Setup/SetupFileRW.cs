using System;
using System.Collections.Generic;
using System.IO;

class SetupFileRW
{
    private FileStream setupFileStream;
    private OfficeFinderExcel whereIsExcel;
    //FileInfo fInf;
    private StreamWriter streamWrite;
    private StreamReader streamRead;
    private SetupDataStruct setupData;
    //private string setup_filename;
    private string[] linesForSetupFile;
    
    public SetupFileRW(FileStream f)
    {
        setupFileStream = f;
        streamRead = new StreamReader(f);
        streamWrite = new StreamWriter(f);
        setupData = new SetupDataStruct();
        whereIsExcel = new OfficeFinderExcel();
        linesForSetupFile = new string[3];
        
    }
    internal void setupFileRead(ref SetupFileFinder finder)
    {
        if(setupFileStream.Length <=1)
        {
            whereIsExcel.findPath();
            setupData.excelPath = "excelPath#" + whereIsExcel.getPath();
            setupData.htmPath = "htmPath#" + finder.getHTMDir();
            setupData.xlsPath = "xlsPath#" + finder.getXLSDir();
            this.setupFileWrite();
        }
        while (!streamRead.EndOfStream)
        {
            string line = streamRead.ReadLine();
            if (line.Contains("excelPath"))
            {
                setupData.excelPath = line.Substring(line.IndexOf("#")+1);
            }
            if (line.Contains("htmPath"))
            {
                setupData.htmPath = line.Substring(line.IndexOf("#") + 1);
            }
            if (line.Contains("xlsPath"))
            {
                setupData.xlsPath = line.Substring(line.IndexOf("#") + 1);
            }
        }

    }
    internal void setupFileWrite()
    {
        streamWrite.WriteLine(setupData.excelPath);
        streamWrite.WriteLine(setupData.htmPath);
        streamWrite.WriteLine(setupData.xlsPath);

        streamWrite.Close();
    }
}
