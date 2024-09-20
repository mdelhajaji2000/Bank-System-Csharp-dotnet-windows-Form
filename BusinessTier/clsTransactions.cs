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
        public long BalanceNow { get; set; }
        public long BalanceBefore { get; set; }
        public int TransferID { get; set; }
        public int Amount { get; set; }
        public string TransactionType { get; set; }

        private clsTransactions(int ID, int AccountNumber, long BalanceNow, long BalanceBefore, int Amount, int TransferID, string transactionType)
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
            long BNow = -1;
            long BBefore = -1;
            int Amount = -1;
            int TransferID = -1;
            string TransactionType = "";

            if (clsTransactionsData.GetTransactionRecordById(TransactionID, ref AccountNumber, ref Amount, ref BBefore, ref BNow, ref TransferID, ref TransactionType))
                return new clsTransactions(TransactionID, AccountNumber, BNow, BBefore, Amount, TransferID, TransactionType);
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
