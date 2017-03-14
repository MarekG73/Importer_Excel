using System;
using System.Windows.Forms;

namespace Importer_dla_Excela
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
/*
{
            Excel.Application excTest = new Microsoft.Office.Interop.Excel.Application();

            if (excTest == null)
            {
                MessageBox.Show("Brak Excela");
            }

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;

            object misValue = System.Reflection.Missing.Value;//null

            xlWorkBook = excTest.Workbooks.Add(misValue);//nowy arkusz
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);//dodaje zakładkę

            xlWorkSheet.get_Range("a1","c1").Merge(false);//łączy komórki

            xlWorkSheet.Cells[1, 1] = "STAN ZAPASÓW";
            xlWorkSheet.Cells[2, 1] = "Na 31-12-16";

            xlWorkBook.SaveAs("C:\\Users\\Media\\Desktop\\raport.xls",
                Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            excTest.Quit();

            String path = "C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\EXCEL.EXE";
            String filePath = "\"C:\\Users\\Media\\Desktop\\raport.xls\"";
            String fullPath = path + filePath;


            //Console.WriteLine(fullPath);
            //Console.Read();
            Process.Start(path, filePath);
        }
*/