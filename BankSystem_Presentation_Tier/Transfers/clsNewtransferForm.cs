﻿using BankSystem_Presentation_Tier.ClientsManagements.Forms;
using BankSystem_Presentation_Tier.Controls;
using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_Presentation_Tier.Transfers
{
    public partial class clsNewtransferForm : Form
    {
        private int ChoisedAccNumber = -1;

        private clsClientAccount AccountFrom;
        private clsClientAccount AccountTo;

        private struct DataBack
        {
            public bool PerformAction;
            public int AccountNumber;
        }

        private DataBack returnedData = new DataBack();

        public clsNewtransferForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindAccount_ReturnedData(object sender, int AccountNumber, bool PerformAction)
        {
            returnedData.AccountNumber = AccountNumber;
            returnedData.PerformAction = PerformAction;
        }

        private void removeAccFromClientCard(bool Perform)
        {
            if (Perform)
            AccountFromContainer.Controls.Clear();
            SetClientFrom.Show();
            AccountFrom = null;
        }

        private void removeAccToClientCard(bool perform)
        {
            if (perform)
                AccountToContainer.Controls.Clear();
            SetClientTo.Show();
            AccountTo = null;
        }

        private void SetClientFrom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FindClientMiniForm frm = new FindClientMiniForm();

            frm.DataBack += FindAccount_ReturnedData;
            frm.ShowDialog();

            if (returnedData.PerformAction)
            {

                ClientMiniCard clientCard = new ClientMiniCard(returnedData.AccountNumber);
                clientCard.RemoveCardEvent += removeAccFromClientCard;

                if (ChoisedAccNumber == returnedData.AccountNumber)
                {
                    MessageBox.Show("You cannot transfer money to the same account..!");
                    return;
                }
                else
                    ChoisedAccNumber = returnedData.AccountNumber;


                SetClientFrom.Hide();

                AccountFromContainer.Controls.Add(clientCard);

                AccountFrom = clsClientAccount.Find(returnedData.AccountNumber);
            }
        }

        private void SetClientTo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FindClientMiniForm frm = new FindClientMiniForm();

            frm.DataBack += FindAccount_ReturnedData;
            frm.ShowDialog();

            if (returnedData.PerformAction)
            {

                ClientMiniCard clientCard = new ClientMiniCard(returnedData.AccountNumber);
                clientCard.RemoveCardEvent += removeAccToClientCard;

                if (ChoisedAccNumber == returnedData.AccountNumber)
                {
                    MessageBox.Show("You cannot transfer money to the same account..!");
                    return;
                }
                else
                    ChoisedAccNumber = returnedData.AccountNumber;

                SetClientTo.Hide();

                AccountToContainer.Controls.Add(clientCard);

                AccountTo = clsClientAccount.Find(returnedData.AccountNumber);
            }
        }

        private void BTN_Done_Click(object sender, EventArgs e)
        {
            if (AccountFrom == null && AccountTo == null)
                return;

            int Amount;

            if (int.TryParse(TB_Amount.Text, out int result))
                Amount = result;
            else
            {
                MessageBox.Show("Invalid Input...!");
                return;
            }

            if (AccountFrom.Balance < Amount)
            {
                MessageBox.Show("Account From Balance Is not Enought..!");
                return;
            }

            if (clsClientAccount.PerformTransfer(AccountFrom.AccountNumber, AccountTo.AccountNumber, Amount))
            {
                MessageBox.Show("Action Performed..!");
            }
            else
                MessageBox.Show("echec..!");


            TB_Amount.Clear();
            AccountFromContainer.Controls.Clear();
            AccountToContainer.Controls.Clear();
            AccountFrom = null;
            AccountTo = null;

            SetClientFrom.Show();
            SetClientTo.Show();
            
        }
    }
}
