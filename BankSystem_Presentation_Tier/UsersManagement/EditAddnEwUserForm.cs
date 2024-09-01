using BankSystem_Presentation_Tier.Controls;
using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_Presentation_Tier.UsersManagement
{
    public partial class EditAddnEwUserForm : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode = enMode.AddNew;

        clsUsers User = new clsUsers();

        public EditAddnEwUserForm()
        {
            InitializeComponent();

            User = new clsUsers();

            _Mode = enMode.AddNew;
        }

        public EditAddnEwUserForm(int UserID)
        {
            InitializeComponent();

            User = clsUsers.Find(UserID);

            _Mode = enMode.Update;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadInfo()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    AddNewEditTitleLael.Text = "Add New User";


                    break;
                case enMode.Update:

                    AddNewEditTitleLael.Text = "Update Contact Info";

                    userDataReader1.FillData(this.User.UserID);
                    personDataReader1.FillData(this.User.PersonID);

                    break;
            }
        }

        private void EditAddnEwUserForm_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            bool PerformAction = false;
            string ErrorMessage = "Error In Person Info Inputs";


            switch (_Mode)
            {
                case enMode.AddNew:


                    User = userDataReader1.returnData(ref PerformAction, ref ErrorMessage);

                    if (PerformAction)
                    {

                        clsPerson newPerson = new clsPerson();
                        newPerson = personDataReader1.ReadData();

                        if (newPerson.Validation())
                        {
                            newPerson.Save();
                        }
                        else
                        {
                            MessageBox.Show("person info arent validate ...!", "ValidationError");
                            return;
                        }

                        User.PersonID = newPerson.PersonID;
                        User.Save();

                        MessageBox.Show("Added Successeded..!");
                    }
                    else
                    {
                        MessageBox.Show(ErrorMessage, "Invalid Input");
                    }

                    this._Mode = enMode.Update;

                    break;
                case enMode.Update:

                    User = userDataReader1.ReadUserDataForUpdate(User.UserID, ref PerformAction, ref ErrorMessage);

                    if (PerformAction)
                    {
                        User.PersonInfo = personDataReader1.ReadDataForUpdate(User.PersonID);

                        if (User.PersonInfo.Validation())
                        {
                            User.PersonInfo.Save();
                        }
                        else
                        {
                            MessageBox.Show("Error In Person Info Validation", "Input validation Issues");
                            return;
                        }

                        User.Save();
                    }
                    else
                    {
                        MessageBox.Show("Input Error");
                        return;
                    }

                    break;
            }


            LoadInfo();

        }
    }
}
