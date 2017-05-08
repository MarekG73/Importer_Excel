using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace Importer.Classes_Excel
{
    class ExcelOperationCenter
    {
        private ExcelFileCreator excelCreateNewFile;
        private object misVal = System.Reflection.Missing.Value;//null

        private List<List<string>> sourceFileValues;
        
        string file_path = "\"C:\\Users\\Media\\Desktop\\raport.xls\"";////
        string path = "C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\EXCEL.EXE";////
        private int columns_number;
        private string doc_title;

        public ExcelOperationCenter(List<List<string>> sourceFile)
        {
            sourceFileValues = new List<List<string>>(sourceFile);
            doc_title = sourceFile[0][0];
            columns_number = sourceFile[0].Count;
            chooseCreator(); 
        }
        public void saveExcelFile()
        {
            excelCreateNewFile.getWorkbook().SaveAs("C:\\Users\\Media\\Desktop\\raport.xls",
            Excel.XlFileFormat.xlWorkbookNormal, misVal, misVal, misVal, misVal, Excel.XlSaveAsAccessMode.xlExclusive, misVal, misVal, misVal, misVal, true);

            excelCreateNewFile.closeExcelFile();
        }
        public void openFileInExcel()
        {
            this.saveExcelFile();
            string fullPath = path + file_path;
            Process.Start(path, file_path);
            //excelCreateNewFile.closeExcelFile();
        }
        public void chooseCreator()
        {
            switch (doc_title)
            {
                case "Dostawca - saldo na dzień":
                    excelCreateNewFile = new ExcelFileCreatorDostawca(sourceFileValues);
                    break;
                case "Nabywca - saldo na dzień":
                    excelCreateNewFile = new ExcelFileCreatorNabywca(sourceFileValues);
                    break;
                case "STAN ZAPASÓW":
                    excelCreateNewFile = new ExcelFileCreatorStan(sourceFileValues);
                    break;
                default:
                    break;
            }
        }
    }
}