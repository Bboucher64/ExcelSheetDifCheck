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
        }


        private void RunCheckBtn_Click(object sender, EventArgs e)
        {
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            Input.SheetCon = SheetConTxt.Text;
            DisplayDgv.DataSource=ExcelQueries.CallExcel(Input);
        }
    }
}
