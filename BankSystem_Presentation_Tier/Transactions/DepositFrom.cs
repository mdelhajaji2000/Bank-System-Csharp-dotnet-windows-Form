using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_Presentation_Tier.Transactions
{
    public partial class DepositFrom : Form
    {
        private enum enMode { Deposit, WithDraw }

        private enMode _Mode = enMode.Deposit;

        private clsClientAccount account = null;

        private int _AccountNumber;

        // Action Type : '+' Deposit '-' WithDraw
        public DepositFrom(int AccountNumber, char Actiontype = '+')
        {
            InitializeComponent();

            switch (Actiontype)
            {
                case '+':
                    this._Mode = enMode.Deposit;
                    break;
                case '-':
                    this._Mode = enMode.WithDraw;
                    break;
                default:
                    throw new Exception("Invalid Action Type Only '+' For Deposit and '-' For WithDraw ..!");
            }

            this.account = clsClientAccount.Find(AccountNumber);

            if (account == null)
            {
                MessageBox.Show("Account Not Found ");
                this.Close();
            }

            _AccountNumber = AccountNumber;
        }

        private static string FormatNumberWithPeriods(string numberString)
        {
            // Assuming the format is: 000.243.342 for a 9-digit number
            // Adjust according to the number of digits and placement of periods

            if (numberString.Length < 9)
            {
                for (int i = numberString.Length; i < 9; i++)
                {
                    numberString = "0" + numberString;
                }
            }

            if (numberString.Length != 9)
            {
                throw new ArgumentException("Input number string must be 9 characters long.");
            }

            // Insert periods
            return numberString.Substring(0, 3) + "." +
                   numberString.Substring(3, 3) + "." +
                   numberString.Substring(6, 3);
        }

        private void RefreshAccountData()
        {
            account = clsClientAccount.Find(_AccountNumber);

            DisplayAccNumber.Text = account.AccountNumber.ToString();
            DisplayFullName.Text = account.PersonInfo.FirstName + " " + account.PersonInfo.LastName;
            DisplayBalance.Text = FormatNumberWithPeriods(account.Balance.ToString());
        }

        private void DepositFrom_Load(object sender, EventArgs e)
        {
            if (this._Mode == enMode.Deposit)
            {
                PageTitle.Text = "Transactions-Deposit";
                PageIcon.Image = imageList1.Images[0];
            }
            else
            {
                PageTitle.Text = "Transactions-WithDraw";
                PageIcon.Image = imageList1.Images[1];
            }

            DisplayAccNumber.Text = account.AccountNumber.ToString();
            DisplayFullName.Text = account.PersonInfo.FirstName + " " + account.PersonInfo.LastName;
            DisplayBalance.Text = FormatNumberWithPeriods(account.Balance.ToString());
        }

        private void BTN_Done_Click(object sender, EventArgs e)
        {
            int amount = 0;

            if (int.TryParse(TB_Amount.Text, out int intResult) && amount <= 0)
                amount = intResult;
            else
            {
                MessageBox.Show("Invalid Input Only Numbers...!");
                return;
            }

            switch (_Mode)
            {
                case enMode.Deposit:

                    if (amount > 999999999)
                    {
                        MessageBox.Show("Tooo Much Money (You Are Not A Billionaire by the way (; ) ...!");
                        return;
                    }    

                    if (MessageBox.Show("Confirm The Action By Pressing 'Yes'", "Confirmation", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {
                        if (account.AddAmountToBalance(amount))
                            MessageBox.Show("Action Performed Successfuly");
                        else
                            MessageBox.Show("Echec..!");
                    }

                    break;
                case enMode.WithDraw:

                    if (amount > 999999999)
                    {
                        MessageBox.Show("Tooo Much Money (You Are Not A Billionaire by the way (; ) ...!");
                        return;
                    }

                    if (amount > account.Balance)
                    {
                        MessageBox.Show("You Dont have That Much Money Your Balance Is : " + account.Balance);
                        return;
                    }    

                    if (MessageBox.Show("Confirm The Action By Pressing 'Yes'", "Confirmation", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {
                        if (account.IncreaseAmountFromBalance(amount))
                            MessageBox.Show("Action Performed Successfuly");
                        else
                            MessageBox.Show("Echec..!");
                    }

                    break;
            }

            TB_Amount.Clear();

            RefreshAccountData();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
