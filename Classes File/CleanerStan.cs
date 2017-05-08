using System.Collections.Generic;

namespace Importer.Classes_File
{
    class CleanerStan : FileCleaner
    {
        public CleanerStan(FileReader fr, PatternFinder pf)
            : base (fr, pf)
        {            
        }

        //Podział pliku według znaczników <TABLE>
        override protected void splitFileByTable()
        {
            data_blocks = new List<List<string>>();
            bool first_table = false;
            bool last_table = false;
            bool end_of_page = false;
            short new_page_start = 0;
            short header_counter = 0;

            while ((readed_line = readedFile.getLine()) != "EOF")
            {
                if (first_table == false && readed_line.Contains("<TABLE"))
                {
                    first_table = true;
                    continue;
                }
                if (readed_line.Contains("<TABLE") && header_counter < 4 && first_table == true)
                {
                    header_counter++;
                }
                if (readed_line.Contains("</TABLE>") && first_table == true && header_counter == 4)
                {
                    end_of_page = true;
                }
                if (readed_line.Contains("<TABLE") && end_of_page == true && new_page_start < 5 && header_counter == 4)
                {
                    new_page_start++;
                    continue;
                }
                if (readed_line.Contains("<TABLE") && end_of_page == true && new_page_start == 5 && header_counter == 4)
                {
                    end_of_page = false;
                }
                if (readed_line.Contains("<TABLE") && first_table == true && end_of_page == false)
                {
                    new_page_start = 0;
                    while (!(readed_line = readedFile.getLine()).Contains("</TABLE>"))
                    {
                        table_block = new List<string>();
                        if (readed_line.Contains("<TR>"))
                        {
                            while (!(readed_line = readedFile.getLine()).Contains("</TR>"))
                            {
                                if ((pattern_result = findPattern.search(readed_line)) != null)
                                {
                                    if (pattern_result == "Strona")
                                    {
                                        break;
                                    }
                                    if (pattern_result.ToLower().Contains("suma"))
                                    {
                                        last_table = true;
                                        break;
                                    }
                                    table_block.Add(pattern_result);
                                }
                            }
                            data_blocks.Add(table_block);
                        }
                    }
                }
                //dodaje ostatnią pozycję, błędnie umieszczoną na końcu poza blokami
                if (last_table == true && (pattern_result = findPattern.search(readed_line.ToString())) != null && pattern_result.Length > 2)
                {
                    table_block = new List<string>();
                    fillSpaces(table_block, 7);
                    table_block.Add("Suma");
                    table_block.Add(pattern_result);
                    table_block.Add(" ");
                    data_blocks.Add(table_block);
                }
            }
        }

        override protected void setNewColumnNames()
        {
            data_blocks.RemoveAt(0);//usuwa stare nazwy kolumn
            columns_names = new List<string>(){"Nr. dokumentu", "Data", "Typ zapisu", "Dostawca",
                    "Podst. j.m.", "Ilość", "Nr. partii", "Koszt jednostkowy", "Wycena zapasów", "Kod lokalizacji" };
        }
        //tworzy linie danych
        override protected void makeData()
        {
            data_lines = new List<List<string>>(header);
            data_lines.Add(columns_names);

            foreach (List<string> block in data_blocks)
            {
                if (block.Count == 2)
                {
                    splitCell(block);
                    data_lines.Add(block);
                    continue;
                }
                if (block.Count == 9)
                {
                    block.Insert(3, " ");
                    data_lines.Add(block);
                    continue;
                }
                if (block.Count == 10)
                {
                    data_lines.Add(block);
                    continue;
                }
                if (block.Count == 6)
                {
                    temp_data_line = new List<string>();
                    fillSpaces(temp_data_line, 2);

                    block.InsertRange(0, temp_data_line);
                    block.Insert(6, " ");
                    data_lines.Add(block);
                    continue;
                }
            }
        }
    }
}
