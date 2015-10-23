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
    public partial class GroupsMng : Form
    {
        public GroupsMng()
        {
            InitializeComponent();
        }

        private void GroupsMng_Load(object sender, EventArgs e)
        {
            LoadGroup();
        }

        public void LoadGroup()
        {
            dataGV_group.Rows.Clear();
            ContactsEntities db=new ContactsEntities();
            foreach (ContactGroupDef contactGroupDef in db.ContactGroupDef.ToList())
            {
                dataGV_group.Rows.Add(new object[]
                {
                    contactGroupDef.Id,
                    contactGroupDef.GroupName
                });
            }
        }

        private void btn_addGroup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_groupName.Text))
            {
                ContactsEntities db = new ContactsEntities();
                db.ContactGroupDef.Add(new ContactGroupDef()
                {
                    GroupName = tb_groupName.Text
                });
                db.SaveChanges();
                LoadGroup();
                MessageBox.Show("با موفقیت اضافه شد");
            }
        }

        private void btn_removeGroup_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dataGV_group.SelectedRows)
            {
                int groupid;
                if (int.TryParse(selectedRow.Cells[0].Value.ToString(), out groupid))
                {
                    ContactsEntities db = new ContactsEntities();
                    db.Database.ExecuteSqlCommand("DELETE FROM ContactGroupDef WHERE Id="+groupid);
                    db.Database.ExecuteSqlCommand("DELETE FROM ContactGroup WHERE GroupId=" + groupid);
                    db.SaveChanges();
                    LoadGroup();
                    MessageBox.Show("با موفقیت حذف شد");
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();;
        }
    }
}
