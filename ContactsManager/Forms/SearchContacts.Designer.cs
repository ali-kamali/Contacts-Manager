﻿namespace ContactsManager.Forms
{
    partial class SearchContacts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchContacts));
            this.label3 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.clb_Groups = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_call = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.dataGV_person = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_postname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cb_Page = new System.Windows.Forms.ComboBox();
            this.btn_export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_person)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(421, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "آدرس";
            // 
            // tb_address
            // 
            this.tb_address.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb_address.Location = new System.Drawing.Point(217, 55);
            this.tb_address.Name = "tb_address";
            this.tb_address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_address.Size = new System.Drawing.Size(200, 31);
            this.tb_address.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(421, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "نام خانوادگی";
            // 
            // tb_LastName
            // 
            this.tb_LastName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb_LastName.Location = new System.Drawing.Point(217, 10);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_LastName.Size = new System.Drawing.Size(200, 31);
            this.tb_LastName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(718, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "نام";
            // 
            // tb_firstname
            // 
            this.tb_firstname.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb_firstname.Location = new System.Drawing.Point(512, 10);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_firstname.Size = new System.Drawing.Size(200, 31);
            this.tb_firstname.TabIndex = 1;
            // 
            // clb_Groups
            // 
            this.clb_Groups.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.clb_Groups.FormattingEnabled = true;
            this.clb_Groups.Location = new System.Drawing.Point(9, 10);
            this.clb_Groups.Name = "clb_Groups";
            this.clb_Groups.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clb_Groups.Size = new System.Drawing.Size(202, 108);
            this.clb_Groups.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(718, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "شماره تماس";
            // 
            // tb_call
            // 
            this.tb_call.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb_call.Location = new System.Drawing.Point(512, 55);
            this.tb_call.Name = "tb_call";
            this.tb_call.Size = new System.Drawing.Size(200, 31);
            this.tb_call.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(718, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "رایانامه";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb_email.Location = new System.Drawing.Point(512, 95);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(200, 31);
            this.tb_email.TabIndex = 5;
            // 
            // dataGV_person
            // 
            this.dataGV_person.AllowUserToAddRows = false;
            this.dataGV_person.AllowUserToDeleteRows = false;
            this.dataGV_person.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGV_person.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGV_person.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_person.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FirstName,
            this.LastName,
            this.postname,
            this.PhoneNumber,
            this.Email,
            this.Address,
            this.Group});
            this.dataGV_person.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV_person.Location = new System.Drawing.Point(0, 0);
            this.dataGV_person.Name = "dataGV_person";
            this.dataGV_person.ReadOnly = true;
            this.dataGV_person.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_person.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGV_person.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGV_person.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGV_person.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_person.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_person.Size = new System.Drawing.Size(807, 336);
            this.dataGV_person.TabIndex = 21;
            this.dataGV_person.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGV_person_MouseDoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.HeaderText = "کد";
            this.id.MinimumWidth = 20;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 44;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FirstName.HeaderText = "نام";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 45;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LastName.HeaderText = "نام خانوادگی";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 94;
            // 
            // postname
            // 
            this.postname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.postname.HeaderText = "سمت";
            this.postname.Name = "postname";
            this.postname.ReadOnly = true;
            this.postname.Width = 54;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PhoneNumber.DefaultCellStyle = dataGridViewCellStyle1;
            this.PhoneNumber.HeaderText = "تلفن تماس";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Email.HeaderText = "رایانامه";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 66;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.HeaderText = "آدرس";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Group.HeaderText = "گروه";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.Width = 56;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.btn_Search.Location = new System.Drawing.Point(217, 127);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(200, 42);
            this.btn_Search.TabIndex = 22;
            this.btn_Search.Text = "جست و جو";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(718, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "سمت";
            // 
            // tb_postname
            // 
            this.tb_postname.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb_postname.Location = new System.Drawing.Point(512, 139);
            this.tb_postname.Name = "tb_postname";
            this.tb_postname.Size = new System.Drawing.Size(200, 31);
            this.tb_postname.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(421, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 28);
            this.label7.TabIndex = 26;
            this.label7.Text = "نمایش صفحه";
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
            this.splitContainer1.Panel1.BackgroundImage = global::ContactsManager.Properties.Resources._1445637792_fine_print;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel1.Controls.Add(this.btn_export);
            this.splitContainer1.Panel1.Controls.Add(this.cb_Page);
            this.splitContainer1.Panel1.Controls.Add(this.clb_Groups);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.tb_firstname);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tb_postname);
            this.splitContainer1.Panel1.Controls.Add(this.tb_LastName);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Search);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.tb_address);
            this.splitContainer1.Panel1.Controls.Add(this.tb_email);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.tb_call);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGV_person);
            this.splitContainer1.Size = new System.Drawing.Size(807, 522);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.TabIndex = 28;
            // 
            // cb_Page
            // 
            this.cb_Page.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.cb_Page.FormattingEnabled = true;
            this.cb_Page.Location = new System.Drawing.Point(330, 91);
            this.cb_Page.Name = "cb_Page";
            this.cb_Page.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_Page.Size = new System.Drawing.Size(87, 32);
            this.cb_Page.TabIndex = 27;
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.btn_export.Location = new System.Drawing.Point(12, 127);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(200, 42);
            this.btn_export.TabIndex = 28;
            this.btn_export.Text = "برون ریزی";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // SearchContacts
            // 
            this.AcceptButton = this.btn_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ContactsManager.Properties.Resources._1445637792_fine_print;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(807, 522);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchContacts";
            this.Text = "جست و جو مخاطبین";
            this.Load += new System.EventHandler(this.SearchContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_person)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.CheckedListBox clb_Groups;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_call;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.DataGridView dataGV_person;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_postname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cb_Page;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn postname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.Button btn_export;
    }
}