using System.Collections.Generic;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Importer.Classes_Excel
{
    class ExcelFileCreatorNabywca : ExcelFileCreator
    {
        public ExcelFileCreatorNabywca(List<List<string>> sourceFile)
            : base (sourceFile)
        {
        }
        //Buduje dokument Excela z zawartości oczyszczonego pliku
        override protected void makeExcelDocument()
        {
            progWindow = new Progress();
            progWindow.setProgressbarMax(documentContent.Count);
            progWindow.Show();

            int rownum = 1;
            Excel.Range rangeToChange;

            xlWorkSheet.get_Range("A1", "H" + documentContent.Count).Font.Size = 9;     
                                
            foreach (List<string> rows in documentContent)
            {
                progWindow.progressBarAdd();
                int colnum = 1;
                if (rownum == 5)
                {
                    Excel.Range cell1 = xlWorkSheet.Cells[5, 1];
                    Excel.Range cell2 = xlWorkSheet.Cells[5, 8];
                    xlWorkSheet.get_Range(cell1, cell2).Merge(false);
                    xlWorkSheet.Cells[5, 1].Value = rows[0];
                }
                if (rows[0] == " " && rownum > 7)
                {
                    rangeToChange = xlWorkSheet.get_Range("a" + rownum);
                    rangeToChange.EntireRow.Font.Bold = true;
                    rangeToChange.EntireRow.HorizontalAlignment = 2;
                }

                foreach (string cellVal in rows)
                {
                    if (cellVal != " ")
                    {
                        if ((colnum == 6 || colnum == 7) && rownum > 7)
                        {
                            string goodNum = cellVal;
                            if (goodNum.Contains(","))
                            {
                                goodNum = goodNum.Replace(",", ".");
                            }
                            while (goodNum.Contains(" "))
                            {
                                int del_it = goodNum.IndexOf(' ');
                                goodNum = goodNum.Remove(del_it, 1);
                            }
                            Task valTask = Task.Run(() => setValue(rownum, colnum, goodNum));
                            Task alignTask = Task.Run(() => setAlignment(rownum, colnum, 4));
                            Task numTask = Task.Run(() => setNumFormat(rownum, colnum, "# ##0,00"));//# ##0,00
                            Task.WaitAll(valTask, numTask);
                        }
                        else if (colnum == 1 && rownum > 8)
                        {
                            string goodDate = makeDate(cellVal);
                            Task numTask1 = Task.Run(() => setNumFormat(rownum, colnum, "dd-mm-rr"));
                            Task alignTask1 = Task.Run(() => setAlignment(rownum, colnum, 3));
                            Task valTask1 = Task.Run(() => setValue(rownum, colnum, goodDate));
                            Task.WaitAll(valTask1, numTask1, alignTask1);
                        }
                        else
                        {
                            Task alignTask2 = Task.Run(() => setAlignment(rownum, colnum, 3));
                            Task valTask2 = Task.Run(() => setValue(rownum, colnum, cellVal));
                            Task.WaitAll(valTask2, alignTask2);
                        }
                    }
                    colnum++;
                }
                rownum++;
            };
            for (int i = 1; i <= 8; i++)
            {
                xlWorkSheet.Columns[i].AutoFit();
            }
            rangeToChange = xlWorkSheet.get_Range("A7", "H7");
            rangeToChange.EntireRow.Font.Bold = true;
            rangeToChange.EntireRow.HorizontalAlignment = 3;
            xlWorkSheet.Cells[5, 1].HorizontalAlignment = 1;

            progWindow.progressBarStop();
            progWindow.Close();
        }
    }
}