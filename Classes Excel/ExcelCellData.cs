namespace Importer.Classes_Excel
{
    struct ExcelCellData : IExcelCellData
    {
        private string _content;
        private string _format;
        private int _column;
        private int _row;

        public ExcelCellData(string cnt, string frm, int col, int rw)
        {
            _content = cnt;
            _format = frm;
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
        public string format
        {
            get
            {
                return _format;
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
