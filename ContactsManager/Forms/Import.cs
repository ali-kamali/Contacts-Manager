using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using ContactsManager.Models;
using ContactsManager.Utility;
using OfficeOpenXml;

namespace ContactsManager.Forms
{
    public partial class Import : Form
    {
        private string _filepathString = "";
        private Thread _t;
        private List<ContactGroup> _contactGroups;
        private List<DataModelKey> _dataModels;

        public Import()
        {
            InitializeComponent();
        }

        private void btn_selectfile_Click(object sender, EventArgs e)
        {
            btn_import.Enabled = false;
            OpenFileDialog fl = new OpenFileDialog();
            fl.CheckFileExists = true;
            fl.DefaultExt = ".xlsx";
            fl.Title = @"لطفا فایل اکسل ورودی خود را انتخاب نمایید";
            if (fl.ShowDialog() == DialogResult.OK)
            {
                var existingFile = new FileInfo(fl.FileName);
                if (MyUtility.IsFileLocked(existingFile))
                    MessageBox.Show(@"فایل انتخاب شده توسط برنامه ای دیگر در حال استفاده می باشد لطفا آن را ببندید");
                else if (existingFile.Extension != ".xlsx" && existingFile.Extension != ".xls")
                {
                    MessageBox.Show(@"لطفا داده های خود را در یک فایل اکسل ذخیره نمایید");
                }
                else
                {
                    using (var package = new ExcelPackage(existingFile))
                    {
                        ExcelWorkbook workBook = package.Workbook;

                        if (workBook != null)
                        {
                            if (workBook.Worksheets.Count > 0)
                            {
                                ExcelWorksheet currentWorksheet = workBook.Worksheets.First();
                                foreach (
                                    var firstRowCell in
                                        currentWorksheet.Cells[1, 1, 1, currentWorksheet.Dimension.End.Column])
                                {
                                    dataGV_group.Rows.Add(firstRowCell.Text, DataModelKey.None);
                                }
                                _filepathString = fl.FileName;
                                btn_import.Enabled = true;
                            }
                        }
                    }
                }
            }
        }

        private void Import_Load(object sender, EventArgs e)
        {
            var col = (DataGridViewComboBoxColumn) dataGV_group.Columns[1];
            col.DataSource = MyConfigs.DataModels;
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
            _contactGroups =
                (from ContactGroupDef g in clb_Groups.SelectedItems select new ContactGroup() {GroupId = g.Id}).ToList();
            _dataModels =
                (from DataGridViewRow row in dataGV_group.Rows select (DataModelKey) row.Cells[1].Value).ToList();
            _t = new Thread(ImportData);
            if (!_t.IsAlive)
                _t.Start();
            btn_import.Enabled = false;
        }

        private void ImportData()
        {
            ContactsEntities db = new ContactsEntities();
            int cnt = 0;

            var now = DateTime.Now;
            var existingFile = new FileInfo(_filepathString);
            using (var package = new ExcelPackage(existingFile))
            {
                ExcelWorkbook workBook = package.Workbook;

                if (workBook != null)
                {
                    if (workBook.Worksheets.Count > 0)
                    {
                        ExcelWorksheet currentWorksheet = workBook.Worksheets.First();

                        SetControlPropertyValue(l_allcnt, "Text", currentWorksheet.Dimension.End.Row.ToString());
                        for (int i = 2; i <= currentWorksheet.Dimension.End.Row; i++)
                        {
                            int col = 0;
                            SetControlPropertyValue(L_per, "Text",
                                "%" + ((float) cnt*100/currentWorksheet.Dimension.End.Row).ToString("00.00"));
                            SetControlPropertyValue(L_cnt, "Text", cnt.ToString());
                            cnt++;

                            ContactPerson person = new ContactPerson();
                            List<ContactPhone> contactPhones = new List<ContactPhone>();
                            List<ContactEmail> contactEmails = new List<ContactEmail>();
                            List<ContactAddress> contactAddresses = new List<ContactAddress>();
                            foreach (
                                var rowCell in currentWorksheet.Cells[i, 1, i, currentWorksheet.Dimension.End.Column])
                            {
                                string value = rowCell.Text;
                                if (!string.IsNullOrEmpty(value) && col < _dataModels.Count)
                                {
                                    switch (_dataModels[col])
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
                                            contactPhones.Add(new ContactPhone() {PhoneType = 0, PhoneNumber = value});
                                            break;
                                        case DataModelKey.HomePhone:
                                            contactPhones.Add(new ContactPhone() {PhoneType = 1, PhoneNumber = value});
                                            break;
                                        case DataModelKey.WorkPhone:
                                            contactPhones.Add(new ContactPhone() {PhoneType = 2, PhoneNumber = value});
                                            break;
                                        case DataModelKey.PersonalEmail:
                                            contactEmails.Add(new ContactEmail() {EmailType = 0, Email = value});
                                            break;
                                        case DataModelKey.WorkEmail:
                                            contactEmails.Add(new ContactEmail() {EmailType = 1, Email = value});
                                            break;
                                        case DataModelKey.HomeAddress:
                                            contactAddresses.Add(new ContactAddress() {AddressType = 0, Address = value});
                                            break;
                                        case DataModelKey.WorkAddress:
                                            contactAddresses.Add(new ContactAddress() {AddressType = 1, Address = value});
                                            break;
                                    }
                                }
                                col++;
                            }
                            if (person.FirstName != "" || person.LastName != "")
                            {
                                
                                //db.ContactPerson.Add(person);
                                //db.SaveChanges();
                                ContactPerson oldperson=null;
                                foreach (ContactPhone contactPhone in contactPhones)
                                {
                                    var oldphone = db.ContactPhone.FirstOrDefault(p => p.PhoneNumber == contactPhone.PhoneNumber);
                                    if (oldphone != null)
                                    {
                                        oldperson = oldphone.ContactPerson;
                                    }
                                }
                                if (oldperson != null)
                                {
                                    if (!string.IsNullOrEmpty(person.PostName))
                                        oldperson.PostName =person.PostName;
                                    if (!string.IsNullOrEmpty(person.FirstName))
                                        oldperson.FirstName = person.FirstName;
                                    if (!string.IsNullOrEmpty(person.LastName))
                                        oldperson.PostName = person.LastName;
                                    if (person.DateOfBirth!=null)
                                        oldperson.DateOfBirth = person.DateOfBirth;
                                    person = oldperson;
                                    db.SaveChanges();
                                }

                                foreach (ContactPhone contactPhone in contactPhones)
                                {
                                    if (person.ContactPhone.All(p => p.PhoneNumber != contactPhone.PhoneNumber))
                                        person.ContactPhone.Add(contactPhone);
                                    else
                                    {
                                        var fphone = person.ContactPhone.FirstOrDefault(
                                            p => p.PhoneNumber == contactPhone.PhoneNumber);
                                        if (fphone != null)
                                            fphone.PhoneType = contactPhone.PhoneType;
                                    }
                                    //contactPhone.ContactPersonID = person.Id;
                                   // db.ContactPhone.Add(contactPhone);
                                }
                                foreach (ContactAddress contactAddress in contactAddresses)
                                {
                                    if (person.ContactAddress.All(p => p.Address != contactAddress.Address))
                                        person.ContactAddress.Add(contactAddress);
                                    else
                                    {
                                        var fphone = person.ContactAddress.FirstOrDefault(
                                            p => p.Address == contactAddress.Address);
                                        if (fphone != null)
                                            fphone.AddressType = contactAddress.AddressType;
                                    }
                                   
                                    //contactAddress.ContactPersonID = person.Id;
                                    //db.ContactAddress.Add(contactAddress);
                                }
                                foreach (ContactEmail contactEmail in contactEmails)
                                {
                                    if (person.ContactEmail.All(p => p.Email != contactEmail.Email))
                                        person.ContactEmail.Add(contactEmail);
                                    else
                                    {
                                        var fphone = person.ContactEmail.FirstOrDefault(
                                            p => p.Email == contactEmail.Email);
                                        if (fphone != null)
                                            fphone.EmailType = contactEmail.EmailType;
                                    }
                                   
                                    //contactEmail.ContactPersonID = person.Id;
                                    //db.ContactEmail.Add(contactEmail);
                                }
                                foreach (ContactGroup contactGroup in _contactGroups)
                                {
                                    if (person.ContactGroup.All(p => p.GroupId != contactGroup.GroupId))
                                        person.ContactGroup.Add(contactGroup);
                                    //contactGroup.ContactPersonID = person.Id;
                                    //db.ContactGroup.Add(contactGroup);
                                }
                                if (oldperson == null)
                                {
                                    db.ContactPerson.Add(person);
                                }
                                try
                                {
                                    db.SaveChanges();
                                }
                                catch (DbEntityValidationException e)
                                {
                                    foreach (var eve in e.EntityValidationErrors)
                                    {
                                        MessageBox.Show("Entity of type " + eve.Entry.Entity.GetType().Name +
                                                        " in state " + eve.Entry.State +
                                                        " has the following validation errors:");
                                        foreach (var ve in eve.ValidationErrors)
                                        {
                                            MessageBox.Show("- Property: "+ve.PropertyName+", Error: "+ve.ErrorMessage);
                                        }
                                    }
                                    throw;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            MessageBox.Show(cnt + " Added in " + DateTime.Now.Subtract(now).TotalSeconds + " Secs");
            SetControlPropertyValue(btn_import, "Enabled", true);
        }

        private delegate void SetControlValueCallback(Control oControl, string propName, object propValue);

        private void SetControlPropertyValue(Control oControl, string propName, object propValue)
        {
            if (oControl.InvokeRequired)
            {
                SetControlValueCallback d = SetControlPropertyValue;
                oControl.Invoke(d, new object[] {oControl, propName, propValue});
            }
            else
            {
                Type type = oControl.GetType();
                PropertyInfo[] props = type.GetProperties();
                foreach (PropertyInfo p in props)
                {
                    if (String.Equals(p.Name, propName, StringComparison.CurrentCultureIgnoreCase))
                    {
                        p.SetValue(oControl, propValue, null);
                    }
                }
            }
        }

        private void Import_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (_t.IsAlive)
                    _t.Abort();
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}