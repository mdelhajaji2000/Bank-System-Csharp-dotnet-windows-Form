using DataAccesstier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization;
using System.Security.Policy;
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

        public static clsClientAccount Find(int AccountNumber)
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

        public static DataTable GetAllClientsAccounts()
        {
            return ClientAccountData.GetAllAccounts();
        }

        public static DataTable GetInactivateAccounts()
        {
            return ClientAccountData.GetOnlyInactiveClientsAccounts();
        }

        public static clsClientAccount FindByPersonId(int PersonId)
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

        private bool _AddNewClient()
        {
            this.AccountNumber = ClientAccountData.AddNewClient(DateTime.Now, true, this.PersonID);

            return (this.AccountNumber != -1);
        }

        private bool _UpdateClient()
        {
            return ClientAccountData.UpdateClient(this.AccountNumber, this.Balance, this.ActivationStatus);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewClient())
                    {
                        this._Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:

                    if (_UpdateClient())
                    {
                        return true;
                    }
                    return false;

            }

            return false;
        }

        public static bool DeleteClient(int AccountNumber)
        {
            return ClientAccountData.DeleteClient(AccountNumber);
        }

        public bool DesactivateAccount()
        {
            return ClientAccountData.UpdateActivationStatus(this.AccountNumber, false);
        }

        public bool ActivateAccount()
        {
            return ClientAccountData.UpdateActivationStatus(this.AccountNumber, true);
        }

        public static bool IsclientExist(int AccountNumber)
        {
            return ClientAccountData.IsAccountExist(AccountNumber);
        }

        //======================== Those Two Functions Should Store transactions Recordes in The DataBase ======================

        public bool AddAmountToBalance(int Amount)
        {
            if (Amount > 0)
                return ClientAccountData.UpdateBalance(this.AccountNumber, Amount);
            else
                return false;
        }

        public bool increaseAmountFromBalance(int Amount)
        {
            if (Amount > 0)
                return ClientAccountData.UpdateBalance(this.AccountNumber, Amount);
            else
                return false;
        }

        //======================================================================================================================

    }
}
