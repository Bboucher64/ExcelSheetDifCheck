using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelSheetDifCheck
{
    public partial class Form1 : Form
    {
        InputModel Input = new InputModel();

        public Form1()
        {
            InitializeComponent();
        }
        private void SelectFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Input.FilePath = ofd.FileName;
            }
            FilePathLbl.Text = Input.FilePath;
            FillConSheetCmbBox(Input);
            FillExpSheetCmbBox(Input);
        }
        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            Input.SheetCon = SheetConCmb.Text;
            Input.SheetExp = SheetExpCmb.Text;
            DisplayDgv.DataSource= ComparingLogic.Start(ExcelQueries.GenerateTablesFromExcel(Input));
        }
        private void FillConSheetCmbBox(InputModel Input)
        {
            Input.workSheets = ExcelQueries.GetSheets(Input);
            SheetConCmb.Items.Clear();
            foreach (string Sheet in Input.workSheets)
            {
                SheetConCmb.Items.Add(Sheet);
            }
        }
        private void FillExpSheetCmbBox(InputModel Input)
        {
            Input.workSheets = ExcelQueries.GetSheets(Input);
            SheetExpCmb.Items.Clear();
            foreach (string Sheet in Input.workSheets)
            {
                SheetExpCmb.Items.Add(Sheet);
            }
        }
    }
}
