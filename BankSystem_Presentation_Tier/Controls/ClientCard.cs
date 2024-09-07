using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_Presentation_Tier.Controls
{
    public partial class ClientCard : UserControl
    {
        private clsClientAccount _Client;

        public ClientCard(int AccountNumber)
        {
            InitializeComponent();

            _Client = clsClientAccount.Find(AccountNumber);
            
        }

        public event Action<int> onClientselected;

        protected virtual void ClientSelected(int AccountNumber)
        {
            Action<int> handler = onClientselected;

            if (handler != null)
                handler(AccountNumber);
        }

        public event Action<int> onDetailsbuttonClicked;

        protected virtual void DetailsbuttonClicked(int AccountNumber)
        {
            Action<int> Handler = onDetailsbuttonClicked;

            if (Handler != null)
                Handler(AccountNumber);
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
                LB_AccountNumber.Text = _Client.AccountNumber.ToString();
                if (_Client.ActivationStatus)
                {
                    LB_ActivationStatus.Text = "Active";
                    LB_ActivationStatus.ForeColor = Color.Lime;
                }
                else
                {
                    LB_ActivationStatus.Text = "InActive";
                    LB_ActivationStatus.ForeColor = Color.Red;
                }

                Random random = new Random();

                this.PB_ClientPictureAvatar.Image = imageList1.Images[random.Next(0, 8)];
            }
        }

        private void LB_AccountNumber_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                onClientselected(this._Client.AccountNumber);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            onDetailsbuttonClicked(this._Client.AccountNumber);
        }
    }
}
