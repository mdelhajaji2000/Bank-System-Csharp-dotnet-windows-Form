﻿using BankSystem_Presentation_Tier.Libraries;
using BankSystem_Presentation_Tier.Transactions;
using BankSystem_Presentation_Tier.Transfers;
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

namespace BankSystem_Presentation_Tier.Controls
{
    public partial class TransactionRecord : UserControl
    {
        private clsTransactions Transactionrecord;
        private clsClientAccount Account;

        bool IsDeleted = false;

        public TransactionRecord(int TransactionID)
        {
            InitializeComponent();

            Transactionrecord = clsTransactions.Find(TransactionID);
            if (clsClientAccount.IsclientExist(Transactionrecord.AccountNumber))
            {
                Account = clsClientAccount.Find(Transactionrecord.AccountNumber);
                IsDeleted = false;
            }
            else
            {
                IsDeleted = true;
            }

            FillData();
        }

        private void FillData()
        {
            if (!IsDeleted)
            {
                TransactionID.Text = Transactionrecord.TransactionID.ToString();
                DisplayAccountNumber.Text = Account.AccountNumber.ToString();
                DisplayBalanceBefore.Text = clsUtility.FormatNumberWithPeriods(Transactionrecord.BalanceBefore.ToString());
                DisplayBalanceNow.Text = clsUtility.FormatNumberWithPeriods(Transactionrecord.BalanceNow.ToString());
                DiplayLAstName.Text = Account.PersonInfo.LastName;
                DisplayFirstName.Text = Account.PersonInfo.FirstName;
                DisplayMAount.Text = clsUtility.FormatNumberWithPeriods(Transactionrecord.Amount.ToString());
                DisplayTransactionType.Text = Transactionrecord.TransactionType;

                if (Transactionrecord.TransferID != -1)
                    BTN_TransferDetails.Show();
                else
                    BTN_TransferDetails.Hide();
            }
            else
            {
                TransactionID.Text = Transactionrecord.TransactionID.ToString();
                DisplayAccountNumber.Text = Transactionrecord.AccountNumber.ToString();
                DisplayBalanceBefore.Text = clsUtility.FormatNumberWithPeriods(Transactionrecord.BalanceBefore.ToString());
                DisplayBalanceNow.Text = clsUtility.FormatNumberWithPeriods(Transactionrecord.BalanceNow.ToString());
                DiplayLAstName.Text = "Deleted Account..!";
                DisplayFirstName.Text = "Deleted Account..!";
                DisplayMAount.Text = clsUtility.FormatNumberWithPeriods(Transactionrecord.Amount.ToString());
                DisplayTransactionType.Text = Transactionrecord.TransactionType;
            }

        }

        private void BTN_TransferDetails_Click(object sender, EventArgs e)
        {
            clsTransfersList list = new clsTransfersList();


            list.ShowOnlyOneRecord(Transactionrecord.TransferID);
            list.Height = 271;
            list.ShowDialog();
        }
    }
}
