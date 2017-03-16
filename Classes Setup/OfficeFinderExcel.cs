class OfficeFinderExcel: OfficeFinder
{
    public OfficeFinderExcel()
        :base()
    {
        subkey_path = @"ExcelChart\protocol\StdFileEditing\server";
        subkey_version = @"Excel.Application\CurVer";
    }
}
