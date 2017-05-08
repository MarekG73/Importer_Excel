/// <summary>
/// Zawiera informacje dotyczące ustawień aplikacji.
/// Odczyt przy uruchomieniu, zapis przy zamknięciu.
/// Startowe w 'DefaultSettings'
/// </summary>
struct SetupDataStruct
{
    private string _excel_path;
    private bool _is_excel_path_set;

    private string _htm_path;
    private bool _htm_path_ask;

    private string _xls_path;
    private bool _xls_path_ask;

    private string _xls_file_name;
    private bool _xls_filename_ask;
        
    public string excelPath
    {
        get { return _excel_path; }
        set { _excel_path = value; }
    }
    public string htmPath
    {
        get { return _htm_path; }
        set { _htm_path = value; }
    }
    public string xlsPath
    {
        get { return _xls_path; }
        set { _xls_path = value; }
    }
    public string xlsCreatedFileName
    {
        get { return _xls_file_name; }
        set { _xls_file_name = value; }
    }
    public bool is_excel_path_set
    {
        get { return _is_excel_path_set; }
        set { _is_excel_path_set = value; }
    }
    public bool htm_path_ask
    {
        get { return _htm_path_ask; }
        set { _htm_path_ask = value; }
    }
    public bool xls_path_ask
    {
        get { return _xls_path_ask; }
        set { _xls_path_ask = value; }
    }
    public bool xls_filename_ask
    {
        get { return _xls_filename_ask; }
        set { _xls_filename_ask = value; }
    }
}
