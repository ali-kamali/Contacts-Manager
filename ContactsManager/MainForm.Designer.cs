namespace ContactsManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_groups = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_ClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.btn_add.Location = new System.Drawing.Point(169, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(150, 53);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "افزودن مخاطب";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.btn_search.Location = new System.Drawing.Point(169, 71);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(150, 53);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "جست و جو";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_groups
            // 
            this.btn_groups.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.btn_groups.Location = new System.Drawing.Point(13, 12);
            this.btn_groups.Name = "btn_groups";
            this.btn_groups.Size = new System.Drawing.Size(150, 53);
            this.btn_groups.TabIndex = 3;
            this.btn_groups.Text = "گروه ها";
            this.btn_groups.UseVisualStyleBackColor = true;
            this.btn_groups.Click += new System.EventHandler(this.btn_groups_Click);
            // 
            // btn_import
            // 
            this.btn_import.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.btn_import.Location = new System.Drawing.Point(169, 130);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(150, 53);
            this.btn_import.TabIndex = 4;
            this.btn_import.Text = "درون ریزی";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.btn_export.Location = new System.Drawing.Point(13, 130);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(150, 53);
            this.btn_export.TabIndex = 5;
            this.btn_export.Text = "برون ریزی";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_ClearAll
            // 
            this.btn_ClearAll.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.btn_ClearAll.Location = new System.Drawing.Point(13, 71);
            this.btn_ClearAll.Name = "btn_ClearAll";
            this.btn_ClearAll.Size = new System.Drawing.Size(150, 53);
            this.btn_ClearAll.TabIndex = 6;
            this.btn_ClearAll.Text = "پاک کردن داده ها";
            this.btn_ClearAll.UseVisualStyleBackColor = true;
            this.btn_ClearAll.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 197);
            this.Controls.Add(this.btn_ClearAll);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.btn_groups);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "مدیریت مخاطبین";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_groups;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_ClearAll;
    }
}

