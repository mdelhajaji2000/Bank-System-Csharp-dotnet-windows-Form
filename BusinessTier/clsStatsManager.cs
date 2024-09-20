using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{ 
    public class clsStatsManager
    {
        public static int CallGetTotaleNumberOfAccounts()
        {
            return clsStatsData.GetTotaleNumberOfAccounts();
        }

        public static long CallGetTotaleBalances()
        {
            return clsStatsData.GetTotaleBalances();
        }

        public static long CallGetTotaleBalanceOfTransfers()
        {
            return clsStatsData.GetTotaleBalanceOfTransfers();
        }

        public static long CallGetTotaleBalancesOfTransactions()
        {
            return clsStatsData.GetTotaleBalancesOfTransactions();
        }

        public static int CallGetNumberOfDepositTransactions()
        {
            return clsStatsData.GetNumberOfDepositTransactions();
        }

        public static int CallGetNumberOFWithDrawtransactions()
        {
            return clsStatsData.GetNumberOFWithDrawtransactions();
        }

        public static int CallGetNumberOfTransfersTransactions()
        {
            int result = clsStatsData.GetNumberOfTransfersTransactions();
            return result;
        }

        public static long CallGetTotaleDepositAmount()
        {
            long result = clsStatsData.GetTotaleDepositAmount();
            return result;
        }
    }
}
