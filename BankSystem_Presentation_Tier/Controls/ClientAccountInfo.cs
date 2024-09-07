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
    public partial class ClientAccountInfo : UserControl
    {
        public ClientAccountInfo()
        {
            InitializeComponent();
        }

        public void FillData(int AccountNumber)
        {
            clsClientAccount Account = clsClientAccount.Find(AccountNumber);

            if (Account != null)
            {
                LB_AccountNumber.Text = Account.AccountNumber.ToString();
                if (Account.ActivationStatus)
                {
                    LB_ActiveStatus.ForeColor = Color.Lime;
                    LB_ActiveStatus.Text = "Active";
                }
                else
                {
                    LB_ActiveStatus.ForeColor = Color.Red;
                    LB_ActiveStatus.Text = "Inactive";
                }
                LB_Balance.Text = Account.Balance.ToString();
                LB_CreationDate.Text = Account.CreationDate.ToString();
            }
        }
    }
}
