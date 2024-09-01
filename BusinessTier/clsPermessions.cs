using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public static class clsPermessions
    {
        public const int None = 0;
        public const int ManageClients = 1 << 0;
        public const int Transaction = 1 << 1;
        public const int StatsPage = 1 << 2;
        public const int ManageUsers = 1 << 3;
        public const int ATNService = 1 << 4;
        public const int LoanManagement = 1 << 5;
        public const int Admin = -1; // All Permesssions
    }
}
