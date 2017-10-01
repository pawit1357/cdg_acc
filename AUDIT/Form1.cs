using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace AUDIT
{
    public partial class Form1 : Form
    {
        private List<AuditData> auditDatas = new List<AuditData>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtSelectedFile.Text = openFileDialog1.FileName;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadData loadData = new LoadData();
            auditDatas = loadData.Analyze(txtSelectedFile.Text);

            //dataGridView1.DataSource = auditDatas.Where(x => !String.IsNullOrEmpty(x.remark)).ToList();
            Cursor = Cursors.Default;

            ReportDataSource datasource = new ReportDataSource("DataSet1", auditDatas.Where(x => !String.IsNullOrEmpty(x.remark)).ToList());
            this.reportViewer1.LocalReport.ReportPath = "report1.rdlc";

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();

            //byte[] byteViewerExcel = this.reportViewer1.LocalReport.Render("Excel");

            //this.reportViewer1.LocalReport.ListRenderingExtensions();

            //FileStream newFile = new FileStream(Path.GetFileNameWithoutExtension(txtSelectedFile.Text)+"_"+DateTime.Now.ToString("yyyyMMdd"), FileMode.Create);
            //newFile.Write(byteViewerExcel, 0, byteViewerExcel.Length);
            //newFile.Close();

            Console.WriteLine();

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 1)
            {
                e.CellStyle.BackColor = Color.Lavender;
            }

            //if (auditDatas.Count > 0)
            //{
            //    if (!String.IsNullOrEmpty(auditDatas[e.RowIndex].remark))
            //    {
            //        if (auditDatas[e.RowIndex].remark.Equals("-"))
            //        {
            //            e.CellStyle.ForeColor = Color.Red;
            //        }
            //    }
            //}
            Console.WriteLine();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadData loadData = new LoadData();
            List<AuditData2>  xxx = loadData.AnaylyzePivot(txtSelectedFile.Text);
            //dataGridView1.DataSource = xxx.OrderBy(x=>x.amout_abs).ToList();
            ReportDataSource datasource = new ReportDataSource("DataSet1", xxx);
            this.reportViewer1.LocalReport.ReportPath = "report2.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
            Cursor = Cursors.Default;
        }
    }
}
