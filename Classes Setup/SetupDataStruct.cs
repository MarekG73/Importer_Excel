struct SetupDataStruct
{
    private string _excel_path;
    private string _htm_path;
    private string _xls_path;
    
    public string excelPath
    {
        get { return this._excel_path; }
        set { _excel_path = value; }
    }
    public string htmPath
    {
        get { return this._htm_path; }
        set { _htm_path = value; }
    }
    public string xlsPath
    {
        get { return this._xls_path; }
        set { _xls_path = value; }
    }
}
