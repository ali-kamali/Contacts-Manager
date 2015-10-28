using System;
using System.Collections.Specialized;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using ContactsManager.Utility;

namespace ContactsManager.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            if (tb_newpass.Text.Length < 5)
            {
                MessageBox.Show("رمز عبور باید حداقل 4 حرف باشد");
            }
            if (tb_newpass.Text != tb_newpass2.Text)
            {
                MessageBox.Show("رمز عبور جدید با تکرار آن مطابقت ندارد");
            }
            else
            {
                ContactsEntities db=new ContactsEntities();
                var pcon = db.Configs.FirstOrDefault(p => p.ConfigKey == "Password");
                if (pcon != null)
                {
                    pcon.ConfigValue = tb_newpass.Text;
                }
                else
                {
                    db.Configs.Add(new Configs
                    {
                        ConfigKey = "Password",
                        ConfigValue = tb_newpass.Text
                    });
                }
                db.SaveChanges();
            }
        }

        private void btn_lockdb_Click(object sender, EventArgs e)
        {
            if (MyConfigs.IsDbPassActive)
            {
                string constr = new SQLiteConnectionStringBuilder()
                {
                    DataSource = @"Contacts.db",
                    ForeignKeys = true,
                    Version = 3
                }
                    .ConnectionString;
                Clipboard.SetText(constr);
                MessageBox.Show(constr);
                SQLiteConnection con = new SQLiteConnection(constr);
                con.Open();
                con.ChangePassword(MyConfigs.DbPassword);
                con.Close();
            }
        }

        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیااز این کار مطمعن هستید؟", "هشدار", MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning) == DialogResult.Yes)
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient web = new WebClient();
                web.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                web.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; rv:41.0) Gecko/20100101 Firefox/41.0");
                var data = web.DownloadString("https://api.github.com/repos/ali-kamali/Contacts-Manager/releases/latest");
                string line = data.Split('\n').FirstOrDefault(p => p.Contains("tag_name"));
                string version = "";
                string downloadlink = "";
                if (line != null)
                {
                    version = line.Replace("\"tag_name\":", "").Replace("\"", "").Replace(" ", "").Replace(",", "");
                    
                }
                line = data.Split('\n').FirstOrDefault(p => p.Contains("browser_download_url"));
                if (line != null)
                {
                    downloadlink = line.Replace("\"browser_download_url\":", "").Replace("\"", "").Replace(" ", "").Replace(",", "");

                }
                if (MyConfigs.AppVersion != version)
                {
                    if (
                        MessageBox.Show("نسخه جدیدی از نرم افزار موجود می باشد آیا مایل به دریافت آن می باشد؟",
                            "بروز رسانی", MessageBoxButtons.YesNo
                            , MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(downloadlink); 
                    }
                }
                else
                {
                    MessageBox.Show("شما از آخرین نسخه این نرم افزار استفاده می نمایید");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("خطایی در ارتباط با سرور پیش آمده است لطفا مجددا تلاش نمایید");
            }
        }
    }
}
