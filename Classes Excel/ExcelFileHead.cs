using System.Collections.Generic;
using Importer.Classes_Excel;

namespace Importer_dla_Excela
{
    class ExcelFileHead
    {
        private List<string> sourceFileContent;
        private List<ExcelCellData> documentHead = new List<ExcelCellData>();
        ExcelCellData cellData; 

        public ExcelFileHead(ref List<string>src)
        {
            sourceFileContent = src;
        }

        public void ExtractElements()
        {
            int add_free_row = 0;
            if(sourceFileContent[0] != "")
            {
                for(int i = 1; i < 2; i++)
                {
                    for (int j = 1; j <= 4; j++)
                    {
                        if(j == 4)
                        {
                            add_free_row += 1;
                        }
                        documentHead.Add(cellData = new ExcelCellData(sourceFileContent[0], "@", i, j + add_free_row));
                        sourceFileContent.RemoveAt(0);
                        
                        if(j != 2 & j != 4)
                        {
                            documentHead.Add(cellData = new ExcelCellData(sourceFileContent[0], "@", i+3, j));
                            sourceFileContent.RemoveAt(0);
                        }
                    }
                }
            }
        }
        public List<ExcelCellData> getHeadElementsData()
        {
            return documentHead;
        }
    }
}