using DataAccesstier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsTransactions
    {
        public int TransactionID { get; set; }
        public int AccountNumber { get; set; }
        public int BalanceNow { get; set; }
        public int BalanceBefore { get; set; }
        public int TransferID { get; set; }
        public int Amount { get; set; }
        public string TransactionType { get; set; }

        private clsTransactions(int ID, int AccountNumber, int BalanceNow, int BalanceBefore, int Amount, int TransferID, string transactionType)
        {
            this.TransactionID = ID;
            this.AccountNumber = AccountNumber;
            this.BalanceNow = BalanceNow;
            this.BalanceBefore = BalanceBefore;
            this.Amount = Amount;
            this.TransferID = TransferID;
            this.TransactionType = transactionType;
        }

        public static clsTransactions Find(int TransactionID)
        {
            int AccountNumber = -1;
            int BalanceNow = -1;
            int BalanceBefore = -1;
            int Amount = -1;
            int TransferID = -1;
            string TransactionType = "";

            if (clsTransactionsData.GetTransactionRecordById(TransactionID, ref AccountNumber, ref Amount, ref BalanceBefore, ref BalanceNow, ref TransferID, ref TransactionType))
                return new clsTransactions(TransactionID, AccountNumber, BalanceNow, BalanceBefore, Amount, TransferID, TransactionType);
            else
                return null;
        }

        public static DataTable GetAllTransactionsRecords()
        {
            return clsTransactionsData.GetAllTransactionsrecords();
        }

        public static DataTable GetTransactionsPerAccountByAccNumber(int AccountNumber)
        {
            return clsTransactionsData.GetTransactionsPerAccountByAccounNumber(AccountNumber);
        }

    }
}
