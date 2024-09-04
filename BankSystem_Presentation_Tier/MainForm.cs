using BankSystem_Presentation_Tier.Controls;
using BankSystem_Presentation_Tier.Global;
using BankSystem_Presentation_Tier.LogIn;
using BankSystem_Presentation_Tier.UsersManagement;
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

namespace BankSystem_Presentation_Tier
{
    public partial class MainForm : Form
    {
        private clsUsers SelectedUser;
        public MainForm()
        {
            InitializeComponent();
            
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
            AcreenManagaeUsers.BringToFront();
            Pagetitle.Text = "Manage Users";
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
            Pagetitle.Text = "Manage Clients";
            ScreenManageClients.BringToFront();
        }
    }
}
