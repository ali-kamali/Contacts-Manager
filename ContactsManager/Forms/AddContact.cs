using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ContactsManager.Models;
using ContactsManager.Utility;

namespace ContactsManager.Forms
{
    public partial class AddContact : Form
    {
        private int _callnum, _emailnum, _addressnum, _contactid;

        public AddContact(int contactid = 0)
        {
            InitializeComponent();
            _contactid = contactid;
        }

        private void AddContact_Load(object sender, EventArgs e)
        {
            ContactsEntities db = new ContactsEntities();
            var g = db.ContactGroupDef.ToList();
            foreach (ContactGroupDef contactGroupDef in g)
            {
                clb_Groups.Items.Add(contactGroupDef);
            }
            clb_Groups.DisplayMember = "GroupName";
            if (_contactid > 0)
                LoadContact(_contactid);
        }

        private void LoadContact(int contactid)
        {
            ContactsEntities db = new ContactsEntities();
            var per = db.ContactPerson.FirstOrDefault(p => p.Id == contactid);
            if (per != null)
            {
                tb_firstname.Text = per.FirstName;
                tb_LastName.Text = per.LastName;
                tb_Birthdate.Text = per.DateOfBirth.ToString();
                tb_postname.Text = per.PostName;
                this.Text = "ویرایش مخاطب";
                btn_add.Text = "ویرایش مخاطب";
                btn_delete.Visible = true;
                foreach (ContactPhone contactPhone in per.ContactPhone)
                {
                    AddCallBox((int) contactPhone.PhoneType, contactPhone.PhoneNumber);
                }
                foreach (ContactAddress contactaddress in per.ContactAddress)
                {
                    AddAddressBox((int) contactaddress.AddressType, contactaddress.Address);
                }
                foreach (ContactEmail contactemail in per.ContactEmail)
                {
                    AddEmailBox((int) contactemail.EmailType, contactemail.Email);
                }
                foreach (ContactGroup contactGroup in per.ContactGroup)
                {
                    int index = 0;
                    foreach (ContactGroupDef cGroup in db.ContactGroupDef.ToList())
                    {
                        if (cGroup.Id == contactGroup.GroupId)
                            clb_Groups.SetItemChecked(index, true);
                        index++;
                    }
                }
            }
            else
            {
                MessageBox.Show("مخاطبی یافت نشد");
                this.Close();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ContactsEntities db = new ContactsEntities();
            if (_contactid > 0)
            {
                var con = db.ContactPerson.FirstOrDefault(p => p.Id == _contactid);
                if (con != null)
                {
                    db.ContactPerson.Remove(con);

                    db.SaveChanges();
                    db.Database.ExecuteSqlCommand("DELETE FROM ContactPhone WHERE ContactPersonID=" + _contactid);
                    db.Database.ExecuteSqlCommand("DELETE FROM ContactAddress WHERE ContactPersonID=" + _contactid);
                    db.Database.ExecuteSqlCommand("DELETE FROM ContactEmail WHERE ContactPersonID=" + _contactid);
                    db.Database.ExecuteSqlCommand("DELETE FROM ContactGroup WHERE ContactPersonID=" + _contactid);
                }
            }

            int b;
            int.TryParse(tb_Birthdate.Text, out b);
            ContactPerson per = new ContactPerson()
            {
                FirstName = tb_firstname.Text,
                LastName = tb_LastName.Text,
                PostName = tb_postname.Text,
                DateOfBirth = b
            };
            db.ContactPerson.Add(per);
            db.SaveChanges();

            for (int i = 0; i < _callnum; i++)
            {
                if (panelCall.Controls.Find("tb_call" + i, false).Any())
                {
                    var tb = (TextBox) (panelCall.Controls.Find("tb_call" + i, false))[0];
                    var cb = (ComboBox) (panelCall.Controls.Find("cb_Calltype" + i, false))[0];
                    if (!string.IsNullOrEmpty(tb.Text))
                    {
                        db.ContactPhone.Add(new ContactPhone()
                        {
                            ContactPersonID = per.Id,
                            PhoneNumber = tb.Text,
                            PhoneType = cb.SelectedIndex
                        });
                    }
                }
            }
            for (int i = 0; i < _emailnum; i++)
            {
                if (panelEmail.Controls.Find("tb_email" + i, false).Any())
                {
                    var tb = (TextBox) (panelEmail.Controls.Find("tb_email" + i, false))[0];
                    var cb = (ComboBox) (panelEmail.Controls.Find("cb_emailtype" + i, false))[0];
                    if (!string.IsNullOrEmpty(tb.Text))
                    {
                        db.ContactEmail.Add(new ContactEmail()
                        {
                            ContactPersonID = per.Id,
                            Email = tb.Text,
                            EmailType = cb.SelectedIndex
                        });
                    }
                }
            }
            for (int i = 0; i < _addressnum; i++)
            {
                if (panelAddress.Controls.Find("tb_address" + i, false).Any())
                {
                    var tb = (TextBox) (panelAddress.Controls.Find("tb_address" + i, false))[0];
                    var cb = (ComboBox) (panelAddress.Controls.Find("cb_addresstype" + i, false))[0];
                    if (!string.IsNullOrEmpty(tb.Text))
                    {
                        db.ContactAddress.Add(new ContactAddress()
                        {
                            ContactPersonID = per.Id,
                            Address = tb.Text,
                            AddressType = cb.SelectedIndex
                        });
                    }
                }
            }
            foreach (var selectedItem in clb_Groups.SelectedItems)
            {
                var g = (ContactGroupDef) selectedItem;
                db.ContactGroup.Add(new ContactGroup()
                {
                    ContactPersonID = per.Id,
                    GroupId = g.Id
                });
            }
            db.SaveChanges();

            MessageBox.Show("تغییرات خواسته شده اعمال شد");
            this.Close();
        }


        private void AddCall_Click(object sender, EventArgs e)
        {
            AddCallBox();
        }


        private void AddEmail_Click(object sender, EventArgs e)
        {
            AddEmailBox();
        }

        private void AddAddress_Click(object sender, EventArgs e)
        {
            AddAddressBox();
        }

        private void AddCallBox(int type = 0, string value = "")
        {
            TextBox tbCall = new TextBox();
            tbCall.Font = new Font("B Nazanin", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            tbCall.Location = new Point(tb_call.Location.X, 40 + _callnum*35);
            tbCall.Name = "tb_call" + _callnum;
            tbCall.Size = tb_call.Size; //new Size(146, 31);
            tbCall.TabIndex = 10;
            tbCall.Text = value;

            ComboBox cbCalltype = new ComboBox();
            cbCalltype.Font = new Font("B Nazanin", 12F);
            cbCalltype.FormattingEnabled = true;
            cbCalltype.Items.AddRange(MyConfigs.CallType);
            cbCalltype.Location = new Point(cb_Calltype.Location.X, 40 + _callnum*35);
            cbCalltype.Name = "cb_Calltype" + _callnum;
            cbCalltype.RightToLeft = RightToLeft.Yes;
            cbCalltype.Size = cb_Calltype.Size; //new Size(100, 32);
            cbCalltype.TabIndex = 8;
            cbCalltype.SelectedIndex = type;
            panelCall.Controls.Add(tbCall);
            panelCall.Controls.Add(cbCalltype);
            _callnum++;
        }

        private void AddEmailBox(int type = 0, string value = "")
        {
            TextBox tbCall = new TextBox();
            tbCall.Font = new Font("B Nazanin", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            tbCall.Location = new Point(tb_Email.Location.X, 40 + _emailnum*35);
            tbCall.Name = "tb_email" + _emailnum;
            tbCall.Size = tb_Email.Size; //new Size(146, 31);
            tbCall.TabIndex = 10;
            tbCall.Text = value;

            ComboBox cbCalltype = new ComboBox();
            cbCalltype.Font = new Font("B Nazanin", 12F);
            cbCalltype.FormattingEnabled = true;
            cbCalltype.Items.AddRange(MyConfigs.EmailType);
            cbCalltype.Location = new Point(cb_Emailtype.Location.X, 40 + _emailnum*35);
            cbCalltype.Name = "cb_emailtype" + _emailnum;
            cbCalltype.RightToLeft = RightToLeft.Yes;
            cbCalltype.Size = cb_Emailtype.Size; //new Size(100, 32);
            cbCalltype.TabIndex = 8;
            cbCalltype.SelectedIndex = type;
            panelEmail.Controls.Add(tbCall);
            panelEmail.Controls.Add(cbCalltype);
            _emailnum++;
        }

        private void AddAddressBox(int type = 0, string value = "")
        {
            TextBox tbCall = new TextBox();
            tbCall.Font = new Font("B Nazanin", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            tbCall.Location = new Point(tb_Address.Location.X, 40 + _addressnum*35);
            tbCall.Name = "tb_address" + _addressnum;
            tbCall.Size = tb_Address.Size; //new Size(146, 31);
            tbCall.TabIndex = 10;
            tbCall.Text = value;

            ComboBox cbCalltype = new ComboBox();
            cbCalltype.Font = new Font("B Nazanin", 12F);
            cbCalltype.FormattingEnabled = true;
            cbCalltype.Items.AddRange(MyConfigs.AddressType);
            cbCalltype.Location = new Point(cb_Addresstype.Location.X, 40 + _addressnum*35);
            cbCalltype.Name = "cb_addresstype" + _addressnum;
            cbCalltype.RightToLeft = RightToLeft.Yes;
            cbCalltype.Size = cb_Addresstype.Size; //new Size(100, 32);
            cbCalltype.TabIndex = 8;
            cbCalltype.SelectedIndex = type;
            panelAddress.Controls.Add(tbCall);
            panelAddress.Controls.Add(cbCalltype);

            _addressnum++;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ContactsEntities db = new ContactsEntities();
            if (_contactid > 0)
            {
                var con = db.ContactPerson.FirstOrDefault(p => p.Id == _contactid);
                if (con != null)
                {
                    db.ContactPerson.Remove(con);
                    db.SaveChanges();
                    db.Database.ExecuteSqlCommand("DELETE FROM ContactPhone WHERE ContactPersonID=" + _contactid);
                    db.Database.ExecuteSqlCommand("DELETE FROM ContactAddress WHERE ContactPersonID=" + _contactid);
                    db.Database.ExecuteSqlCommand("DELETE FROM ContactEmail WHERE ContactPersonID=" + _contactid);
                    db.Database.ExecuteSqlCommand("DELETE FROM ContactGroup WHERE ContactPersonID=" + _contactid);
                }
            }
            MessageBox.Show("تغییرات خواسته شده اعمال شد");
            this.Close();
        }
    }
}