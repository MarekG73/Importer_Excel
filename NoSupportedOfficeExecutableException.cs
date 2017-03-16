using System;

namespace Importer_dla_Excela
{
    class NoSupportedOfficeExecutableException: Exception
    {
        public static string NoSupportedMessage()
        {
            return "Plik nie jest obsługiwanym plikiem .exe pakietu Office. Dopuszczalne nazwy: Word, Excel, Access";
        }
    }
}

/*
 * class FileReader
{
    //Odczytuje plik wierszami
    private string line, converted_line;
    private List<string>content;
    
    public void setContent(StreamReader stream)
    {
        content = new List<string>();
        Encoding ascii = Encoding.ASCII;
        Encoding unicode = Encoding.Unicode;
        Encoding utf8 = Encoding.UTF8;
        
        while ((line = stream.ReadLine()) != null)
        {
            byte[] sourceBytes = Encoding.GetEncoding(1250).GetBytes(stream.ReadLine());
            byte[] destBytes = Encoding.Convert(Encoding.GetEncoding(1250), Encoding.GetEncoding("utf-8"), sourceBytes);

            converted_line = Encoding.GetEncoding("utf-8").GetString(destBytes);
            content.Add(converted_line);
        }
    }
    public List<string> getContent()
    {
        return content;
    }
}
 * */

/*
{
            **Excel.Application excTest = new Microsoft.Office.Interop.Excel.Application();

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
