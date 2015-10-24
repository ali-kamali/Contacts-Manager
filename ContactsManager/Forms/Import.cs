﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ContactsManager.Utility;
using OfficeOpenXml;

namespace ContactsManager.Forms
{
    public partial class Import : Form
    {
        private string FilepathString = "";
        public Import()
        {
            InitializeComponent();
        }

        private void btn_selectfile_Click(object sender, EventArgs e)
        {
            btn_import.Enabled = false;
            OpenFileDialog fl = new OpenFileDialog();
            if (fl.ShowDialog() == DialogResult.OK)
            {
                var existingFile = new FileInfo(fl.FileName);
                using (var package = new ExcelPackage(existingFile))
                {
                    ExcelWorkbook workBook = package.Workbook;

                    if (workBook != null)
                    {
                        if (workBook.Worksheets.Count > 0)
                        {
                            ExcelWorksheet currentWorksheet = workBook.Worksheets.First();
                            foreach (var firstRowCell in currentWorksheet.Cells[1, 1, 1, currentWorksheet.Dimension.End.Column])
                            {
                                dataGV_group.Rows.Add(firstRowCell.Text, DataModelKey.None);
                            }
                            FilepathString = fl.FileName;
                            btn_import.Enabled = true;
                        }

                    }
                }
            }
        }

        private void Import_Load(object sender, EventArgs e)
        {
            var col = (DataGridViewComboBoxColumn)dataGV_group.Columns[1];
            col.DataSource = Configs.DataModels;
            col.ValueMember = "Modelkey";
            col.DisplayMember = "ModelName";
            btn_import.Enabled = false;
            ContactsEntities db = new ContactsEntities();
            var g = db.ContactGroupDef.ToList();
            foreach (ContactGroupDef contactGroupDef in g)
            {
                clb_Groups.Items.Add(contactGroupDef);
            }
            clb_Groups.DisplayMember = "GroupName";
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            List<ContactGroup> contactGroups= (from ContactGroupDef g in clb_Groups.SelectedItems select new ContactGroup() {GroupId = g.Id}).ToList();
            ContactsEntities db=new ContactsEntities();
            btn_import.Enabled = false;
            int cnt = 0;
            var now = DateTime.Now;
            
            var existingFile = new FileInfo(FilepathString);
            using (var package = new ExcelPackage(existingFile))
            {
                ExcelWorkbook workBook = package.Workbook;

                if (workBook != null)
                {
                    if (workBook.Worksheets.Count > 0)
                    {
                        ExcelWorksheet currentWorksheet = workBook.Worksheets.First();
                        List<DataModelKey> dataModels = (from DataGridViewRow row in dataGV_group.Rows select (DataModelKey)row.Cells[1].Value).ToList();

                        for (int i = 2; i <= currentWorksheet.Dimension.End.Row; i++)
                        {
                            int col = 0;
                            cnt++;
                            ContactPerson person = new ContactPerson();
                            List<ContactPhone> contactPhones = new List<ContactPhone>();
                            List<ContactEmail> contactEmails = new List<ContactEmail>();
                            List<ContactAddress> contactAddresses = new List<ContactAddress>();
                            foreach (var rowCell in currentWorksheet.Cells[i, 1, i, currentWorksheet.Dimension.End.Column])
                            {
                                string value = rowCell.Text;
                                if (!string.IsNullOrEmpty(value)&&col<dataModels.Count)
                                {
                                    switch (dataModels[col])
                                    {
                                        case DataModelKey.FirstName:
                                            person.FirstName = value;
                                            break;
                                        case DataModelKey.LastName:
                                            person.LastName = value;
                                            break;
                                        case DataModelKey.PostName:
                                            person.PostName = value;
                                            break;
                                        case DataModelKey.BirthDate:
                                            long birthdate;
                                            long.TryParse(value, out birthdate);
                                            person.DateOfBirth = birthdate;
                                            break;
                                        case DataModelKey.MobilePhone:
                                            contactPhones.Add(new ContactPhone(){PhoneType = 0,PhoneNumber = value});
                                            break;
                                        case DataModelKey.HomePhone:
                                            contactPhones.Add(new ContactPhone() { PhoneType = 1, PhoneNumber = value });
                                            break;
                                        case DataModelKey.WorkPhone:
                                            contactPhones.Add(new ContactPhone() { PhoneType = 2, PhoneNumber = value });
                                            break;
                                        case DataModelKey.PersonalEmail:
                                            contactEmails.Add(new ContactEmail() { EmailType = 0, Email = value });
                                            break;
                                        case DataModelKey.WorkEmail:
                                            contactEmails.Add(new ContactEmail() { EmailType = 1, Email = value });
                                            break;
                                        case DataModelKey.HomeAddress:
                                            contactAddresses.Add(new ContactAddress() { AddressType = 0, Address = value });
                                            break;
                                        case DataModelKey.WorkAddress:
                                            contactAddresses.Add(new ContactAddress() { AddressType = 1, Address = value });
                                            break;
                                    }
                                }
                                col++;
                            }
                            if (person.FirstName != "" || person.LastName != "")
                            {
                                db.ContactPerson.Add(person);
                                db.SaveChanges();
                                foreach (ContactPhone contactPhone in contactPhones)
                                {
                                    contactPhone.ContactPersonID = person.Id;
                                    db.ContactPhone.Add(contactPhone);
                                }
                                foreach (ContactAddress contactAddress in contactAddresses)
                                {
                                    contactAddress.ContactPersonID = person.Id;
                                    db.ContactAddress.Add(contactAddress);
                                }
                                foreach (ContactEmail contactEmail in contactEmails)
                                {
                                    contactEmail.ContactPersonID = person.Id;
                                    db.ContactEmail.Add(contactEmail);
                                }
                                foreach (ContactGroup contactGroup in contactGroups)
                                {
                                    contactGroup.ContactPersonID = person.Id;
                                    db.ContactGroup.Add(contactGroup);
                                }
                                db.SaveChanges();
                            }
                            else
                            {
                                break;
                            }
                        }
                        btn_import.Enabled = true;
                    }
                }
            }
            MessageBox.Show(cnt+ " Added in "+DateTime.Now.Subtract(now).TotalSeconds+" Secs");

        }
    }
}