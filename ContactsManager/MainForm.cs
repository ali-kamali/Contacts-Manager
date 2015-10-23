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
    }
}
