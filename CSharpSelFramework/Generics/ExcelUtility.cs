using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelFramework.Generics
{
    public class ExcelUtility
    {
        /*
         * method to read the data from excel file
         */
        public String ReadDataFromExcel(String sheetName, int rowNum, int colNum)
        {
            var workBook = new XLWorkbook(@"E:\Test Yanta\C# Files\CSharpSelFramework\CSharpSelFramework\TestData\workBook.xlsx");
            var workSheet = workBook.Worksheet(sheetName);
            var values = workSheet.Cell(rowNum, colNum).Value;
            string? value = values.ToString();
            return value;
        }
    }
}
