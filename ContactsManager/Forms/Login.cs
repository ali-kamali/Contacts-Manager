using System;
using System.Windows.Forms;
using ContactsManager.Models;

namespace ContactsManager.Forms
{
    public partial class Login : Form
    {
        private readonly DynamicConfigs _conf;

        public Login(DynamicConfigs conf1)
        {
            _conf = conf1;
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_pass.Text == _conf.Password)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(@"رمز عبور وارد شده صحیح نمی باشد");
            }
        }
    }
}