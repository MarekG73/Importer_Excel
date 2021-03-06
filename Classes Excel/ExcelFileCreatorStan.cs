﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Importer.Classes_Excel
{
    class ExcelFileCreatorStan : ExcelFileCreator
    {
        public ExcelFileCreatorStan(List<List<string>> sourceFile)
            : base(sourceFile)
        {
        }
        //Buduje dokument Excela z zawartości oczyszczonego pliku
        override protected void makeExcelDocument()
        {
            progWindow = new Progress();
            progWindow.setProgressbarMax(documentContent.Count - 1);
            progWindow.Show();

            int rownum = 1;
            Excel.Range rangeToChange;

            xlWorkSheet.get_Range("A1", "J" + documentContent.Count).Font.Size = 9;

            foreach (List<string> rows in documentContent)
            {
                progWindow.progressBarAdd();

                int colnum = 1;
                if (rownum == 5)
                {
                    Excel.Range cell1 = xlWorkSheet.Cells[5, 1];
                    Excel.Range cell2 = xlWorkSheet.Cells[5, 10];
                    xlWorkSheet.get_Range(cell1, cell2).Merge(false);
                    xlWorkSheet.get_Range(cell1, cell2).Font.Size = 8;
                    xlWorkSheet.Cells[5, 1].Value = rows[0];
                }
                if ((rows.Count == 3 || rows.Count == 9) && rownum > 7)
                {
                    rangeToChange = xlWorkSheet.get_Range("a" + rownum);
                    rangeToChange.EntireRow.Font.Bold = true;
                    rangeToChange.EntireRow.HorizontalAlignment = 3;
                }

                foreach (string cellVal in rows)
                {
                    if (cellVal != " ")
                    {
                        if (colnum == 2 && rownum > 7 && cellVal.Contains("-"))
                        {
                            string goodDate = makeDate(cellVal);
                            Task valTask1 = Task.Run(() => setValue(rownum, colnum, goodDate));
                            Task numTask1 = Task.Run(() => setNumFormat(rownum, colnum, "dd-mm-rr"));
                            Task alignTask1 = Task.Run(() => setAlignment(rownum, colnum, 3));
                            //Task valTask1 = Task.Run(() => setValue(rownum, colnum, goodDate));
                            Task.WaitAll(valTask1, numTask1, alignTask1);
                        }
                        else if ((colnum == 6 || colnum == 8 || colnum == 9) && rownum > 7)
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
                            Task numTask = Task.Run(() => setNumFormat(rownum, colnum, "0,00"));
                            Task.WaitAll(valTask, numTask);
                        }
                        else if ((colnum == 3 || colnum == 4) && rownum > 7)
                        {
                            Task alignTask3 = Task.Run(() => setAlignment(rownum, colnum, 1));
                            Task valTask3 = Task.Run(() => setValue(rownum, colnum, cellVal));
                            Task.WaitAll(valTask3, alignTask3);
                        }
                        else 
                        {
                            Task alignTask2 = Task.Run(() => setAlignment(rownum, colnum, 4));
                            Task valTask2 = Task.Run(() => setValue(rownum, colnum, cellVal));
                            Task.WaitAll(valTask2, alignTask2);
                        }
                    }
                    colnum++;
                }
                rownum++;
            }
            for (int i = 1; i <= 10; i++)
            {
                xlWorkSheet.Columns[i].AutoFit();
            }
            rangeToChange = xlWorkSheet.get_Range("A7", "J7");
            rangeToChange.EntireRow.Font.Bold = true;
            rangeToChange.EntireRow.HorizontalAlignment = 3;
            xlWorkSheet.Cells[5, 1].HorizontalAlignment = 1;

            progWindow.Close();
        }
    }
}