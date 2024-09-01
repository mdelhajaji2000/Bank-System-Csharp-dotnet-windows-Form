using BankSystem_Presentation_Tier.Global;
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

namespace BankSystem_Presentation_Tier.Controls
{
    public partial class UserCard : UserControl
    {

        public clsUsers _User;
        public UserCard()
        {
            InitializeComponent();
        }

        public event Action<int> OnUserSelected;

        protected virtual void UserSelected(int UserID)
        {
            Action<int> handler = OnUserSelected;

            if (handler != null)
                handler(UserID);
        }

        public event Action<bool> OnrefreshUsers;

        protected virtual void refreshUsers(bool obj)
        {
            Action<bool> handler = OnrefreshUsers;

            if (handler != null)
                handler(obj);
        }

        private void SelecteEvent()
        {
            OnUserSelected(_User.UserID);
        }

        private void UserCard_Click(object sender, EventArgs e)
        {
            SelecteEvent();
        }

        private void UserCard_Load(object sender, EventArgs e)
        {
            UserName_Label.Text = _User.UserName;
            PermessionLabel.Text = _User.Permessions.ToString();

            if (this._User.UserID == clsGlobal.CurrentUser.UserID)
            {
                this._User.IsCurrent = true;
                CurrentLabel.Visible = true;
                btn_remove.Enabled = false;
                btn_remove.Hide();
            }
            else
            {
                CurrentLabel.Visible = false;
                this._User.IsCurrent = false;
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure You Want To Delete That User ?? ", "Confirm Delete Action", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            OnrefreshUsers(clsUsers.DeleteUser(this._User.UserName));
        }

        private void Btn_Details_Click(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            EditAddnEwUserForm form = new EditAddnEwUserForm(_User.UserID);

            form.ShowDialog();

            this._User = clsUsers.Find(this._User.UserID); // Refresh this Form User;

            if (this._User.UserID == clsGlobal.CurrentUser.UserID) // if the edited User is The Currnt this if condition will update it 
            {
                clsGlobal.CurrentUser = this._User;
            }
                OnrefreshUsers(true);

        }
    }
}
