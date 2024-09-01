using BankSystemDataAccess;
using DataAccesstier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsPerson
    {
        enum enMode { AddNew, Update}
        private enMode _Mode = enMode.AddNew;

        public int PersonID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int CountryID { get; set; }
        public DateTime DateOfBirth { get; set; }

        public clsCountries CountryInfo;

        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Address = "";
            this.Email = "";
            this.Phone = "";
            this.CountryID = -1;
            this.DateOfBirth = DateTime.Now;

            this._Mode = enMode.AddNew;
        }

        private clsPerson(int PersonID, string FirstName, string LastName, string Address
            , string Email, string Phone, int CountryID, DateTime DateOfBirth)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.Email = Email;
            this.Phone = Phone;
            this.CountryID = CountryID;
            this.DateOfBirth = DateOfBirth;
            this.CountryInfo = clsCountries.Find(this.CountryID);

            this._Mode = enMode.Update;
        }

        public static clsPerson Find(int PersonID)
        {
            string FirstName = "";
            string LastName = "";
            string Address = "";
            string Email = "";
            string Phone = "";
            int CountryID = -1;
            DateTime DOB = DateTime.Now;

            if (clsPersonData.GetPesonByNational_ID(PersonID, ref FirstName, ref LastName, ref DOB, ref Address, ref CountryID, ref Email, ref Phone))
            {
                return new clsPerson(PersonID, FirstName, LastName, Address, Email, Phone, CountryID, DOB);
            }
            else
                return null;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson(this.FirstName, this.LastName, this.DateOfBirth, this.Address
                , this.Email, this.Phone, this.CountryID);

            return this.PersonID != -1;
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID, this.FirstName, this.LastName
                , this.Address, this.Email, this.Phone, this.CountryID, this.DateOfBirth);
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }

        public void Save()
        {

            switch (_Mode)
            {
                case enMode.AddNew:

                    _AddNewPerson();
                    this._Mode = enMode.Update;

                    break;
                case enMode.Update:

                    _UpdatePerson();

                    break;

            }


        }

        public static DataTable GetAllUsers()
        {
            return clsPersonData.GetAllPerson();
        }
        public bool Validation()
        {
            return !string.IsNullOrEmpty(this.FirstName) &&
                   !string.IsNullOrEmpty(this.LastName) &&
                   !string.IsNullOrEmpty(this.Address) &&
                   !string.IsNullOrEmpty(this.Email) &&
                   !string.IsNullOrEmpty(this.Phone) &&
                   this.DateOfBirth != DateTime.MinValue &&
                   this.CountryID != 0;        }

    }
}
