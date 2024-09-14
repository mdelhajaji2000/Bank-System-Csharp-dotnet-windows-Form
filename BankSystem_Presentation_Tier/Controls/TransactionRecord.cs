using BankSystem_Presentation_Tier.Libraries;
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

namespace BankSystem_Presentation_Tier.Controls
{
    public partial class TransactionRecord : UserControl
    {
        private clsTransactions Transactionrecord;
        private clsClientAccount Account;

        public TransactionRecord(int TransactionID)
        {
            InitializeComponent();

            Transactionrecord = clsTransactions.Find(TransactionID);
            Account = clsClientAccount.Find(Transactionrecord.AccountNumber);

            FillData();
        }

        private void FillData()
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

    }
}
