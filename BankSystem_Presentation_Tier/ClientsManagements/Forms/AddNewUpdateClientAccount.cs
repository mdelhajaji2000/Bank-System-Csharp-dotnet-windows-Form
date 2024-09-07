using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_Presentation_Tier.ClientsManagements.Forms
{
    public partial class AddNewUpdateClientAccount : Form
    {
        private enum enMode { AddNew, Update}

        private enMode _Mode = enMode.AddNew;

        private clsClientAccount account;

        public AddNewUpdateClientAccount()
        {
            InitializeComponent();

            account = new clsClientAccount();

            _Mode = enMode.AddNew;
        }

        public AddNewUpdateClientAccount(int AccountNumber)
        {
            InitializeComponent();

            account = clsClientAccount.Find(AccountNumber);
            _Mode = enMode.Update;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loadinfo()
        {

            
            switch (_Mode)
            {
                case enMode.AddNew:

                    LB_Title.Text = "Create New Client";

                    break;
                case enMode.Update:

                    LB_Title.Text = "Update Client Account";

                    personDataReader1.FillData(account.PersonID);
                    DisplayAccountNumber.Text = account.AccountNumber.ToString();

                    break;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    clsPerson person = personDataReader1.ReadData();
                    if (person.Validation())
                    {
                        person.Save();
                        account.PersonID = person.PersonID;
                        account.PersonInfo = person;
                        account.Save();

                        MessageBox.Show("Client Added Successfuly !", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Input", "Input validation Error !");
                        return;
                    }

                    this._Mode = enMode.Update;

                    break;
                case enMode.Update:

                    clsPerson Updatedperson = personDataReader1.ReadDataForUpdate(account.PersonInfo.PersonID);

                    if (Updatedperson.Validation())
                    {
                        account.PersonInfo = Updatedperson;

                        MessageBox.Show("Client Updated Successfuly !", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Input", "Input validation Error !");
                    }

                    break;
            }


            Loadinfo();
        }

        private void AddNewUpdateClientAccount_Load(object sender, EventArgs e)
        {
            Loadinfo();
        }
    }
}
