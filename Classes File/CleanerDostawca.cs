using System.Collections.Generic;

namespace Importer.Classes_File
{
    class CleanerDostawca : FileCleaner
    {
        public CleanerDostawca(FileReader fr, PatternFinder pf)
            : base (fr, pf)
        {
        }
        override protected void splitFileByTable()
        {
            table_block = new List<string>();
            data_blocks = new List<List<string>>();
            bool summary_stamp = false;
            bool first_table = false;
            int counter = 0;
            
            while ((readed_line = readedFile.getLine()) != "EOF")
            {
                if (first_table == false && readed_line.Contains("<TABLE"))//pomiń pierwszy znacznik <TABLE
                {
                    first_table = true;
                    continue;
                }
                if (readed_line.Contains("<TABLE"))
                {
                    while (!readed_line.Contains("</TABLE>"))
                    {
                        table_block = new List<string>();
                        if (readed_line.Contains("<TR>"))
                        {
                            while (!readed_line.Contains("</TR>"))
                            {
                                if ((pattern_result = findPattern.search(readed_line)) != null)
                                {
                                    if (pattern_result == "Strona")
                                    {
                                        break; 
                                    }
                                    table_block.Add(pattern_result);
                                    counter++;
                                }
                                readed_line = readedFile.getLine();
                            }
                            if (counter == 4)//podsumowanie
                            {
                                counter = 0;
                                data_blocks.Add(table_block);
                                summary_stamp = true;
                                continue;
                            }
                            if (summary_stamp == true && counter == 2)//podsumowanie
                            {
                                counter = 0;
                                data_blocks.Add(table_block);
                            }
                            data_blocks.Add(table_block);
                        }
                        
                        readed_line = readedFile.getLine();
                    }
                }
            }
        }
        override protected void setNewColumnNames()
        {
            columns_names = new List<string>(){"Data księgowania", "Typ dokumentu", "Nr dokumentu", "Opis", "Waluta", "Kwota",
                    "Kwota PLN", "Nr zapisu" };
        }
        override protected void makeData()
        {
            bool section_summary = false;
            bool section_end = true;
            bool prev_block_3 = false;
            bool end_summary = false;
            bool data_block = true;
            bool empty_line = false;
            data_lines = new List<List<string>>(header);

            data_lines.Add(columns_names);

            foreach (List<string> block in data_blocks)
            {
                if (block.Count == 2 && section_end == true && end_summary == false)
                {
                    temp_data_line = new List<string>() { " ",block[0], block[1] };
                    data_lines.Add(temp_data_line);
                    section_end = false;
                    prev_block_3 = false;
                    continue;
                }
                if (block.Count == 6)
                {
                    //temp_data_line = new List<string>(block);
                    block.Insert(1, " ");
                    block.Insert(4, " ");
                    data_lines.Add(temp_data_line);
                    data_block = true;
                    continue;
                }
                if (block.Count == 7)
                {
                    //temp_data_line = new List<string>(block);
                    block.Insert(4, " ");
                    data_lines.Add(temp_data_line);
                    data_block = true;
                    continue;
                }
                if (block.Count == 8)
                {
                    //temp_data_line = new List<string>(block);
                    data_lines.Add(block);
                    data_block = true;
                    continue;
                }
                if (block.Count == 4 && data_block == true)
                {
                    temp_data_line = new List<string>() { " ", " ", " ", block[0], block[1], block[2], block[3] };
                    data_lines.Add(temp_data_line);
                    section_summary = true;
                    data_block = false;
                    continue;
                }
                if (section_summary == true && block.Count == 3)
                {
                    temp_data_line = new List<string>() { " ", " ", " ", block[1], block[0], " ", block[2] };
                    data_lines.Add(temp_data_line);
                    section_summary = false;
                    section_end = true;
                    prev_block_3 = true;
                    continue;
                }
                if (block.Count == 4 && prev_block_3 == true)
                {
                    if (empty_line == false)
                    {
                        temp_data_line = new List<string>();
                        fillSpaces(temp_data_line, 8);
                        data_lines.Add(temp_data_line);
                        empty_line = true;
                    }
                    temp_data_line = new List<string>() { " ", " ", " ", block[0], block[1], block[2], block[3] };
                    data_lines.Add(temp_data_line);
                    end_summary = true;
                    continue;
                }
                if (block.Count == 2 && end_summary == true)
                {
                    temp_data_line = new List<string>() { " ", " ", " ", block[0], " ", " ", block[1] };
                    data_lines.Add(temp_data_line);
                    continue;
                }
            }
        }
    }
}

