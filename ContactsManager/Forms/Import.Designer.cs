namespace ContactsManager.Forms
{
    partial class Import
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import));
            this.btn_selectfile = new System.Windows.Forms.Button();
            this.dataGV_group = new System.Windows.Forms.DataGridView();
            this.excellname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataname = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btn_import = new System.Windows.Forms.Button();
            this.clb_Groups = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.L_per = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_cnt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_allcnt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_selectfile
            // 
            this.btn_selectfile.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.btn_selectfile.Location = new System.Drawing.Point(405, 12);
            this.btn_selectfile.Name = "btn_selectfile";
            this.btn_selectfile.Size = new System.Drawing.Size(120, 42);
            this.btn_selectfile.TabIndex = 26;
            this.btn_selectfile.Text = "انتخاب فایل";
            this.btn_selectfile.UseVisualStyleBackColor = true;
            this.btn_selectfile.Click += new System.EventHandler(this.btn_selectfile_Click);
            // 
            // dataGV_group
            // 
            this.dataGV_group.AllowUserToAddRows = false;
            this.dataGV_group.AllowUserToDeleteRows = false;
            this.dataGV_group.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGV_group.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGV_group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_group.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.excellname,
            this.dataname});
            this.dataGV_group.Location = new System.Drawing.Point(12, 12);
            this.dataGV_group.Name = "dataGV_group";
            this.dataGV_group.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_group.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGV_group.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGV_group.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGV_group.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_group.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_group.Size = new System.Drawing.Size(261, 378);
            this.dataGV_group.TabIndex = 28;
            // 
            // excellname
            // 
            this.excellname.HeaderText = "نام ستون";
            this.excellname.Name = "excellname";
            this.excellname.Width = 74;
            // 
            // dataname
            // 
            this.dataname.HeaderText = "ستون معادل";
            this.dataname.Name = "dataname";
            this.dataname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataname.Width = 88;
            // 
            // btn_import
            // 
            this.btn_import.Enabled = false;
            this.btn_import.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.btn_import.Location = new System.Drawing.Point(279, 12);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(120, 42);
            this.btn_import.TabIndex = 29;
            this.btn_import.Text = "درون ریزی";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // clb_Groups
            // 
            this.clb_Groups.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.clb_Groups.FormattingEnabled = true;
            this.clb_Groups.Location = new System.Drawing.Point(279, 60);
            this.clb_Groups.Name = "clb_Groups";
            this.clb_Groups.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clb_Groups.Size = new System.Drawing.Size(246, 160);
            this.clb_Groups.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContactsManager.Properties.Resources._1445637413_upload;
            this.pictureBox1.Location = new System.Drawing.Point(279, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // L_per
            // 
            this.L_per.AutoSize = true;
            this.L_per.BackColor = System.Drawing.Color.Transparent;
            this.L_per.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.L_per.Location = new System.Drawing.Point(279, 238);
            this.L_per.Name = "L_per";
            this.L_per.Size = new System.Drawing.Size(29, 28);
            this.L_per.TabIndex = 32;
            this.L_per.Text = "%0";
            this.L_per.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(486, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 28);
            this.label2.TabIndex = 34;
            this.label2.Text = "تعداد";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_cnt
            // 
            this.L_cnt.AutoSize = true;
            this.L_cnt.BackColor = System.Drawing.Color.Transparent;
            this.L_cnt.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.L_cnt.Location = new System.Drawing.Point(434, 238);
            this.L_cnt.Name = "L_cnt";
            this.L_cnt.Size = new System.Drawing.Size(57, 28);
            this.L_cnt.TabIndex = 34;
            this.L_cnt.Text = "00000";
            this.L_cnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(415, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 28);
            this.label4.TabIndex = 35;
            this.label4.Text = "از";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_allcnt
            // 
            this.l_allcnt.AutoSize = true;
            this.l_allcnt.BackColor = System.Drawing.Color.Transparent;
            this.l_allcnt.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.l_allcnt.Location = new System.Drawing.Point(365, 238);
            this.l_allcnt.Name = "l_allcnt";
            this.l_allcnt.Size = new System.Drawing.Size(48, 28);
            this.l_allcnt.TabIndex = 36;
            this.l_allcnt.Text = "0000";
            this.l_allcnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 404);
            this.Controls.Add(this.l_allcnt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.L_cnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.L_per);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clb_Groups);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.dataGV_group);
            this.Controls.Add(this.btn_selectfile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Import";
            this.Text = "برون ریزی";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Import_FormClosing);
            this.Load += new System.EventHandler(this.Import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_selectfile;
        private System.Windows.Forms.DataGridView dataGV_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn excellname;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataname;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.CheckedListBox clb_Groups;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label L_per;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_cnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_allcnt;
    }
}