using System;
using System.Collections.Generic;

namespace Importer.Classes_File
{
    abstract class FileCleaner
    {
        protected FileReader readedFile;
        protected PatternFinder findPattern;

        protected string readed_line;
        protected string pattern_result;

        protected List<string> table_block;
        protected List<List<string>> data_blocks;
        protected List<List<string>> header;
        protected List<string> original_columns_names;
        protected List<string> columns_names;
        protected List<string> summary;
        protected List<List<string>> resultSummary;
        protected List<string> temp_data_line;
        protected List<List<string>> data_lines;
        protected List<string> tmp = new List<string>();
        public FileCleaner(FileReader fr, PatternFinder pf)
        {
            readedFile = fr;
            findPattern = pf;
            
            splitFileByTable();
            makeHeader();
            setNewColumnNames();
            removeNonData();
            makeData();
        }
        protected abstract void splitFileByTable();//podział pliku według <TABLE>
        protected abstract void setNewColumnNames();//nazwy kolumn inne niż odczytane
        protected abstract void makeData();//tworzy linie danych
        protected void makeHeader()
        {
            header = new List<List<string>>();
            
            for (int i = 0; i < 4; i++)
            {
                data_blocks[i].ForEach(tmp.Add);
            }
            data_blocks.RemoveRange(0, 4);
            
            for (int i = 0; i < 6; i++)
            {
                header.Add(new List<string>());
                if (i == 0 || i == 2)
                {
                    header[i].Add(tmp[0]);
                    header[i].Add("");
                    header[i].Add("");
                    header[i].Add(tmp[1]);
                    fillSpaces(header[i], 8);
                    tmp.RemoveRange(0, 2);
                }
                if (i == 1)
                {
                    header[i].Add(tmp[0]);
                    fillSpaces(header[i], 7);
                    tmp.RemoveAt(0);
                }
                if (i == 4)
                {
                    header[i].Add(tmp[0]);
                    fillSpaces(header[i], 7);
                }
                if (i == 3 || i == 5)
                {
                    fillSpaces(header[i], 8);
                }
            }
        }
        /// <summary>
        /// Wstawia do kontenera 'List' podaną ilość spacji
        /// </summary>
        /// <param name="lst">Kontener do wstawiania</param>
        /// <param name="elem">Ilość spacji</param>
        protected void fillSpaces(List<string> lst, int elem)
        {
            for(int i = 0; i < elem; i++)
            {
                lst.Add(" ");
            }
        }
        protected void removeNonData()
        {
            try
            {
                int remove_start = data_blocks.FindIndex((data_blocks) => { return data_blocks.Contains(header[0][0]); });
                int remove_end = data_blocks.FindIndex((data_blocks) => { return data_blocks.Contains(original_columns_names[original_columns_names.Count - 1]); });
                int elems = (remove_end - remove_start) + 1;
                data_blocks.RemoveRange(remove_start, elems);
            }
            catch (Exception exc)
            {
                return;
            }
        }
        protected void splitCell(List<string> splitted_data_line)
        {
            string text_readed = splitted_data_line[1].ToString();
            int end1 = 0, start2 = 0, spc = 0;

            for (int pos = 0; pos < text_readed.Length; pos++)
            {
                if (text_readed[pos] == 32 && spc == 0)
                {
                    if (text_readed[pos + 1] == 32)
                    {
                        spc = 1;
                        end1 = pos;
                    }
                }
                if (spc == 1 && text_readed[pos] != 32)
                {
                    start2 = pos;
                    break;
                }
            }
            string res2 = text_readed.Substring(start2);
            string res1 = text_readed.Remove(end1);

            splitted_data_line[1] = res1;
            splitted_data_line.Add(res2);
        }
                
        public List<List<string>> getHeader()
        {
            return header;
        }
        public List<List<string>> getDataLines()
        {
            return data_lines;
        }
    }
}