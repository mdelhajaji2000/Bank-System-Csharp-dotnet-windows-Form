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

namespace BankSystem_Presentation_Tier.Transfers
{
    public partial class clsTransfersList : Form
    {
        private enum enMode { GetAll, SerachForAClientRecords }

        private enMode _Mode = enMode.GetAll;

        private int _AccountNumber = -1;

        private int num = 0;

        private Color color1 = Color.FromArgb(27, 31, 49);
        private Color color2 = Color.FromArgb(27, 31, 43);

        public clsTransfersList()
        {
            InitializeComponent();

            this._Mode = enMode.GetAll;

            switch (_Mode)
            {
                case enMode.GetAll:
                    FillRecordsToTable_WithAllRecords();
                    break;
                case enMode.SerachForAClientRecords:
                    FillWithRecordsForOnlyOneClient();
                    break;
            }
        }

        public clsTransfersList(int AccountNumber)
        {
            InitializeComponent();

            this._Mode = enMode.SerachForAClientRecords;

            _AccountNumber = AccountNumber;

            num = 0;
        }

        private void clsTransfersList_Load(object sender, EventArgs e)
        {

        }

        private void FillWithRecordsForOnlyOneClient()
        {

            DataTable dt = clsTransfers.GetAllTransferPerClient(_AccountNumber);

            foreach (DataRow row in dt.Rows)
            {
                TransferLogRecord record = new TransferLogRecord((int)row["TransferID"]);

                if (num % 2 == 0)
                    record.color = color1;
                else
                    record.color = color2;
                num++;

                TableBody.Controls.Add(record);
            }
        }

        private void FillRecordsToTable_WithAllRecords()
        {
            DataTable dt = clsTransfers.GetAllTransfersrecords();

            foreach (DataRow row in dt.Rows)
            {
                TransferLogRecord record = new TransferLogRecord((int)row["TransferID"]);

                if (num % 2 == 0)
                    record.color = color1;
                else
                    record.color = color2;

                num++;

                TableBody.Controls.Add(record);
            }
        }

        public void ShowOnlyOneRecord(int transferID)
        {
            TableBody.Controls.Clear();

            TransferLogRecord record = new TransferLogRecord(transferID);

            TableBody.Controls.Add(record);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
