using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_Presentation_Tier.Transfers
{
    public partial class clsTransferMainMenu : Form
    {
        public clsTransferMainMenu()
        {
            InitializeComponent();
        }

        private void BTN_Newtransfer_Click(object sender, EventArgs e)
        {
            clsNewtransferForm frm = new clsNewtransferForm();

            frm.ShowDialog();
        }
    }
}
