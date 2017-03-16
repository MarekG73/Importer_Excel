using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SetupOperationCenter
{
    public SetupDataStruct iniData = new SetupDataStruct();
    private SetupFileFinder finder;
    private SetupFileRW fileRW;
    FileStream stream;
    private string setup_filename;


    public SetupOperationCenter()
    {
        setup_filename = "./settings.ini";
        finder = new SetupFileFinder();
        stream = new FileStream(setup_filename, FileMode.Open, FileAccess.ReadWrite);
        fileRW = new SetupFileRW(stream);
        fileRW.setupFileRead(ref finder);
    }
    public void getDataFromSetupFile()
    {
        fileRW.setupFileRead(ref finder);
    }
}
