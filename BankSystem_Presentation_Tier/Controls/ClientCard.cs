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
    public partial class ClientCard : UserControl
    {
        private clsClientAccount _Client;

        public ClientCard()
        {
            InitializeComponent();
            int AccountNumber = -1;

            _Client = clsClientAccount.Find(AccountNumber);
            
        }

        private void ClientCard_Load(object sender, EventArgs e)
        {
            if (_Client != null)
            {
                LB_FirstName.Text = _Client.PersonInfo.FirstName;
                LB_LastName.Text = _Client.PersonInfo.LastName;
                LB_Email.Text = _Client.PersonInfo.Email;
                LB_Balance.Text = _Client.Balance.ToString();
                LB_CreationDate.Text = _Client.CreationDate.ToString();

                if (_Client.ActivationStatus)
                {
                    LB_ActivationStatus.Text = "Active";
                    LB_ActivationStatus.ForeColor = Color.Green;
                }
                else
                {
                    LB_ActivationStatus.Text = "InActive";
                    LB_ActivationStatus.ForeColor = Color.Red;
                }
            }
        }
    }
}
