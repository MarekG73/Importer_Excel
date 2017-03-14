using Microsoft.Win32;

abstract class OfficeFinder
{
    protected RegistryKey subKey;
    protected string subkey_path, subkey_version;
    protected string path;
    protected string version;
    
    public OfficeFinder()
    {
        
    }
    public void findPath()
    {
        subKey = Registry.ClassesRoot.OpenSubKey(subkey_path);
        path = ((string)(subKey.GetValue("")));
    }
    public void findVersion()
    {
        subKey = Registry.ClassesRoot.OpenSubKey(subkey_version);
        version = ((string)(subKey.GetValue("")));
    }
    public string getVersion()
    {
        return version;
    }
    public string getPath()
    {
        return path;
    }
}
