namespace ExcelSheetDifCheck
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FilePathLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RangeHighTxt = new System.Windows.Forms.TextBox();
            this.RangeLowTxt = new System.Windows.Forms.TextBox();
            this.DisplayBtn = new System.Windows.Forms.Button();
            this.SelectFileBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DisplayDgv = new System.Windows.Forms.DataGridView();
            this.SheetConCmb = new System.Windows.Forms.ComboBox();
            this.SheetExpCmb = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SheetExpCmb);
            this.tabPage1.Controls.Add(this.SheetConCmb);
            this.tabPage1.Controls.Add(this.FilePathLbl);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.RangeHighTxt);
            this.tabPage1.Controls.Add(this.RangeLowTxt);
            this.tabPage1.Controls.Add(this.DisplayBtn);
            this.tabPage1.Controls.Add(this.SelectFileBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FilePathLbl
            // 
            this.FilePathLbl.AutoSize = true;
            this.FilePathLbl.Location = new System.Drawing.Point(17, 78);
            this.FilePathLbl.Name = "FilePathLbl";
            this.FilePathLbl.Size = new System.Drawing.Size(71, 13);
            this.FilePathLbl.TabIndex = 23;
            this.FilePathLbl.Text = "File path here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Sheet Exp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sheet Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cell Range Bottom Right";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cell Range Top Left";
            // 
            // RangeHighTxt
            // 
            this.RangeHighTxt.Location = new System.Drawing.Point(158, 175);
            this.RangeHighTxt.Name = "RangeHighTxt";
            this.RangeHighTxt.Size = new System.Drawing.Size(100, 20);
            this.RangeHighTxt.TabIndex = 16;
            // 
            // RangeLowTxt
            // 
            this.RangeLowTxt.Location = new System.Drawing.Point(158, 136);
            this.RangeLowTxt.Name = "RangeLowTxt";
            this.RangeLowTxt.Size = new System.Drawing.Size(100, 20);
            this.RangeLowTxt.TabIndex = 15;
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.Location = new System.Drawing.Point(141, 293);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(117, 28);
            this.DisplayBtn.TabIndex = 14;
            this.DisplayBtn.Text = "Display";
            this.DisplayBtn.UseVisualStyleBackColor = true;
            this.DisplayBtn.Click += new System.EventHandler(this.DisplayBtn_Click);
            // 
            // SelectFileBtn
            // 
            this.SelectFileBtn.Location = new System.Drawing.Point(20, 16);
            this.SelectFileBtn.Name = "SelectFileBtn";
            this.SelectFileBtn.Size = new System.Drawing.Size(145, 43);
            this.SelectFileBtn.TabIndex = 13;
            this.SelectFileBtn.Text = "Select Excel file";
            this.SelectFileBtn.UseVisualStyleBackColor = true;
            this.SelectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DisplayDgv);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DisplayDgv
            // 
            this.DisplayDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayDgv.Location = new System.Drawing.Point(3, 3);
            this.DisplayDgv.Name = "DisplayDgv";
            this.DisplayDgv.Size = new System.Drawing.Size(786, 418);
            this.DisplayDgv.TabIndex = 0;
            // 
            // SheetConCmb
            // 
            this.SheetConCmb.FormattingEnabled = true;
            this.SheetConCmb.Location = new System.Drawing.Point(158, 213);
            this.SheetConCmb.Name = "SheetConCmb";
            this.SheetConCmb.Size = new System.Drawing.Size(121, 21);
            this.SheetConCmb.TabIndex = 24;
            // 
            // SheetExpCmb
            // 
            this.SheetExpCmb.FormattingEnabled = true;
            this.SheetExpCmb.Location = new System.Drawing.Point(158, 244);
            this.SheetExpCmb.Name = "SheetExpCmb";
            this.SheetExpCmb.Size = new System.Drawing.Size(121, 21);
            this.SheetExpCmb.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label FilePathLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RangeHighTxt;
        private System.Windows.Forms.TextBox RangeLowTxt;
        private System.Windows.Forms.Button DisplayBtn;
        private System.Windows.Forms.Button SelectFileBtn;
        private System.Windows.Forms.DataGridView DisplayDgv;
        private System.Windows.Forms.ComboBox SheetExpCmb;
        private System.Windows.Forms.ComboBox SheetConCmb;
    }
}

