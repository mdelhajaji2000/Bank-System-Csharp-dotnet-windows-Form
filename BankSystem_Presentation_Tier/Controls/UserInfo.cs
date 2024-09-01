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
    public partial class UserInfo : UserControl
    {

        public int UserID;

        private clsUsers _User;
        public UserInfo()
        {
            InitializeComponent();
        }

        public void FillData()
        {
            _User = clsUsers.Find(UserID);

            LB_UserName.Text = _User.UserName;
            LB_Password.Text = _User.Password;
            LB_Permessions.Text = _User.Permessions.ToString();
            LB_User_ID.Text = _User.UserID.ToString();
        }
    }
}
