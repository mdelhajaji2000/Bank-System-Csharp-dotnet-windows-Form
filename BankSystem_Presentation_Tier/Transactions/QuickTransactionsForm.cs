using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_Presentation_Tier.Transactions
{
    public partial class QuickTransactionsForm : Form
    {
        private clsClientAccount account;

        public QuickTransactionsForm(int AccountNumber)
        {
            InitializeComponent();

            account = clsClientAccount.Find(AccountNumber);

            if (account == null)
            {
                MessageBox.Show("Error Client Not Found..!");
                return;
            }

            DisplayBalance.Text = account.Balance.ToString();
            DisplayFullName.Text = account.PersonInfo.FirstName + " " + account.PersonInfo.LastName;
            DisplayAccNumber.Text = account.AccountNumber.ToString();
        }

        private void Get_100_Click(object sender, EventArgs e)
        {

            string strAmount = ((Button)sender).Tag.ToString();
            int Amount = 0;

            if (int.TryParse(strAmount, out int result))
                Amount = result;

            if (account != null && Amount < account.Balance)
            {
                if (account.IncreaseAmountFromBalance(Amount))
                {
                    MessageBox.Show("Action Performed Successfuly...!");
                }
            }
            else
                MessageBox.Show("You Can not Perform That Action (Your Balance isnt enought...!)");
            

            DisplayBalance.Text = account.Balance.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
