﻿using System.Collections.Generic;

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
        protected List<string> header;
        protected List<string> original_columns_names;
        protected List<string> columns_names;
        protected List<string> summary;
        protected List<string> temp_data_line;
        protected List<List<string>> data_lines;
               
        public FileCleaner(FileReader fr, PatternFinder pf)
        {
            readedFile = fr;
            findPattern = pf;
            
            splitFileByTable();
            makeHeader();
            makeColumns();
            setNewColumnNames();
            removeNonData();
            makeSummary();
            makeData();
        }
        protected abstract void splitFileByTable();//podział pliku według <TABLE>
        protected abstract void setNewColumnNames();//nazwy kolumn inne niż odczytane
        protected abstract void makeSummary();//tworzy podsumowanie całości
        protected abstract void makeData();//tworzy linie danych
        protected void makeHeader()
        {
            header = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                data_blocks[i].ForEach(header.Add);
            }
            data_blocks.RemoveRange(0, 4);
            header.RemoveRange(header.FindIndex((header) => { return header.Contains("Strona"); }), 2);//usunięcie "Strona 1"
        }
        protected void makeColumns()
        {
            original_columns_names = new List<string>(data_blocks[0]);//odczytane nazwy kolumn
            data_blocks.RemoveAt(0);
        }
        
        protected void removeNonData()
        {
            int remove_start = data_blocks.FindIndex((data_blocks) => { return data_blocks.Contains(header[0]); });
            int remove_end = data_blocks.FindIndex((data_blocks) => { return data_blocks.Contains(original_columns_names[original_columns_names.Count - 1]); });
            int elems = (remove_end - remove_start) + 1;
            data_blocks.RemoveRange(remove_start, elems);
        }

        protected void splitCell()
        {
            string text_readed = temp_data_line[1];
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

            temp_data_line[1] = res1;
            temp_data_line[2] = res2;
        }

        public List<string> getHeader()
        {
            return header;
        }
        public List<string> getColumnsNames()
        {
            return columns_names;
        }
        public List<List<string>> getDataLines()
        {
            return data_lines;
        }
        public List<string> getSummary()
        {
            return summary;
        }
    }
}