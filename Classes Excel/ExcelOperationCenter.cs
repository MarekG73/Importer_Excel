using System.Collections.Generic;
using Importer_dla_Excela;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

class ExcelOperationCenter
{
    private ExcelFileHead head;
    private ExcelFileCreator excelCreateNewFile;
    private object misVal = System.Reflection.Missing.Value;//null

    string file_path = "\"C:\\Users\\Media\\Desktop\\raport.xls\"";
    string path = "C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\EXCEL.EXE";


    public ExcelOperationCenter(ref List<string> sourceFile)//ref?
    {
        head = new ExcelFileHead(ref sourceFile);
        head.ExtractElements();
        excelCreateNewFile = new ExcelFileCreator(head.getHeadElementsData());
    }
    public void saveExcelFile()
    {
        excelCreateNewFile.getWorkbook().SaveAs("C:\\Users\\Media\\Desktop\\raport.xls",
        Excel.XlFileFormat.xlWorkbookNormal, misVal, misVal, misVal, misVal, Excel.XlSaveAsAccessMode.xlExclusive, misVal, misVal, misVal, misVal);
        
        excelCreateNewFile.closeExcelFile();
    }
    public void openFileInExcel()
    {
        this.saveExcelFile();
        string fullPath = path + file_path;
        Process.Start(path, file_path);
        //excelCreateNewFile.closeExcelFile();
    }
}
    