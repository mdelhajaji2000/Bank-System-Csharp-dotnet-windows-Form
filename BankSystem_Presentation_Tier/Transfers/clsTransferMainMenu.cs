using BankSystem_Presentation_Tier.ClientsManagements.Forms;
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

namespace BankSystem_Presentation_Tier.Transfers
{
    public partial class clsTransferMainMenu : Form
    {
        private struct dataBack
        {
            public int AccountNumber;
            public bool PerformAction;
        }

        private dataBack ReturnedData = new dataBack();

        public clsTransferMainMenu()
        {
            InitializeComponent();
        }

        private void BTN_Newtransfer_Click(object sender, EventArgs e)
        {
            clsNewtransferForm frm = new clsNewtransferForm();

            frm.ShowDialog();
        }

        private void BTN_TransferLog_Click(object sender, EventArgs e)
        {
            Transfers.clsTransfersList frm = new clsTransfersList();

            frm.ShowDialog();
        }

        private void ReturnedDataFromFindForm(object sender , int AccountNumber, bool PerformAction)
        {
            ReturnedData.AccountNumber = AccountNumber;
            ReturnedData.PerformAction = PerformAction;
        }

        private void BTN_Findtransfers_Click(object sender, EventArgs e)
        {
            FindClientMiniForm frm = new FindClientMiniForm();

            frm.DataBack += ReturnedDataFromFindForm;
            frm.ShowDialog();

            if (ReturnedData.PerformAction)
            {
                Transfers.clsTransfersList TransfersList = new clsTransfersList(ReturnedData.AccountNumber);

                TransfersList.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
