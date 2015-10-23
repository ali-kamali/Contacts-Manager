using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            ContactsEntities db=new ContactsEntities();
            var g = db.ContactGroupDef.ToList();
            foreach (ContactGroupDef contactGroupDef in g)
            {
                clb_Groups.Items.Add(contactGroupDef);
            }
            clb_Groups.DisplayMember = "GroupName";
            _allperson=db.ContactPerson.ToList();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            List<long> groups = (from object item in clb_Groups.SelectedItems select ((ContactGroupDef)item).Id).ToList();
            var res = _allperson.Where(p =>
                (string.IsNullOrEmpty(tb_firstname.Text) || Convert.ToString(p.FirstName).Contains(tb_firstname.Text)) &&
                (string.IsNullOrEmpty(tb_LastName.Text) || Convert.ToString(p.LastName).Contains(tb_LastName.Text)) &&
                (string.IsNullOrEmpty(tb_postname.Text) || Convert.ToString(p.PostName).Contains(tb_postname.Text)) &&
                (string.IsNullOrEmpty(tb_call.Text) || p.ContactPhone.Any(c => c.PhoneNumber.Contains(tb_call.Text))) &&
                (string.IsNullOrEmpty(tb_email.Text) || p.ContactEmail.Any(c => c.Email.Contains(tb_email.Text))) &&
                (string.IsNullOrEmpty(tb_address.Text) || p.ContactAddress.Any(c => c.Address.Contains(tb_address.Text))) &&
                (!groups.Any() || p.ContactGroup.Any(c => groups.Contains(c.GroupId)))
                );
            dataGV_person.Rows.Clear();
            foreach (ContactPerson contactPerson in res)
            {

                string phone = contactPerson.ContactPhone.Aggregate("", (current, item) => current + (item.PhoneNumber + "\n"));
                if (phone.Length > 0)
                    phone = phone.Substring(0, phone.Length - 1);
                string email = contactPerson.ContactEmail.Aggregate("", (current, item) => current + (item.Email + "\n"));
                if (email.Length > 0)
                    email = email.Substring(0, email.Length - 1);

                string address = contactPerson.ContactAddress.Aggregate("", (current, item) => current + (item.Address + "\n"));
                if (address.Length > 0)
                    address = address.Substring(0, address.Length - 1);

                string group = contactPerson.ContactGroup.Aggregate("", (current, item) => current + (item.ContactGroupDef.GroupName + "\n"));
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

        
    }
}
