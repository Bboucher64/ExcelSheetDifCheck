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
            Alpha.conn = "Excel File=C:\\"+Input.FilePath;

            DataTable dtTables = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(Alpha.conn))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("selct * from sheet ", connection);
                //command.Parameters.AddWithValue("@dept", Input.);
                //command.Parameters.AddWithValue("@dept", dept);
                //command.Parameters.AddWithValue("@dept", dept);
                //command.Parameters.AddWithValue("@dept", dept);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                // adapter.FillSchema(ds
                adapter.Fill(dtTables);
                return dtTables;
            }
        }
    }
}
