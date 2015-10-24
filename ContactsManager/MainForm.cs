using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ContactsManager.Forms;

namespace ContactsManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var form = new AddContact();
            this.Hide();
            form.ShowDialog();
            this.Show();
            this.Focus();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var form = new SearchContacts();
            this.Hide();
            form.ShowDialog();
            this.Show();
            this.Focus();
        }

        private void btn_groups_Click(object sender, EventArgs e)
        {
            var form = new GroupsMng();
            this.Hide();
            form.ShowDialog();
            this.Show();
            this.Focus();

        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            var form = new Import();
            this.Hide();
            form.ShowDialog();
            this.Show();
            this.Focus();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {

        }
        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیااز این کار مطمعن هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ContactsEntities db = new ContactsEntities();
                db.Database.ExecuteSqlCommand("delete from ContactAddress;");
                db.Database.ExecuteSqlCommand("delete from sqlite_sequence where name='ContactAddress';");
                db.Database.ExecuteSqlCommand("delete from ContactEmail;    ");
                db.Database.ExecuteSqlCommand("delete from sqlite_sequence where name='ContactEmail';");
                db.Database.ExecuteSqlCommand("delete from ContactGroup;    ");
                db.Database.ExecuteSqlCommand("delete from sqlite_sequence where name='ContactGroup';");
                db.Database.ExecuteSqlCommand("delete from ContactPerson;    ");
                db.Database.ExecuteSqlCommand("delete from sqlite_sequence where name='ContactPerson';");
                db.Database.ExecuteSqlCommand("delete from ContactPhone;    ");
                db.Database.ExecuteSqlCommand("delete from sqlite_sequence where name='ContactPhone';");
                MessageBox.Show("پاک سازی با موفقیت انجام شد");
            }
        }
    }
}
