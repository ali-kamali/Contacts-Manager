namespace ContactsManager.Forms
{
    partial class GroupsMng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupsMng));
            this.btn_addGroup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_groupName = new System.Windows.Forms.TextBox();
            this.btn_removeGroup = new System.Windows.Forms.Button();
            this.dataGV_group = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addGroup
            // 
            this.btn_addGroup.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.btn_addGroup.Location = new System.Drawing.Point(204, 43);
            this.btn_addGroup.Name = "btn_addGroup";
            this.btn_addGroup.Size = new System.Drawing.Size(142, 42);
            this.btn_addGroup.TabIndex = 25;
            this.btn_addGroup.Text = "افزودن به لیست گروه ها";
            this.btn_addGroup.UseVisualStyleBackColor = true;
            this.btn_addGroup.Click += new System.EventHandler(this.btn_addGroup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(353, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "نام گروه";
            // 
            // tb_groupName
            // 
            this.tb_groupName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb_groupName.Location = new System.Drawing.Point(204, 11);
            this.tb_groupName.Name = "tb_groupName";
            this.tb_groupName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_groupName.Size = new System.Drawing.Size(142, 31);
            this.tb_groupName.TabIndex = 23;
            // 
            // btn_removeGroup
            // 
            this.btn_removeGroup.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.btn_removeGroup.Location = new System.Drawing.Point(204, 91);
            this.btn_removeGroup.Name = "btn_removeGroup";
            this.btn_removeGroup.Size = new System.Drawing.Size(142, 42);
            this.btn_removeGroup.TabIndex = 26;
            this.btn_removeGroup.Text = "حذف انتخاب شده ها";
            this.btn_removeGroup.UseVisualStyleBackColor = true;
            this.btn_removeGroup.Click += new System.EventHandler(this.btn_removeGroup_Click);
            // 
            // dataGV_group
            // 
            this.dataGV_group.AllowUserToAddRows = false;
            this.dataGV_group.AllowUserToDeleteRows = false;
            this.dataGV_group.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGV_group.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGV_group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_group.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dataGV_group.Location = new System.Drawing.Point(12, 12);
            this.dataGV_group.Name = "dataGV_group";
            this.dataGV_group.ReadOnly = true;
            this.dataGV_group.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_group.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGV_group.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGV_group.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGV_group.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_group.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_group.Size = new System.Drawing.Size(186, 269);
            this.dataGV_group.TabIndex = 27;
            // 
            // id
            // 
            this.id.HeaderText = "کد";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 44;
            // 
            // name
            // 
            this.name.HeaderText = "نام گروه";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 72;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.btn_close.Location = new System.Drawing.Point(204, 139);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(142, 42);
            this.btn_close.TabIndex = 28;
            this.btn_close.Text = "اتمام";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContactsManager.Properties.Resources._1445637555_conference_call;
            this.pictureBox1.Location = new System.Drawing.Point(204, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // GroupsMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 294);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dataGV_group);
            this.Controls.Add(this.btn_removeGroup);
            this.Controls.Add(this.btn_addGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_groupName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GroupsMng";
            this.Text = "GroupsMng";
            this.Load += new System.EventHandler(this.GroupsMng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_groupName;
        private System.Windows.Forms.Button btn_removeGroup;
        private System.Windows.Forms.DataGridView dataGV_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}