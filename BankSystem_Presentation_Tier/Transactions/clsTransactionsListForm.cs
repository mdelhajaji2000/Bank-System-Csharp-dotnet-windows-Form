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

namespace BankSystem_Presentation_Tier.Transactions
{
    public partial class clsTransactionsListForm : Form
    {
        public clsTransactionsListForm()
        {
            InitializeComponent();

            FillContainerWithrecords();
        }

        private void FillContainerWithrecords()
        {
            DataTable dt = clsTransactions.GetAllTransactionsRecords();

            foreach (DataRow row in dt.Rows)
            {
                TransactionRecord record = new TransactionRecord((int)row["TransactionID"]);
                RecordsContainer.Controls.Add(record);
            }
        }
    }
}
