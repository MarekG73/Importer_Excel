using Importer.Properties;
/// <summary>
/// Odczytuje i zwraca ustawienia aplikacji
/// </summary>
class SetupFileReader
{
    private SetupDataStruct readSetupData;
    private Settings appSettings;

    public SetupFileReader()
    {
        readSetupData = new SetupDataStruct();
        appSettings = new Settings();

        readSetupData.excelPath = appSettings.ExcelPath;
        readSetupData.is_excel_path_set = appSettings.isExcelPathSet;

        readSetupData.htmPath = appSettings.HTMPath;
        readSetupData.htm_path_ask = appSettings.HTMPathAsk;

        readSetupData.xlsPath = appSettings.XLSPath;
        readSetupData.xls_path_ask = appSettings.XLSPathAsk;

        readSetupData.xlsCreatedFileName = appSettings.xlsFilename;
        readSetupData.xls_filename_ask = appSettings.xlsFilenameAsk;    
    }
    public SetupDataStruct getSetttingsData()
    {
        return readSetupData;
    }   
}
