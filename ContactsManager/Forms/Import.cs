using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OfficeOpenXml;

namespace ContactsManager.Forms
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
        }

        private void btn_selectfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fl = new OpenFileDialog();
            if (fl.ShowDialog() == DialogResult.OK)
            {
                var existingFile = new FileInfo(fl.FileName);
                using (var package = new ExcelPackage(existingFile))
                {
                    ExcelWorkbook workBook = package.Workbook;

                    if (workBook != null)
                    {
                        if (workBook.Worksheets.Count > 0)
                        {
                            ExcelWorksheet currentWorksheet = workBook.Worksheets.First();
                            foreach (var firstRowCell in currentWorksheet.Cells[1, 1, 1, currentWorksheet.Dimension.End.Column])
                            {
                                dataGV_group.Rows.Add(firstRowCell.Text, "");
                            }
                        }

                    }
                }
            }
        }

        private void Import_Load(object sender, EventArgs e)
        {
            var col = (DataGridViewComboBoxColumn) dataGV_group.Columns[1];
            col.Items.Add("نام");
            col.Items.Add("نام خانوادگی");
            col.Items.Add("سمت");
        }
    }
}
