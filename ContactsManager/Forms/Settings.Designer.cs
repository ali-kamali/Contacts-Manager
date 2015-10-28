namespace ContactsManager.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.btn_ChangePass = new System.Windows.Forms.Button();
            this.tb_newpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_newpass2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panelAddress = new System.Windows.Forms.Panel();
            this.btn_lockdb = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelCall = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ClearAll = new System.Windows.Forms.Button();
            this.tabPage4.SuspendLayout();
            this.panelAddress.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelEmail.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelCall.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ChangePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChangePass.Location = new System.Drawing.Point(5, 101);
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.Size = new System.Drawing.Size(213, 39);
            this.btn_ChangePass.TabIndex = 22;
            this.btn_ChangePass.Text = "تغییر رمز عبور";
            this.btn_ChangePass.UseVisualStyleBackColor = true;
            this.btn_ChangePass.Click += new System.EventHandler(this.btn_ChangePass_Click);
            // 
            // tb_newpass
            // 
            this.tb_newpass.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb_newpass.Location = new System.Drawing.Point(5, 15);
            this.tb_newpass.Name = "tb_newpass";
            this.tb_newpass.Size = new System.Drawing.Size(148, 31);
            this.tb_newpass.TabIndex = 21;
            this.tb_newpass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(159, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "رمز عبور جدید";
            // 
            // tb_newpass2
            // 
            this.tb_newpass2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tb_newpass2.Location = new System.Drawing.Point(5, 61);
            this.tb_newpass2.Name = "tb_newpass2";
            this.tb_newpass2.Size = new System.Drawing.Size(148, 31);
            this.tb_newpass2.TabIndex = 24;
            this.tb_newpass2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(159, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "تکرار رمز عبور";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panelAddress);
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(368, 158);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "رمزنگاری پایگاه داده";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panelAddress
            // 
            this.panelAddress.AutoScroll = true;
            this.panelAddress.BackgroundImage = global::ContactsManager.Properties.Resources._1446062121_data_encryption;
            this.panelAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelAddress.Controls.Add(this.btn_lockdb);
            this.panelAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddress.Location = new System.Drawing.Point(0, 0);
            this.panelAddress.Name = "panelAddress";
            this.panelAddress.Size = new System.Drawing.Size(368, 158);
            this.panelAddress.TabIndex = 15;
            // 
            // btn_lockdb
            // 
            this.btn_lockdb.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.btn_lockdb.Location = new System.Drawing.Point(79, 46);
            this.btn_lockdb.Name = "btn_lockdb";
            this.btn_lockdb.Size = new System.Drawing.Size(150, 53);
            this.btn_lockdb.TabIndex = 8;
            this.btn_lockdb.Text = "قفل کردن پایگاه داده";
            this.btn_lockdb.UseVisualStyleBackColor = true;
            this.btn_lockdb.Click += new System.EventHandler(this.btn_lockdb_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panelEmail);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(368, 158);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "بروز رسانی";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelEmail
            // 
            this.panelEmail.AutoScroll = true;
            this.panelEmail.BackgroundImage = global::ContactsManager.Properties.Resources._1446062481_synchronize;
            this.panelEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelEmail.Controls.Add(this.btn_update);
            this.panelEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEmail.Location = new System.Drawing.Point(3, 3);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(362, 152);
            this.panelEmail.TabIndex = 14;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.btn_update.Location = new System.Drawing.Point(79, 46);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(150, 53);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "بروز رسانی نرم افزار";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelCall);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(368, 158);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "تغییر رمز عبور";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelCall
            // 
            this.panelCall.AutoScroll = true;
            this.panelCall.BackgroundImage = global::ContactsManager.Properties.Resources._1446057368_lock;
            this.panelCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelCall.Controls.Add(this.label4);
            this.panelCall.Controls.Add(this.tb_newpass2);
            this.panelCall.Controls.Add(this.tb_newpass);
            this.panelCall.Controls.Add(this.label1);
            this.panelCall.Controls.Add(this.btn_ChangePass);
            this.panelCall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCall.Location = new System.Drawing.Point(3, 3);
            this.panelCall.Name = "panelCall";
            this.panelCall.Size = new System.Drawing.Size(362, 152);
            this.panelCall.TabIndex = 13;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl2.RightToLeftLayout = true;
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(376, 195);
            this.tabControl2.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(368, 158);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "پاک سازی داده ها";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = global::ContactsManager.Properties.Resources._1446062099_delete_database;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btn_ClearAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 152);
            this.panel1.TabIndex = 16;
            // 
            // btn_ClearAll
            // 
            this.btn_ClearAll.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.btn_ClearAll.Location = new System.Drawing.Point(79, 46);
            this.btn_ClearAll.Name = "btn_ClearAll";
            this.btn_ClearAll.Size = new System.Drawing.Size(150, 53);
            this.btn_ClearAll.TabIndex = 7;
            this.btn_ClearAll.Text = "پاک کردن داده ها";
            this.btn_ClearAll.UseVisualStyleBackColor = true;
            this.btn_ClearAll.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ContactsManager.Properties.Resources._1446059487_engineering;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(376, 195);
            this.Controls.Add(this.tabControl2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "تنظیمات";
            this.tabPage4.ResumeLayout(false);
            this.panelAddress.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panelEmail.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelCall.ResumeLayout(false);
            this.panelCall.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ChangePass;
        private System.Windows.Forms.TextBox tb_newpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_newpass2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panelAddress;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelCall;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Button btn_lockdb;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ClearAll;
        private System.Windows.Forms.Button btn_update;
    }
}