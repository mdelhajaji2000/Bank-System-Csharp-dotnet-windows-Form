using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_Presentation_Tier.ClientsManagements.Forms
{
    public partial class FindClientForm : Form
    {
        public FindClientForm()
        {
            InitializeComponent();
        }

        clsClientAccount Account = null;

        private void btn_Find_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(FindTextBox.Text) && int.TryParse(FindTextBox.Text, out int SerchAccnumber))
            {
                Account = clsClientAccount.Find(SerchAccnumber);
            }
            else
            {
                MessageBox.Show("Unvalid AccountNumber", "Invalid Input Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            if (Account != null)
            {
                userFullInfo1._Person = clsPerson.Find(Account.PersonID);
                userFullInfo1.FillpersonInfo();

                clientAccountInfo1.FillData(Account.AccountNumber);
            }
            else
            {
                MessageBox.Show("No Client Account Found..!", "Client Not Found (404)");
            }
        }

        public void FillDataUsingParameter(int AccNumber)
        {
            SerchControls.Hide();

            Account = clsClientAccount.Find(AccNumber);

            if (Account != null)
            {
                userFullInfo1._Person = clsPerson.Find(Account.PersonID);
                userFullInfo1.FillpersonInfo();

                clientAccountInfo1.FillData(Account.AccountNumber);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowForDelete()
        {
            DeleteControl.Show();
            SerchControls.Hide();
        }

        private void BT_deleteClient_Click(object sender, EventArgs e)
        {
            if (clsClientAccount.DeleteClient(Account.AccountNumber) && clsPerson.DeletePerson(Account.PersonID))
                MessageBox.Show("Account Number : " + Account.AccountNumber + "Was Deleted Successfuly..!", "Action Performed (Successded)");
            else
                MessageBox.Show("Deletion Faild\nClient Still Exist....Try To Desactivate It?");

            this.Close();
            
        }
    }
}
