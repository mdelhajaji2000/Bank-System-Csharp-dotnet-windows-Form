using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_Presentation_Tier.Controls
{
    

    public partial class UserDataReader : UserControl
    {
        public UserDataReader()
        {
            InitializeComponent();
        }

        clsUsers User = new clsUsers();

        /// <summary>
        /// Take The Checked Elemets in the chekedGroupBox Comtrol and 
        /// return a int Permessions that store the permession in only one number using the betwise operators
        /// </summary>
        /// <returns Permession Value ></returns>
        private int PermesionsReader()
        {
            int Permessions = 0;

            foreach (int index in checkedListBox1.CheckedIndices)
            {
                Permessions |= 1 << index;
            }

            return Permessions;
        }

        public void FillData(int UserId)
        {
            clsUsers User = clsUsers.Find(UserId);

            TB_UserName.Text = User.UserName;
            TB_Password.Text = User.Password;
            TB_ReapetePassworde.Text = TB_Password.Text;
            DisplayUserID.Text = UserId.ToString();

            for (int index = 0; index < checkedListBox1.Items.Count; index++)
            {
                if ((User.Permessions & (1 << index)) != 0)
                {
                    checkedListBox1.SetItemChecked(index, true);
                }
                else
                {
                    checkedListBox1.SetItemChecked(index, false);
                }
            }


        }

        public clsUsers ReadUserDataForUpdate(int userId, ref bool Validation, ref string ErrorMessage)
        {
            string UserName = TB_UserName.Text;
            string Password;
            int Permession = PermesionsReader();

            Validation = false;

            clsUsers user = clsUsers.Find(userId);

            if (TB_Password.Text != TB_ReapetePassworde.Text)
            {
                Validation = false;
                ErrorMessage = "Password isnt The Same...!";
            }
            else
            {
                Password = TB_Password.Text;
                user.Password = Password;
                Validation = true;
            }

            user.UserName = UserName;
            user.Permessions = Permession;


            return user;
        }

        public clsUsers returnData(ref bool Validation, ref string ErrorMessage)
        {
            string UserName = TB_UserName.Text;
            string Password;
            int Permession = PermesionsReader();

            clsUsers user = new clsUsers();

            if (TB_Password.Text != TB_ReapetePassworde.Text)
            {
                Validation = false;
                ErrorMessage = "Password isnt The Same...!";
            }
            else
            {
                Password = TB_Password.Text;
                user.Password = Password;
            }

            user.UserName = UserName;
            user.Permessions = Permession;

            Validation = true;

            return user;
        }
    }
}
