using BankSystem_Presentation_Tier.ClientsManagements.Forms;
using BankSystem_Presentation_Tier.Libraries;
using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_Presentation_Tier.Controls
{
    public partial class ClientMiniCard : UserControl
    {
        public clsClientAccount account = null; 

        public ClientMiniCard(int AccountNumber)
        {
            InitializeComponent();

            account = clsClientAccount.Find(AccountNumber);

            if (account != null)
            {
                LoadData();
            }
            else
                return;
        }

        private void LoadData()
        {
            DisplayAccountNumber.Text = account.AccountNumber.ToString();
            DisplayFullName.Text = account.PersonInfo.FirstName + " " + account.PersonInfo.LastName;
            DisplayBalance.Text = clsUtility.FormatNumberWithPeriods(account.Balance.ToString());
            
        }

        public delegate void DataBackEventHandler(bool removeClientCard);
        public event DataBackEventHandler RemoveCardEvent;

        private void SendData()
        {
            RemoveCardEvent(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindClientForm findForm = new FindClientForm();

            findForm.FillDataUsingParameter(account.AccountNumber);
            findForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SendData();
        }
    }
}
