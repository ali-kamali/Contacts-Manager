namespace ContactsManager.Forms
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_person)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(426, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "آدرس";
            // 
            // tb_address
            // 
            this.tb_address.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb_address.Location = new System.Drawing.Point(220, 57);
            this.tb_address.Name = "tb_address";
            this.tb_address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_address.Size = new System.Drawing.Size(200, 31);
            this.tb_address.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(426, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "نام خانوادگی";
            // 
            // tb_LastName
            // 
            this.tb_LastName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb_LastName.Location = new System.Drawing.Point(220, 14);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_LastName.Size = new System.Drawing.Size(200, 31);
            this.tb_LastName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(721, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "نام";
            // 
            // tb_firstname
            // 
            this.tb_firstname.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb_firstname.Location = new System.Drawing.Point(515, 12);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_firstname.Size = new System.Drawing.Size(200, 31);
            this.tb_firstname.TabIndex = 1;
            // 
            // clb_Groups
            // 
            this.clb_Groups.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.clb_Groups.FormattingEnabled = true;
            this.clb_Groups.Location = new System.Drawing.Point(12, 12);
            this.clb_Groups.Name = "clb_Groups";
            this.clb_Groups.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clb_Groups.Size = new System.Drawing.Size(202, 134);
            this.clb_Groups.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(721, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "شماره تماس";
            // 
            // tb_call
            // 
            this.tb_call.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb_call.Location = new System.Drawing.Point(515, 56);
            this.tb_call.Name = "tb_call";
            this.tb_call.Size = new System.Drawing.Size(200, 31);
            this.tb_call.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(721, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "رایانامه";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb_email.Location = new System.Drawing.Point(515, 99);
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
            this.dataGV_person.Location = new System.Drawing.Point(12, 178);
            this.dataGV_person.Name = "dataGV_person";
            this.dataGV_person.ReadOnly = true;
            this.dataGV_person.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_person.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGV_person.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGV_person.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGV_person.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_person.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_person.Size = new System.Drawing.Size(792, 269);
            this.dataGV_person.TabIndex = 21;
            this.dataGV_person.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGV_person_MouseDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "کد";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 44;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "نام";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 45;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "نام خانوادگی";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 94;
            // 
            // postname
            // 
            this.postname.HeaderText = "سمت";
            this.postname.Name = "postname";
            this.postname.ReadOnly = true;
            this.postname.Width = 54;
            // 
            // PhoneNumber
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PhoneNumber.DefaultCellStyle = dataGridViewCellStyle1;
            this.PhoneNumber.HeaderText = "تلفن تماس";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 76;
            // 
            // Email
            // 
            this.Email.HeaderText = "رایانامه";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 66;
            // 
            // Address
            // 
            this.Address.HeaderText = "آدرس";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 55;
            // 
            // Group
            // 
            this.Group.HeaderText = "گروه";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.Width = 56;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.btn_Search.Location = new System.Drawing.Point(220, 99);
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
            this.label4.Location = new System.Drawing.Point(721, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "سمت";
            // 
            // tb_postname
            // 
            this.tb_postname.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb_postname.Location = new System.Drawing.Point(515, 141);
            this.tb_postname.Name = "tb_postname";
            this.tb_postname.Size = new System.Drawing.Size(200, 31);
            this.tb_postname.TabIndex = 23;
            // 
            // SearchContacts
            // 
            this.AcceptButton = this.btn_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ContactsManager.Properties.Resources._1445637792_fine_print;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(807, 459);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_postname);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dataGV_person);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_call);
            this.Controls.Add(this.clb_Groups);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_LastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_firstname);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchContacts";
            this.Text = "SearchContacts";
            this.Load += new System.EventHandler(this.SearchContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_person)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn postname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
    }
}