using System.Collections.Generic;

namespace Importer.Classes_Excel
{
    class ExcelFileContent
    {
        private List<List<string>> sourceFileContent;
        private List<ExcelCellData> documentContent = new List<ExcelCellData>();
        ExcelCellData cellData; 

        public ExcelFileContent(List<List<string>>src)
        {
            sourceFileContent = src;
        }

        public void ExtractElements()
        {
            if(sourceFileContent[0][0].ToString() != "")
            {
                for(int i = 1; i <= sourceFileContent.Count; i++)
                {
                    for (int j = 1; j <= sourceFileContent[i - 1].Count; j++)
                    {
                       documentContent.Add(cellData = new ExcelCellData(sourceFileContent[i - 1][j - 1], j, i));
                    }
                }
            }
        }
        public List<ExcelCellData> getExcelDocumentContent()
        {
            return documentContent;
        }
    }
}