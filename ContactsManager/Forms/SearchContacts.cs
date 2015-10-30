using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ContactsManager.Models;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace ContactsManager.Forms
{
    public partial class SearchContacts : Form
    {
        private List<ContactPerson> _allperson;

        public SearchContacts()
        {
            InitializeComponent();
        }

        private void SearchContacts_Load(object sender, EventArgs e)
        {
            ContactsEntities db = new ContactsEntities();
            var g = db.ContactGroupDef.ToList();
            foreach (ContactGroupDef contactGroupDef in g)
            {
                clb_Groups.Items.Add(contactGroupDef);
            }
            clb_Groups.DisplayMember = "GroupName";
            _allperson = db.ContactPerson.ToList();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            List<long> groups =
                (from object item in clb_Groups.SelectedItems select ((ContactGroupDef)item).Id).ToList();
            var res = _allperson.Where(p =>
                (string.IsNullOrEmpty(tb_firstname.Text) || Convert.ToString(p.FirstName).Contains(tb_firstname.Text)) &&
                (string.IsNullOrEmpty(tb_LastName.Text) || Convert.ToString(p.LastName).Contains(tb_LastName.Text)) &&
                (string.IsNullOrEmpty(tb_postname.Text) || Convert.ToString(p.PostName).Contains(tb_postname.Text)) &&
                (string.IsNullOrEmpty(tb_call.Text) || p.ContactPhone.Any(c => c.PhoneNumber.Contains(tb_call.Text))) &&
                (string.IsNullOrEmpty(tb_email.Text) || p.ContactEmail.Any(c => c.Email.Contains(tb_email.Text))) &&
                (string.IsNullOrEmpty(tb_address.Text) || p.ContactAddress.Any(c => c.Address.Contains(tb_address.Text))) &&
                (!groups.Any() || p.ContactGroup.Any(c => groups.Contains(c.GroupId)))
                ).ToList();
            dataGV_person.Rows.Clear();
            int cnt = res.Count();
            if (cnt / 20 != cb_Page.Items.Count - 1)
            {
                cb_Page.Items.Clear();
                for (int i = 0; i <= cnt / 20; i++)
                {
                    cb_Page.Items.Add(i + 1);
                }
                cb_Page.SelectedIndex = 0;
            }
            res = res.Skip(20 * cb_Page.SelectedIndex).Take(20).ToList();
            foreach (ContactPerson contactPerson in res)
            {
                string phone = contactPerson.ContactPhone.Aggregate("",
                    (current, item) => current + (item.PhoneNumber + "\n"));
                if (phone.Length > 0)
                    phone = phone.Substring(0, phone.Length - 1);
                string email = contactPerson.ContactEmail.Aggregate("", (current, item) => current + (item.Email + "\n"));
                if (email.Length > 0)
                    email = email.Substring(0, email.Length - 1);

                string address = contactPerson.ContactAddress.Aggregate("",
                    (current, item) => current + (item.Address + "\n"));
                if (address.Length > 0)
                    address = address.Substring(0, address.Length - 1);

                string group = contactPerson.ContactGroup.Aggregate("",
                    (current, item) => current + (item.ContactGroupDef.GroupName + "\n"));
                if (group.Length > 0)
                    group = group.Substring(0, group.Length - 1);

                dataGV_person.Rows.Add(new object[]
                {
                    contactPerson.Id,
                    contactPerson.FirstName,
                    contactPerson.LastName,
                    contactPerson.PostName,
                    phone,
                    email,
                    address,
                    group
                });
            }
        }

        private void dataGV_person_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGV_person.SelectedRows.Count == 1)
            {
                this.Hide();
                int cotacatid;
                int.TryParse(dataGV_person.SelectedRows[0].Cells[0].Value.ToString(), out cotacatid);
                var form = new AddContact(cotacatid);
                form.ShowDialog();
                this.Show();
                this.Focus();
                ContactsEntities db = new ContactsEntities();
                _allperson = db.ContactPerson.ToList();
                Search();
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.DefaultExt = ".xlsx";
            sf.FileName = "Contact Export-" + DateTime.Now.ToShortDateString().Replace("/", "-");
            sf.Title = @"محل ذخیره فایل را انتخاب نمایید";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                if(File.Exists(sf.FileName))
                    File.Delete(sf.FileName);
                FileInfo output = new FileInfo(sf.FileName);
                using (var package = new ExcelPackage(output))
                {
                    // add a new worksheet to the empty workbook
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Contact Export");

                    worksheet.TabColor = Color.Blue;
                    worksheet.View.RightToLeft = true;
                    
                    worksheet.DefaultRowHeight = 12;
                    worksheet.Row(1).Height = 20;
                    worksheet.Cells[1, 1].Value = "نام";
                    worksheet.Cells[1, 2].Value = "نام خانوادگی";
                    worksheet.Cells[1, 3].Value = "سمت";
                    worksheet.Cells[1, 4].Value = "تلفن تماس";
                    worksheet.Cells[1, 5].Value = "رایانامه";
                    worksheet.Cells[1, 6].Value = "آدرس";
                    worksheet.Cells[1, 7].Value = "گروه";
                    using (var range = worksheet.Cells[1, 1, 1, 7])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        range.Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                        range.Style.Font.Color.SetColor(Color.Black);
                        range.Style.ShrinkToFit = false;
                    }

                    List<long> groups =
                        (from object item in clb_Groups.SelectedItems select ((ContactGroupDef) item).Id).ToList();
                    var res = _allperson.Where(p =>
                        (string.IsNullOrEmpty(tb_firstname.Text) ||
                         Convert.ToString(p.FirstName).Contains(tb_firstname.Text)) &&
                        (string.IsNullOrEmpty(tb_LastName.Text) ||
                         Convert.ToString(p.LastName).Contains(tb_LastName.Text)) &&
                        (string.IsNullOrEmpty(tb_postname.Text) ||
                         Convert.ToString(p.PostName).Contains(tb_postname.Text)) &&
                        (string.IsNullOrEmpty(tb_call.Text) ||
                         p.ContactPhone.Any(c => c.PhoneNumber.Contains(tb_call.Text))) &&
                        (string.IsNullOrEmpty(tb_email.Text) || p.ContactEmail.Any(c => c.Email.Contains(tb_email.Text))) &&
                        (string.IsNullOrEmpty(tb_address.Text) ||
                         p.ContactAddress.Any(c => c.Address.Contains(tb_address.Text))) &&
                        (!groups.Any() || p.ContactGroup.Any(c => groups.Contains(c.GroupId)))
                        ).ToList();
                    int rownumber = 1;
                    foreach (ContactPerson contactPerson in res)
                    {
                        string phone = contactPerson.ContactPhone.Aggregate("",
                            (current, item) => current + (item.PhoneNumber + "\n"));
                        if (phone.Length > 0)
                            phone = phone.Substring(0, phone.Length - 1);
                        string email = contactPerson.ContactEmail.Aggregate("",
                            (current, item) => current + (item.Email + "\n"));
                        if (email.Length > 0)
                            email = email.Substring(0, email.Length - 1);

                        string address = contactPerson.ContactAddress.Aggregate("",
                            (current, item) => current + (item.Address + "\n"));
                        if (address.Length > 0)
                            address = address.Substring(0, address.Length - 1);

                        string group = contactPerson.ContactGroup.Aggregate("",
                            (current, item) => current + (item.ContactGroupDef.GroupName + "\n"));
                        if (group.Length > 0)
                            group = group.Substring(0, group.Length - 1);
                        rownumber++;
                        worksheet.Cells[rownumber, 1].Value = contactPerson.FirstName;
                        worksheet.Cells[rownumber, 2].Value = contactPerson.LastName;
                        worksheet.Cells[rownumber, 3].Value = contactPerson.PostName;
                        worksheet.Cells[rownumber, 4].Value = phone;
                        worksheet.Cells[rownumber, 5].Value = email;
                        worksheet.Cells[rownumber, 6].Value = address;
                        worksheet.Cells[rownumber, 7].Value = group;


                    }
                    worksheet.Column(1).AutoFit();
                    worksheet.Column(2).AutoFit();
                    worksheet.Column(3).AutoFit();
                    worksheet.Column(4).AutoFit();
                    worksheet.View.FreezePanes(2, 1);
                    package.Workbook.Properties.Title = "Contact Export";
                    package.Workbook.Properties.Author = "Contact Manager @ Ali Kamali";
                    package.Workbook.Properties.Comments = @"https://github.com/ali-kamali/Contacts-Manager/";
                    package.Workbook.Properties.Company = "Ali Kamali";
                    package.Save();
                }
                MessageBox.Show(@"جست و جوی شما با موفقیت برون ریزی شد");
            }
        }
    }
}