namespace Importer.Classes_Excel
{
    interface IExcelCellData
    {
        string content
        {
            get;
        }
        int column
        {
            get;
        }
        int row
        {
            get;
        }
    }
}
