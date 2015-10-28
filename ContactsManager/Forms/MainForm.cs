using System;
using System.Windows.Forms;
using ContactsManager.Models;
using ContactsManager.Utility;

namespace ContactsManager.Forms
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

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            var form = new Settings();
            this.Hide();
            form.ShowDialog();
            this.Show();
            this.Focus();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            if (MyConfigs.IsAppPassActive)
            {
                var conf = DynamicConfigs.GetConfigs();
                var form = new Login(conf);
                this.Hide();
                if (form.ShowDialog() != DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
        }
    }
}