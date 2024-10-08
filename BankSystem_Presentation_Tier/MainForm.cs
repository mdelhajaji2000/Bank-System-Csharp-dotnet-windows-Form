﻿using BankSystem_Presentation_Tier.ClientsManagements.Forms;
using BankSystem_Presentation_Tier.Controls;
using BankSystem_Presentation_Tier.Global;
using BankSystem_Presentation_Tier.Libraries;
using BankSystem_Presentation_Tier.LogIn;
using BankSystem_Presentation_Tier.LogInLog;
using BankSystem_Presentation_Tier.Transactions;
using BankSystem_Presentation_Tier.Transfers;
using BankSystem_Presentation_Tier.UsersManagement;
using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_Presentation_Tier
{
    public partial class MainForm : Form
    {
        private clsUsers SelectedUser;

        struct DataBackfromFindForm
        {
            public int AccountNumber;
            public bool PerformAction;
        }

        private DataBackfromFindForm ReturnedData = new DataBackfromFindForm();

        public MainForm()
        {
            InitializeComponent();
            this.Version.Text = clsGlobal.Version;

            LoadStatsData();
        }

        #region Users management Screen

        private void LoadUsersToTheContainer()
        {
            DataTable dtUsers = clsUsers.GetAllUers();

            int userId;

            foreach (DataRow row in dtUsers.Rows)
            {
                userId = (int)row["UserID"];

                UserCard userCard = new UserCard();
                userCard._User = clsUsers.Find(userId);
                userCard.OnUserSelected += userCard1_OnUserSelected;
                userCard.OnrefreshUsers += userCard1_OnrefreshUsers;
                UsersListContainer.Controls.Add(userCard);
            }
        }

        private void FillSelectedUserPersonInfo()
        {
            SPI_UserName.Text = SelectedUser.UserName;
            SPI_FirstName.Text = SelectedUser.PersonInfo.FirstName;
            SPI_LastName.Text = SelectedUser.PersonInfo.LastName;
            SPI_Email.Text = SelectedUser.PersonInfo.Email;
            SPI_Phone.Text = SelectedUser.PersonInfo.Phone;
            SPI_Country.Text = SelectedUser.PersonInfo.CountryInfo.CountryName;
            LB_UserID.Text = SelectedUser.UserID.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUsersToTheContainer();

            CurrentUserLabel.Text = clsGlobal.CurrentUser.UserName;
            CurrentUserPermessionLevel.Text = clsGlobal.CurrentUser.Permessions.ToString();
        }

        private void ChangeColor_Hover( Button btn)
        {
            btn.BackColor = Color.FromArgb(27, 31, 43);
        }

        private void ChangeColor_Leave( Button btn)
        {
            btn.BackColor = Color.FromArgb(37, 42, 61);
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            ChangeColor_Hover((Button)sender);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            ChangeColor_Leave((Button)sender);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            ChangeColor_Hover((Button)sender);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            ChangeColor_Leave((Button)sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.CurrentUser.Permessions & clsPermessions.ManageUsers) == clsPermessions.ManageUsers)
            {
                AcreenManagaeUsers.BringToFront();
                Pagetitle.Text = "Manage Users";
            }
            else
                MessageBox.Show("Action Denied, Contact Your Admin...!");

        }

        private void userCard1_OnUserSelected(int obj)
        {
            SelectedUser = clsUsers.Find(obj);

            FillSelectedUserPersonInfo();
        }

        private void userCard1_OnrefreshUsers(bool obj)
        {
            if (obj)
            {
                RefreshUsers();
            }
                CurrentUserLabel.Text = clsGlobal.CurrentUser.UserName;
                CurrentUserPermessionLevel.Text = clsGlobal.CurrentUser.Permessions.ToString();
        }

        private void RefreshUsers()
        {
            UsersListContainer.Controls.Clear();

            LoadUsersToTheContainer();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RefreshUsers();
        }

        #endregion

        #region Clients management Screen



        #endregion

        #region Stats Screen



        #endregion

        #region Transactions Screen



        #endregion

        #region ATM Service Screen



        #endregion

        #region Loan Management Screen



        #endregion

        private void button11_Click(object sender, EventArgs e)
        {
            EditAddnEwUserForm frm = new EditAddnEwUserForm();

            frm.ShowDialog();
            RefreshUsers();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            UsersManagement.clsFindUserForm FindUserForm = new UsersManagement.clsFindUserForm();

            FindUserForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.CurrentUser.Permessions & clsPermessions.ATNService) == clsPermessions.ATNService)
            {
                ScreenATMService.BringToFront();
                Pagetitle.Text = "ATM Service - Control Panel";
            }
            else
                MessageBox.Show("Action Denied, Contact Your Admin...!");
        }

        private void button9_Click(object sender, EventArgs e)  
        {
            Global.clsGlobal.CurrentUser = null;
            this.Hide();

            LogInForm LogIn = new LogInForm();
            LogIn.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Console.WriteLine("======= : " + clsShared.DLL_CurrentUser.UserName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.CurrentUser.Permessions & clsPermessions.ManageClients) == clsPermessions.ManageClients)
            {
                Pagetitle.Text = "Manage Clients";
                ScreenManageClients.BringToFront();
            }
            else
            {
                MessageBox.Show("PermessioDenied");
            }
        }

        private void BT_ClientList_Click(object sender, EventArgs e)
        {
            ClientsManagements.Forms.ClientsListForm clientsList = new ClientsManagements.Forms.ClientsListForm();

            clientsList.ShowAllClients();
            clientsList.ShowDialog();
        }

        private void BT_InactiveClients_Click(object sender, EventArgs e)
        {
            ClientsManagements.Forms.ClientsListForm clientsList = new ClientsManagements.Forms.ClientsListForm();
            clientsList.IsOnlyForInactiveAccounts = true;
            clientsList.ShowinactiveOnly();

            clientsList.ShowDialog();
        }

        private void BT_FindClient_Click(object sender, EventArgs e)
        {
            ClientsManagements.Forms.FindClientForm findClientForm = new ClientsManagements.Forms.FindClientForm();

            findClientForm.ShowDialog();
        }

        public void AddNewClientDialog()
        {
            AddNewUpdateClientAccount addnewclient = new AddNewUpdateClientAccount();

            addnewclient.ShowDialog();
        }

        private void BT_AddClient_Click(object sender, EventArgs e)
        {
            AddNewClientDialog();
        }

        private void BT_EditClient_Click(object sender, EventArgs e)
        {
            FindClientMiniForm findClient = new FindClientMiniForm();
            findClient.DataBack += FindClientForm_DataBack;

            findClient.ShowDialog();
            if (ReturnedData.PerformAction)
            {
                AddNewUpdateClientAccount fClient = new AddNewUpdateClientAccount(ReturnedData.AccountNumber);
                fClient.ShowDialog();
            }
        }

        private void FindClientForm_DataBack(object sender, int AccountNumber, bool PerformAction)
        {
            ReturnedData.AccountNumber = AccountNumber;
            ReturnedData.PerformAction = PerformAction;
        }

        private void BT_deleteClient_Click(object sender, EventArgs e)
        {
            FindClientMiniForm frmFind = new FindClientMiniForm();
            frmFind.DataBack += FindClientForm_DataBack;

            frmFind.ShowDialog();

            if (ReturnedData.PerformAction)
            {
                //FindClientForm frmFindForDeletefrom = new FindClientForm();

                //frmFindForDeletefrom.FillDataUsingParameter(ReturnedData.AccountNumber);
                //frmFindForDeletefrom.ShowForDelete();

                //frmFindForDeletefrom.ShowDialog();

                ///Summary
                /// I Change The Delete Function To Desactivate Cause The Transfers and transactions Tables
                /// in The Data Base Got Fireign Key To The Account So its impossible To Delete The Client Without Deliting Transaction/Transfer Records

                clsClientAccount account = clsClientAccount.Find(ReturnedData.AccountNumber);

                if (account.DesactivateAccount())
                    MessageBox.Show("Account Desactivated Successfuly...!");
                else
                    MessageBox.Show("Error : We Could Not Desactivate The Account...!");

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LogInLogsrecords frm = new LogInLogsrecords();

            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.CurrentUser.Permessions & clsPermessions.Transaction) == clsPermessions.Transaction)
            {
                Pagetitle.Text = "Transactions Management";
                ScreenTransaction.BringToFront();
            }
            else
            {
                MessageBox.Show("Action Denied, Contact Your Admin...!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.CurrentUser.Permessions & clsPermessions.StatsPage) == clsPermessions.StatsPage)
            {
                ScreenStatsPage.BringToFront();
                Pagetitle.Text = "Stats Page";
            }
            else
                MessageBox.Show("Action Denied, Contact Your Admin...!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.CurrentUser.Permessions & clsPermessions.LoanManagement) == clsPermessions.LoanManagement)
            {

            }
            else
                MessageBox.Show("Action Denied, Contact Your Admin");
        }

        private void BTN_Deposit_Click(object sender, EventArgs e)
        {
            FindClientMiniForm findfrm = new FindClientMiniForm();

            findfrm.DataBack += FindClientForm_DataBack;

            findfrm.ShowDialog();

            if (ReturnedData.PerformAction)
            {
                DepositFrom depositFrom = new DepositFrom(ReturnedData.AccountNumber, '+');
                depositFrom.ShowDialog();
            }
            else
                MessageBox.Show("Error");
        }

        private void BTN_WithDraw_Click(object sender, EventArgs e)
        {
            FindClientMiniForm findfrm = new FindClientMiniForm();

            findfrm.DataBack += FindClientForm_DataBack;
            findfrm.ShowDialog();


            if (ReturnedData.PerformAction)
            {
                DepositFrom depositFrom = new DepositFrom(ReturnedData.AccountNumber, '-');

                depositFrom.ShowDialog();
            }
            else
                MessageBox.Show("Error");
        }

        private void BTN_QuickTransactions_Click(object sender, EventArgs e)
        {
            FindClientMiniForm find = new FindClientMiniForm();

            find.DataBack += FindClientForm_DataBack;

            find.ShowDialog();

            if (ReturnedData.PerformAction)
            {
                QuickTransactionsForm form = new QuickTransactionsForm(ReturnedData.AccountNumber);

                form.ShowDialog();
            }
        }

        private void BTN_Transfer_Click(object sender, EventArgs e)
        {
            clsTransferMainMenu frm = new clsTransferMainMenu();

            frm.ShowDialog();
        }

        private void BTN_TransactionsLog_Click(object sender, EventArgs e)
        {
            clsTransactionsListForm frm = new clsTransactionsListForm();

            frm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool MenuExpand = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MenuExpand)
            {

                SideBar.Width += 50;
                foreach (Control ctr in SideBar.Controls)
                {
                    ctr.Width += 50;
                }
                foreach (Control ctr in SideBar.Controls)
                {
                    ctr.Text = ctr.Tag.ToString();
                }
                if (SideBar.Width >= 311)
                {
                    timer1.Stop();
                    MenuExpand = false;
                }

            }
            else
            {
                SideBar.Width -= 50;
                foreach (Control ctr in SideBar.Controls)
                {
                    ctr.Width -= 50;
                    ctr.Text = "";
                }
                if (SideBar.Width <= 82)
                {
                    timer1.Stop();
                    MenuExpand = true;


                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        #region Stats

        private void LoadStatsData()
        {
            Display_CountActifClients.Text = clsStatsManager.CallGetTotaleNumberOfAccounts().ToString();
            Display_CountTransfers.Text = clsStatsManager.CallGetNumberOfTransfersTransactions().ToString();
            Display_Count_Transactions.Text = (clsStatsManager.CallGetNumberOfDepositTransactions() + clsStatsManager.CallGetNumberOFWithDrawtransactions() + clsStatsManager.CallGetNumberOfTransfersTransactions()).ToString();
            Display_TotaleAmounts.Text = clsUtility.FormatLongNumberWithPeriods(clsStatsManager.CallGetTotaleBalances().ToString());
            Display_TotaleAmounts_Transactions.Text = clsUtility.FormatLongNumberWithPeriods(clsStatsManager.CallGetTotaleBalancesOfTransactions().ToString());
            Display_totaleAmountTransfers.Text = clsUtility.FormatLongNumberWithPeriods(clsStatsManager.CallGetTotaleBalanceOfTransfers().ToString());
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            LoadStatsData();
        }

        #endregion

        private void button18_Click(object sender, EventArgs e)
        {
            clsDataGeneratorBogus.GenerateClientsAccounts();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            ATM_Service_Control_Panel.clsCreateNewCardForm frm = new ATM_Service_Control_Panel.clsCreateNewCardForm();

            frm.ShowDialog();
        }
    }
}
