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
            FillClientsContainer();
        }

        private Color color1 = Color.FromArgb(27, 31, 49);
        private Color color2 = Color.FromArgb(27, 31, 43);

        static int colorChanger = 0;
        private void FillClientsContainer()
        {
            DataTable dtCllientsAccounts = clsClientAccount.GetAllClientsAccounts();

            foreach(DataRow row in dtCllientsAccounts.Rows)
            {
                ClientCard clientcard = new ClientCard((int)row["AccountNumber"]);
                ClientsContainer.Controls.Add(clientcard);

                if (colorChanger % 2 == 0)
                    clientcard.BackColor = color1;
                else
                    clientcard.BackColor = color2;

                colorChanger++;
            }
        }
    }
}
