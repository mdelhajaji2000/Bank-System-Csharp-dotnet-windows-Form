using BankSystem_Presentation_Tier.Controls;
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

namespace BankSystem_Presentation_Tier.ClientsManagements.Forms
{
    public partial class ClientsListForm : Form
    {
        public ClientsListForm()
        {
            InitializeComponent();
        }

        private void FillClientsContainer()
        {
            DataTable dtCllientsAccounts = clsClientAccount.GetAllClientsAccounts();

            foreach(DataRow row in dtCllientsAccounts.Rows)
            {
                ClientCard clientcard = new ClientCard((int)row["AccountNumber"]);
                ClientsContainer.Controls.Add(clientcard);
            }
        }
    }
}
