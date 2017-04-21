using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace Importer.Classes_Excel
{
    abstract class ExcelFileCreator
    {
        protected Excel.Application excelDocument = new Microsoft.Office.Interop.Excel.Application();
        protected Excel.Workbook xlWorkBook;
        protected Excel.Worksheet xlWorkSheet;
        protected Progress progWindow;
        protected object misVal = System.Reflection.Missing.Value;//null
        protected int columns_number;
        protected int rows_number;
        protected int progBarValue;

        protected List<List<string>> documentContent;
                
        public ExcelFileCreator(List<List<string>> sourceFile)
        {
            xlWorkBook = excelDocument.Workbooks.Add(misVal);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            documentContent = new List<List<string>>(sourceFile);
            makeExcelDocument();
        }
        //Buduje dokument Excela z zawartości List<ExcelCellData>
        protected abstract void makeExcelDocument();
        
        public Excel.Workbook getWorkbook()
        {
            return xlWorkBook;
        }
        
        public void closeExcelFile()
        {
            xlWorkBook.Close(true, misVal, misVal);
            excelDocument.Quit();
        }
        public string makeDate(string currDate)
        {
            string result = "", current = currDate;
            if (current.Length == 8 && !current.Contains("Suma PLN"))
            {
                int year = int.Parse(current.Substring(6));
                current = current.Remove(5);
                int month = int.Parse(current.Substring(3));
                current = current.Remove(2);
                int day = int.Parse(current);

                var date = new DateTime(year + 2000, month, day);
                result = date.ToString("d");
            }

            return result;
        }
        protected void setValue(int rw, int cl, string vl)
        {
            xlWorkSheet.Cells[rw, cl].Value = vl;
        }
        protected void setNumFormat(int rw, int cl, string frm)
        {
            xlWorkSheet.Cells[rw, cl].NumberFormat = frm;
        }
        protected void setAlignment(int rw, int cl, int al)
        {
            xlWorkSheet.Cells[rw, cl].HorizontalAlignment = al;
        }
    }
}