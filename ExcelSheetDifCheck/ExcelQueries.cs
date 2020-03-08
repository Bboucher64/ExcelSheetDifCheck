using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSheetDifCheck
{
    class ExcelQueries
    {
        public static TablesFromExcelModel GenerateTablesFromExcel(InputModel Input)
        {
            TablesFromExcelModel tables = new TablesFromExcelModel();
            tables.Con = GetCon(Input);
            tables.Exp = GetExp(Input);
            return tables;
        }
        public static DataTable GetCon(InputModel Input)
        {
            Alpha.conn = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                         "Data Source='" + Input.FilePath +
                         "';Extended Properties=\"Excel 12.0;HDR=YES;\"";

            DataTable dtTables = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(Alpha.conn))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM [" + Input.SheetCon + "$]", connection);
                //command.Parameters.AddWithValue("@dept", Input.);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dtTables);

                return dtTables;

            }
        }
        public static DataTable GetExp(InputModel Input)
        {
            Alpha.conn = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                         "Data Source='" + Input.FilePath +
                         "';Extended Properties=\"Excel 12.0;HDR=YES;\"";

            DataTable dtTables = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(Alpha.conn))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM [" + Input.SheetExp + "$]", connection);
                //command.Parameters.AddWithValue("@dept", Input.);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dtTables);

                return dtTables;

            }
        }
        public static List<string> GetSheets(InputModel Input)
        {
            Alpha.conn = "Provider=Microsoft.ACE.OLEDB.12.0;" +
             "Data Source='" + Input.FilePath +
             "';Extended Properties=\"Excel 12.0;HDR=YES;\"";
            List<string> workSheets = new List<string>();

            Microsoft.Office.Interop.Excel.ApplicationClass xlsApp = new Microsoft.Office.Interop.Excel.ApplicationClass();

            Microsoft.Office.Interop.Excel.Workbook book = xlsApp.Workbooks.Open(Input.FilePath, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            foreach (Microsoft.Office.Interop.Excel.Worksheet sheet in book.Worksheets)
            {
                workSheets.Add(sheet.Name);
            }
            xlsApp.Workbooks.Close();
            xlsApp.Quit();
            return workSheets;
        }
    }
}
