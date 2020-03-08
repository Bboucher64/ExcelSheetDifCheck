using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ExcelSheetDifCheck
{
    class ComparingLogic
    {
        public static DataTable Start(TablesFromExcelModel Tables)
        {
            DataTable Output = new DataTable();
            string ConValue;
            string ExpValue;
            try
            {
                for (int Y = 0; Y < Tables.Con.Columns.Count; Y++)
                {
                    Output.Columns.Add(Y.ToString());
                    for (int X = 0; X < Tables.Con.Rows.Count; X++)
                    {
                        Output.Rows.Add();
                        try
                        {
                            ConValue = Tables.Con.Rows[X][Y].ToString();
                        }
                        catch
                        {
                            ConValue = string.Empty;
                        }
                        try
                        {
                            ExpValue = Tables.Exp.Rows[X][Y].ToString();
                        }
                        catch
                        {
                            ExpValue = string.Empty;
                        }
                        if (ConValue != ExpValue)
                        {
                            Output.Rows[X][Y] = ExpValue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Output;
        }
    }
}
