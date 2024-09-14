using BankSystem_Presentation_Tier.Libraries;
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
    public partial class TransferLogRecord : UserControl
    {
        public Color color
        {
            set
            {
                this.BackColor = value;
            }
        }

        clsTransfers TransferRecord;

        clsClientAccount accFrom;
        clsClientAccount accTo;

        public TransferLogRecord(int TransaferID)
        {
            InitializeComponent();

            TransferRecord = clsTransfers.Find(TransaferID);

            accFrom = clsClientAccount.Find(TransferRecord.AccnumberFrom);
            accTo = clsClientAccount.Find(TransferRecord.AccnumberTo);

            FillData();
        }

        private void FillData()
        {
            // Transfer Data : 
            Display_TransferID.Text = TransferRecord.transferID.ToString();
            Display_transfer_Amount.Text = clsUtility.FormatNumberWithPeriods(TransferRecord.Amount.ToString());

            //Account From Data : 
            Display_AccFrom_AccountNumber.Text = accFrom.AccountNumber.ToString();
            Display_AccFrom_FirstName.Text = accFrom.PersonInfo.FirstName;
            Display_AccfromLastName.Text = accFrom.PersonInfo.FirstName;
            DisplayAccfromBalance.Text = clsUtility.FormatNumberWithPeriods(accFrom.Balance.ToString());

            //Account To Data : 
            Display_AccTo_AccountNumber.Text = accTo.AccountNumber.ToString();
            Display_AccTo_FirstName.Text = accTo.PersonInfo.FirstName;
            Display_AccTo_LastName.Text = accTo.PersonInfo.LastName;
            Display_AccTo_Balance.Text = clsUtility.FormatNumberWithPeriods(accTo.Balance.ToString());
        }
    }
}
