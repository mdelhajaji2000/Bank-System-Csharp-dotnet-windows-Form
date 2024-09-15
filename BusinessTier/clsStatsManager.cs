using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    internal class clsStatsManager
    {
        public static int CallGetTotaleNumberOfAccounts()
        {
            return clsStatsData.GetTotaleNumberOfAccounts();
        }

        public static int CallGetTotaleBalances()
        {
            return clsStatsData.GetTotaleBalances();
        }

        public static int CallGetTotaleBalanceOfTransfers()
        {
            return clsStatsData.GetTotaleBalanceOfTransfers();
        }

        public static int CallGetTotaleBalancesOfTransactions()
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

        public static int CallGetTotaleDepositAmount()
        {
            int result = clsStatsData.GetTotaleDepositAmount();
            return result;
        }
    }
}
