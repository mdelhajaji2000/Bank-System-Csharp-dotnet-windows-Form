using DataAccesstier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsClientAccount
    {
        private enum enMode { AddNew, Update}

        private enMode _Mode = enMode.AddNew;

        public int Balance { get; set; }
        public bool ActivationStatus { get; set; }
        public int PersonID { get; set; }
        public int AccountNumber { get; private set; }
        public DateTime CreationDate { get; set; }

        public clsPerson PersonInfo { get; set; }

        private clsClientAccount(int AccountNumber, int Balance, bool ActivationStatus, DateTime CreationDate, int PersonID)
        {
            PersonInfo = clsPerson.Find(PersonID);

            this.AccountNumber = AccountNumber;
            this.ActivationStatus = ActivationStatus;
            this.CreationDate = CreationDate;
            this.Balance = Balance;
            this.PersonID = PersonID;

            this._Mode = enMode.Update;
        }

        public clsClientAccount()
        {
            this.AccountNumber = -1;
            this.Balance = -1;
            this.CreationDate = DateTime.Now;
            this.ActivationStatus = true;
            this.PersonID = -1;

            this._Mode = enMode.AddNew;
        }

        public clsClientAccount Find(int AccountNumber)
        {
            int Balance = 0;
            bool ActivationStatus = true;
            int PersonId = 0;
            DateTime CreationDate = DateTime.Now;

            if (ClientAccountData.GetClientAccountByAccountNumber(AccountNumber, ref Balance, ref CreationDate, ref ActivationStatus, ref PersonId))
                return new clsClientAccount(AccountNumber, Balance, ActivationStatus, CreationDate, PersonId);
            else
                return null;
        }

        public clsClientAccount FindByPersonId(int PersonId)
        {
            int Balance = 0;
            bool ActivationStatus = true;
            int AccountNumber = 0;
            DateTime CreationDate = DateTime.Now;

            if (ClientAccountData.GetAccountByPersonID(PersonId, ref AccountNumber, ref Balance, ref CreationDate, ref ActivationStatus))
                return new clsClientAccount(AccountNumber, Balance, ActivationStatus, CreationDate, PersonId);
            else
                return null;
        }

        public static bool IsPersonAClient(int PersonId)
        {
            return ClientAccountData.IsPersonHadAccount(PersonId);
        }
    }
}
