using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSheetDifCheck
{
    class ExcelQueries
    {
        public static DataTable CallExcel(InputModel Input)
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
    }
}
