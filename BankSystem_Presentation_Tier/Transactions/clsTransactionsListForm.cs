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

            FillContainerWithRecords();
        }

        private int lastShownRow = 0; // Initialize to 0 to start from the first record

        private void FillContainerWithRecords()
        {
            // Retrieve all transactions from the database
            DataTable dt = clsTransactions.GetAllTransactionsRecords();

            // If there are no more records to show, return early
            if (dt.Rows.Count == 0 || lastShownRow >= dt.Rows.Count)
            {
                btnLoadMore.Hide();
                return;
            }

            const int maxRecordsToShow = 30;

            // Calculate how many records can be shown without exceeding the DataTable bounds
            int recordsRemaining = dt.Rows.Count - lastShownRow;
            int recordsToShow = Math.Min(recordsRemaining, maxRecordsToShow);

            // Load records starting from lastShownRow
            for (int i = lastShownRow; i < lastShownRow + recordsToShow; i++)
            {
                int transactionId = (int)dt.Rows[i]["TransactionID"];
                TransactionRecord record = new TransactionRecord(transactionId);
                RecordsContainer.Controls.Add(record);
            }

            // Update lastShownRow to track the next batch of records
            lastShownRow += recordsToShow;

            // Optional: Disable or hide the "Load More" button if all records have been loaded
            if (lastShownRow >= dt.Rows.Count)
            {
                btnLoadMore.Enabled = false; // or hide it: btnLoadMore.Visible = false;
            }
        }


        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadMore_Click(object sender, EventArgs e)
        {
            FillContainerWithRecords();
        }
    }
}
