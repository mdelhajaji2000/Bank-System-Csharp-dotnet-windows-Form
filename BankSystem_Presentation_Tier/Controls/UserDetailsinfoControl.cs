using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_Presentation_Tier.Controls
{
    public partial class UserDetailsinfoControl : UserControl
    {
        public UserDetailsinfoControl()
        {
            InitializeComponent();
        }

        public clsUsers User;

        public void Fillinfo()
        {
            userInfo1.UserID = User.UserID;
            userInfo1.FillData();

            PersonInfo1._Person = User.PersonInfo;
            PersonInfo1.FillpersonInfo();
        }
    }
}
