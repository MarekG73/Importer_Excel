using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importer.Classes_File
{
    class TitleFinder
    {
        protected FileReader readedFile;
        protected PatternFinder findPattern;

        protected string title;
       
        public TitleFinder(FileReader fr, PatternFinder pf)
        {
            readedFile = fr;
            findPattern = pf;

            findReportTitle();
        }
        private void findReportTitle()
        {
            string read_line = "";
            bool first_table = false;
            bool end = false;

            while (end != true)
            {
                read_line = readedFile.getLine().ToString();
                if (first_table == false && read_line.Contains("<TABLE"))//pomiń pierwszy znacznik <TABLE
                {
                    first_table = true;
                    continue;
                }
                if (first_table == true)
                {
                    if ((title = findPattern.search(read_line)) != null)
                    {
                        end = true;
                    }
                }
            }
        }
        public string getReportTitle()
        {
            return title;
        }
    }
}
