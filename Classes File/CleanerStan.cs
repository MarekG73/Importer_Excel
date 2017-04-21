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

            while ((readed_line = readedFile.getLine()) != "EOF")
            {
                if (first_table == false && readed_line.Contains("<TABLE"))//pomiń pierwszy znacznik <TABLE
                {
                    first_table = true;
                    continue;
                }
                if (readed_line.ToString().Contains("<TABLE") && first_table == true)
                {
                    table_block = new List<string>();
                    while (!readed_line.Contains("</TABLE>"))
                    {
                        if ((pattern_result = findPattern.search(readed_line)) == "Strona")
                        {
                            break;
                        }
                        if ((pattern_result = findPattern.search(readed_line)) != null)
                        {
                            table_block.Add(pattern_result);
                        }
                        readed_line = readedFile.getLine();
                        if (readed_line.ToString().ToLower().Contains("suma"))
                        {
                            last_table = true;
                        }
                    }
                    data_blocks.Add(table_block);

                }
                //dodaje ostatnią pozycję, błędnie umieszczoną na końcu poza blokami
                if (last_table == true && (pattern_result = findPattern.search(readed_line.ToString())) != null && pattern_result.Length > 2)
                {
                    table_block = new List<string>();
                    table_block.Add(pattern_result);
                    data_blocks.Add(table_block);
                }
            }
        }

        override protected void setNewColumnNames()
        {
            columns_names = new List<string>(){"Nr. zapasu", "Opis 1", "Opis 2", "Data", "Typ zapisu", "Dostawca",
                    "Podst. j.m.", "Ilość", "Nr. partii", "Koszt jednostkowy", "Wycena zapasów", "Kod lokalizacji" };
        }
        //tworzy podsumowanie całości - ostatnia linia
        override protected void makeSummary()
        {
            summary = new List<string>();
            int sum_block_start = data_blocks.FindIndex((data_blocks) => { return data_blocks.Count == 7; });
            int sum_position = data_blocks[sum_block_start].Count - 1;
            
            fillSpaces(summary, 9);
            summary.Add(data_blocks[sum_block_start][sum_position]);
            summary.Add(data_blocks[sum_block_start + 1][0]);
            summary.Add(" ");

            data_blocks[sum_block_start].RemoveAt(sum_position);
            data_blocks.RemoveAt(sum_block_start + 1);
        }
        //tworzy linie danych
        override protected void makeData()
        {
            bool data = false;
            data_lines = new List<List<string>>(header);

            data_lines.Add(columns_names);

            foreach (List<string> block in data_blocks)
            {
                if (block.Count == 2)
                {
                    temp_data_line = new List<string>(block);
                    data = true;
                }
                if (data == true && block.Count == 10)
                {
                    temp_data_line.AddRange(block);
                    splitCell();
                    data_lines.Add(temp_data_line);
                    data = false;
                }
                if (data == false && block.Count == 6)
                {
                    temp_data_line = new List<string>();
                    fillSpaces(temp_data_line, 4);

                    block.InsertRange(2, temp_data_line);
                    block.Insert(8, " ");
                    block.Add(" ");
                    
                    data_lines.Add(block);
                }
            }
            data_lines.Add(summary);
        }
    }
}
