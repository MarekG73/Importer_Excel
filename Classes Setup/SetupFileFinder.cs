using System.IO;
/// <summary>
/// Wyszukuje i w razie potrzeby tworzy plik settings.ini w głównym folderze aplikacji
/// </summary>
class SetupFileFinder
{
    private FileInfo fileInf;
    private FileStream file;
    private DirectoryInfo dirHTM;
    private DirectoryInfo dirXLS;
    private string setup_filename, htm_dir, xls_dir;

    public SetupFileFinder()
    {
        htm_dir = "./Pliki HTM";
        xls_dir = "./Pliki XLS";
        setup_filename = "./settings.ini";
        fileInf = new FileInfo(setup_filename);
        dirHTM = new DirectoryInfo(htm_dir);
        dirXLS = new DirectoryInfo(xls_dir);

        this.isSetupFilePresent();
        this.isFilesDirsPresent();
    }
    private void isSetupFilePresent()
    {
        if (fileInf.Exists)
        {
            file = new FileStream(setup_filename, FileMode.Open, FileAccess.ReadWrite);
        }
        else
        {
            file = new FileStream(setup_filename, FileMode.Create, FileAccess.ReadWrite);
        }
        file.Close();
    }
    private void isFilesDirsPresent()
    {
        if(!dirHTM.Exists)
        {
            dirHTM.Create();
        }
        if(!dirXLS.Exists)
        {
            dirXLS.Create();
        }
    }
    public string getHTMDir()
    {
        return htm_dir;
    }
    public string getXLSDir()
    {
        return xls_dir;
    }
}

