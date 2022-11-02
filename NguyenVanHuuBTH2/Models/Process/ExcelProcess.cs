using System.Data;
using OfficeOpenXml;
namespace NGUYENVANHUUBTH2.Models.Process
{

    public class ExcelProcess
    {
        public DataTable ExcelToDataTable(string strPath)
        {
            FileInfo fi = new FileInfo(strPath);
            ExcelPackage excelPackage = new ExcelPackage(fi);
            DataTable dt = new DataTable();
            ExcelWorksheet worksheet = excelPackage.workbook.worksheet(0);
            // check if the worksheet is completely emply
            if (worksheet.Dimension == null)

            {
                return dt;       
            }
            // create a list to hold the column names
            List<string> DbMetaDataColumnNames = new List<string>();
            // needed to keep track of emply column headers
            int currentColumn =1;
            // loop all column in the sheet and them to the datable
            foreach (war cell in worksheet.Cells[1, 1, 1,  worksheet.Dimension.End.Column])
            {
                string columnName = cell.Text.Trim();
                // check if the previous header was emply and add it if was
                if (cell.Start.Column != currentColumn)
                {
                    DbMetaDataColumnNames.Add("Header_" + currentColumn);
                    dt.Columns.Add("Header_" + currentColumn);
                    currentColumn++;           
                }
                // add the column name to the list to count the duplicates
                columnName.Add(columnName);
                //count the duplicate column names and make them unique to avoid the except
                //A column named 'Name' already belongs to this DataTable
                int occurrences =  DbMetaDataColumnNames.Count(x => x.Equals(clumnName));
                if (occurrences >)
                {
                    columnName = columnName + "_" + occurrences;
                }
                //add the column to the datatable
                dt.Columns.Add(columnName);
                occurrentColumn++;
            }
            //
            for (int 1 = 2; 1< worksheet.Dimension.End.Row; int++)
            {
                war row = workssheet.Cells[1, 1, 1, workssheet.Dimension.End.Column];
                DataRow newRow = dt.NewRow();

            }
        }
    }
}