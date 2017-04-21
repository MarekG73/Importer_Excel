namespace Importer.Classes_Excel
{
    struct ExcelCellData : IExcelCellData
    {
        private string _content;
        private int _column;
        private int _row;

        public ExcelCellData(string cnt, int col, int rw)
        {
            _content = cnt;
            _column = col;
            _row = rw;
        }
        public string content
        {
            get
            {
                return _content;
            }
        }
        public int column
        {
            get
            {
                return _column;
            }
        }
        public int row
        {
            get
            {
                return _row;
            }
        }
    }
}
