using DataAccesstier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsTransfers
    {
        public int transferID { get; set; }
        public int AccnumberFrom { get; set; }
        public int AccnumberTo { get; set; }
        public int Amount { get; set; }

        private clsTransfers(int transferID, int AccNumberFrom, int AccNumberTo, int Amount)
        {
            this.Amount = Amount;
            this.transferID = transferID;
            this.AccnumberFrom = AccnumberFrom;
            this.AccnumberTo = AccnumberTo;
        }

        public static clsTransfers Find(int transferID)
        {
            int Amount = -1;
            int AccnumberFrom = -1;
            int AccnumberTo = -1;

            if (clsTransferData.GetTransferRecordByTransferId(transferID, ref Amount, ref AccnumberFrom, ref AccnumberTo))
                return new clsTransfers(transferID, AccnumberFrom, AccnumberTo, Amount);
            else
                return null;
        }
    }
}
