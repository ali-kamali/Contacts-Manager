using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ContactsManager.Models;

namespace ContactsManager.Forms
{
    public partial class Login : Form
    {
        private DynamicConfigs conf;
        public Login(DynamicConfigs conf1)
        {
            this.conf = conf1;
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_pass.Text == conf.Password)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("رمز عبور وارد شده صحیح نمی باشد");
            }
        }
    }
}
