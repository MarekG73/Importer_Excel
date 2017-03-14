using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using Importer.Classes_Excel;

namespace Importer_dla_Excela
{
    class ExcelFileCreator
    {
        private Excel.Application excelDocument = new Microsoft.Office.Interop.Excel.Application();
        private Excel.Workbook xlWorkBook;
        private Excel.Worksheet xlWorkSheet;
        private Excel.Range formatRange;
        private object misVal = System.Reflection.Missing.Value;//null

        List<ExcelCellData> documentHead;
        
        public ExcelFileCreator(List<ExcelCellData> docHead)
        {
            xlWorkBook = excelDocument.Workbooks.Add(misVal);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            documentHead = new List<ExcelCellData>(docHead);
            makeExcelDocumentHead();
        }
        
        private void makeExcelDocumentHead()
        {
            foreach(ExcelCellData cellData in documentHead)
            {
                formatRange = xlWorkSheet.get_Range("A1", "Z5");
                formatRange.Font.Size = 8;
                xlWorkSheet.Cells[cellData.row, cellData.column] = cellData.content;
                Excel.Range cell1 = xlWorkSheet.Cells[cellData.row, cellData.column];
                Excel.Range cell2 = xlWorkSheet.Cells[cellData.row, cellData.column + cellData.content.Length/12];
                xlWorkSheet.get_Range(cell1, cell2).Merge(false);
            }
        }
        public Excel.Workbook getWorkbook()
        {
            return xlWorkBook;
        }
        
        public void closeExcelFile()
        {
            xlWorkBook.Close(true, misVal, misVal);
            excelDocument.Quit();
            
        }
    }
}