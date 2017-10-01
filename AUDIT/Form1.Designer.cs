namespace AUDIT
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtSelectedFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnProcess = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.auditData2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.col1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col11DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col14DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col15DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col16DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col17DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col19DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col20DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditData2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.auditDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditData2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditData2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(258, 38);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(64, 23);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "เลือกไฟล์";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtSelectedFile
            // 
            this.txtSelectedFile.Location = new System.Drawing.Point(20, 40);
            this.txtSelectedFile.Name = "txtSelectedFile";
            this.txtSelectedFile.ReadOnly = true;
            this.txtSelectedFile.Size = new System.Drawing.Size(232, 20);
            this.txtSelectedFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ตำแหน่งไฟล์";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(345, 28);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(92, 42);
            this.btnProcess.TabIndex = 3;
            this.btnProcess.Text = "ประมวลผล";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 78);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(95, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "ระบบตรวจสอบความผิดปกติของบัญชี";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AUDIT.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(1, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 84);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSelectFile);
            this.groupBox1.Controls.Add(this.txtSelectedFile);
            this.groupBox1.Controls.Add(this.btnProcess);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "ประมวลผล (PiVot)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(901, 620);
            this.splitContainer1.SplitterDistance = 78;
            this.splitContainer1.TabIndex = 7;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(901, 538);
            this.splitContainer2.SplitterDistance = 78;
            this.splitContainer2.TabIndex = 8;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoScroll = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.auditDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AUDIT.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(901, 456);
            this.reportViewer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1DataGridViewTextBoxColumn,
            this.col2DataGridViewTextBoxColumn,
            this.col3DataGridViewTextBoxColumn,
            this.col4DataGridViewTextBoxColumn,
            this.col5DataGridViewTextBoxColumn,
            this.col6DataGridViewTextBoxColumn,
            this.col7DataGridViewTextBoxColumn,
            this.col8DataGridViewTextBoxColumn,
            this.col9DataGridViewTextBoxColumn,
            this.col10DataGridViewTextBoxColumn,
            this.col11DataGridViewTextBoxColumn,
            this.col12DataGridViewTextBoxColumn,
            this.col13DataGridViewTextBoxColumn,
            this.col14DataGridViewTextBoxColumn,
            this.col15DataGridViewTextBoxColumn,
            this.col16DataGridViewTextBoxColumn,
            this.col17DataGridViewTextBoxColumn,
            this.col19DataGridViewTextBoxColumn,
            this.col20DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.auditData2BindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(901, 456);
            this.dataGridView1.TabIndex = 0;
            // 
            // auditData2BindingSource
            // 
            this.auditData2BindingSource.DataSource = typeof(AUDIT.AuditData2);
            // 
            // col1DataGridViewTextBoxColumn
            // 
            this.col1DataGridViewTextBoxColumn.DataPropertyName = "col1";
            this.col1DataGridViewTextBoxColumn.HeaderText = "col1";
            this.col1DataGridViewTextBoxColumn.Name = "col1DataGridViewTextBoxColumn";
            // 
            // col2DataGridViewTextBoxColumn
            // 
            this.col2DataGridViewTextBoxColumn.DataPropertyName = "col2";
            this.col2DataGridViewTextBoxColumn.HeaderText = "col2";
            this.col2DataGridViewTextBoxColumn.Name = "col2DataGridViewTextBoxColumn";
            // 
            // col3DataGridViewTextBoxColumn
            // 
            this.col3DataGridViewTextBoxColumn.DataPropertyName = "col3";
            this.col3DataGridViewTextBoxColumn.HeaderText = "col3";
            this.col3DataGridViewTextBoxColumn.Name = "col3DataGridViewTextBoxColumn";
            // 
            // col4DataGridViewTextBoxColumn
            // 
            this.col4DataGridViewTextBoxColumn.DataPropertyName = "col4";
            this.col4DataGridViewTextBoxColumn.HeaderText = "col4";
            this.col4DataGridViewTextBoxColumn.Name = "col4DataGridViewTextBoxColumn";
            // 
            // col5DataGridViewTextBoxColumn
            // 
            this.col5DataGridViewTextBoxColumn.DataPropertyName = "col5";
            this.col5DataGridViewTextBoxColumn.HeaderText = "col5";
            this.col5DataGridViewTextBoxColumn.Name = "col5DataGridViewTextBoxColumn";
            // 
            // col6DataGridViewTextBoxColumn
            // 
            this.col6DataGridViewTextBoxColumn.DataPropertyName = "col6";
            this.col6DataGridViewTextBoxColumn.HeaderText = "col6";
            this.col6DataGridViewTextBoxColumn.Name = "col6DataGridViewTextBoxColumn";
            // 
            // col7DataGridViewTextBoxColumn
            // 
            this.col7DataGridViewTextBoxColumn.DataPropertyName = "col7";
            this.col7DataGridViewTextBoxColumn.HeaderText = "col7";
            this.col7DataGridViewTextBoxColumn.Name = "col7DataGridViewTextBoxColumn";
            // 
            // col8DataGridViewTextBoxColumn
            // 
            this.col8DataGridViewTextBoxColumn.DataPropertyName = "col8";
            this.col8DataGridViewTextBoxColumn.HeaderText = "col8";
            this.col8DataGridViewTextBoxColumn.Name = "col8DataGridViewTextBoxColumn";
            // 
            // col9DataGridViewTextBoxColumn
            // 
            this.col9DataGridViewTextBoxColumn.DataPropertyName = "col9";
            this.col9DataGridViewTextBoxColumn.HeaderText = "col9";
            this.col9DataGridViewTextBoxColumn.Name = "col9DataGridViewTextBoxColumn";
            // 
            // col10DataGridViewTextBoxColumn
            // 
            this.col10DataGridViewTextBoxColumn.DataPropertyName = "col10";
            this.col10DataGridViewTextBoxColumn.HeaderText = "col10";
            this.col10DataGridViewTextBoxColumn.Name = "col10DataGridViewTextBoxColumn";
            // 
            // col11DataGridViewTextBoxColumn
            // 
            this.col11DataGridViewTextBoxColumn.DataPropertyName = "col11";
            this.col11DataGridViewTextBoxColumn.HeaderText = "col11";
            this.col11DataGridViewTextBoxColumn.Name = "col11DataGridViewTextBoxColumn";
            // 
            // col12DataGridViewTextBoxColumn
            // 
            this.col12DataGridViewTextBoxColumn.DataPropertyName = "col12";
            this.col12DataGridViewTextBoxColumn.HeaderText = "col12";
            this.col12DataGridViewTextBoxColumn.Name = "col12DataGridViewTextBoxColumn";
            // 
            // col13DataGridViewTextBoxColumn
            // 
            this.col13DataGridViewTextBoxColumn.DataPropertyName = "col13";
            this.col13DataGridViewTextBoxColumn.HeaderText = "col13";
            this.col13DataGridViewTextBoxColumn.Name = "col13DataGridViewTextBoxColumn";
            // 
            // col14DataGridViewTextBoxColumn
            // 
            this.col14DataGridViewTextBoxColumn.DataPropertyName = "col14";
            this.col14DataGridViewTextBoxColumn.HeaderText = "col14";
            this.col14DataGridViewTextBoxColumn.Name = "col14DataGridViewTextBoxColumn";
            // 
            // col15DataGridViewTextBoxColumn
            // 
            this.col15DataGridViewTextBoxColumn.DataPropertyName = "col15";
            this.col15DataGridViewTextBoxColumn.HeaderText = "col15";
            this.col15DataGridViewTextBoxColumn.Name = "col15DataGridViewTextBoxColumn";
            // 
            // col16DataGridViewTextBoxColumn
            // 
            this.col16DataGridViewTextBoxColumn.DataPropertyName = "col16";
            this.col16DataGridViewTextBoxColumn.HeaderText = "col16";
            this.col16DataGridViewTextBoxColumn.Name = "col16DataGridViewTextBoxColumn";
            // 
            // col17DataGridViewTextBoxColumn
            // 
            this.col17DataGridViewTextBoxColumn.DataPropertyName = "col17";
            this.col17DataGridViewTextBoxColumn.HeaderText = "col17";
            this.col17DataGridViewTextBoxColumn.Name = "col17DataGridViewTextBoxColumn";
            // 
            // col19DataGridViewTextBoxColumn
            // 
            this.col19DataGridViewTextBoxColumn.DataPropertyName = "col19";
            this.col19DataGridViewTextBoxColumn.HeaderText = "col19";
            this.col19DataGridViewTextBoxColumn.Name = "col19DataGridViewTextBoxColumn";
            // 
            // col20DataGridViewTextBoxColumn
            // 
            this.col20DataGridViewTextBoxColumn.DataPropertyName = "col20";
            this.col20DataGridViewTextBoxColumn.HeaderText = "col20";
            this.col20DataGridViewTextBoxColumn.Name = "col20DataGridViewTextBoxColumn";
            // 
            // auditData2BindingSource1
            // 
            this.auditData2BindingSource1.DataSource = typeof(AUDIT.AuditData2);
            // 
            // auditDataBindingSource
            // 
            this.auditDataBindingSource.DataSource = typeof(AUDIT.AuditData);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 620);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditData2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditData2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSelectedFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource auditDataBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource auditData2BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amoutabsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource auditData2BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col12DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col14DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col15DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col16DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col17DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col19DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col20DataGridViewTextBoxColumn;
    }
}

