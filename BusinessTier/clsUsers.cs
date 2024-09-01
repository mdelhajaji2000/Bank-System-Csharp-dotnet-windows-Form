using BankSystemDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsUsers
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permessions { get; set; }
        public int PersonID { get; set; }

        public bool IsCurrent = false;

        public clsPerson PersonInfo;

        enum enMode { AddNew, Update}

        private enMode _Mode = enMode.AddNew;

        public clsUsers()
        {
            UserID = -1;
            UserName = "";
            Password = "";
            Permessions = 0;
            PersonID = -1;

            _Mode = enMode.AddNew;
        }

        private clsUsers(int UserID, string UserName, string Password, int Permessions, int PersonID)
        {
            this.UserName = UserName;
            this.UserID = UserID;
            this.Password = Password;
            this.Permessions = Permessions;
            this.PersonID = PersonID;
            Console.WriteLine("person ID : " + PersonID);
            this.PersonInfo = clsPerson.Find(PersonID);
            Console.WriteLine(this.PersonInfo.FirstName);
            _Mode = enMode.Update;
        }

        public static clsUsers Find(string UserName)
        {
            string Password = "";
            int UserID = -1;
            int Permessions = 0;
            int PersonId = -1;

            if (clsUsersData.GetUserByUserName(UserName, ref UserID, ref Password, ref Permessions, ref PersonId))
            {
                return new clsUsers(UserID, UserName, Password, Permessions, PersonId);
            }
            else
                return null;
        }

        public static clsUsers Find(int UserID)
        {
            string Password = "";
            string UserName = "";
            int Permessions = 0;
            int PersonId = -1;

            if (clsUsersData.GetUserByUserID(UserID, ref UserName, ref Password, ref Permessions, ref PersonId))
            {
                return new clsUsers(UserID, UserName, Password, Permessions, PersonId);
            }
            else
                return null;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUsersData.AddUser(this.UserName, this.Password, this.PersonID, this.Permessions);

            return UserID > 0;
        }

        private bool _UpdateUser()
        {
            return clsUsersData.UpdateUser(this.UserID , this.UserName, this.Password, this.Permessions);
        }

        public void Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    _AddNewUser();
                    _Mode = enMode.Update;

                    break;
                case enMode.Update:

                    _UpdateUser();

                    break;
            }

        }

        public static clsUsers CheckLogInInfo(string UserName, string Password)
        {
            clsUsers User = clsUsers.Find(UserName);

            if (User != null && Password == User.Password)
            {
                return User;
            }

            return null;
        }

        public static bool DeleteUser(string UserName)
        {
            return clsUsersData.DeletUser(UserName);
        }

        public static DataTable GetAllUers()
        {
            return clsUsersData.GetAllUsers();
        }

        public static bool IsUserExist(string userName)
        {
            return clsUsersData.IsUserExist(userName);
        }

        public static bool IsUserExist(int userId)
        {
            return clsUsersData.IsUserExist(userId);
        }


         // Chek if the user info are validate to insert him or add him in the data Base
        public bool IsinfoValidate()
        {
            if (clsUsers.IsUserExist(this.UserName))
                return false;
            else if (this.PersonInfo.Phone.Length > 24)
                return false;
            else
                return true;
        }
    }
}
