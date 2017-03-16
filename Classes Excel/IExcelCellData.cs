namespace Importer.Classes_Excel
{
    interface IExcelCellData
    {
        string content
        {
            get;
        }
        string format
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
