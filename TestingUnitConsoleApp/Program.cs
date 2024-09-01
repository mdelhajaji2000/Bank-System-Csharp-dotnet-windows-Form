using BankSystemDataAccess;
using DataAccesstier;
using System;
using System.Collections.Generic;
using System.Data;                  // This Console App IS Just For Testing The DataAccess Functions
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingUnitConsoleApp
{
    internal class Program
    {

        static int UserID = -1;
        static string UserName = "";
        static string Password = "";
        static int Permessions = 0;
        static int PersonId = -1;

        static void PrintUser()
        {
            Console.WriteLine($"ID          : {UserID}");
            Console.WriteLine($"UserName    : {UserName}");
            Console.WriteLine($"PAssword    : {Password}");
            Console.WriteLine($"Permessions : {Permessions}");
            Console.WriteLine($"Contact ID  : {PersonId}");
        }

        static void TestingGetUserById(int ID)
        {


            if (clsUsersData.GetUserByUserID(ID, ref UserName, ref Password, ref Permessions, ref PersonId))
            {
                PrintUser();
            }
            else
            {
                Console.WriteLine("Error...!");
            }
        }

        static void TestingGetAllUsers()
        {
            DataTable dt = new DataTable();

            dt = clsUsersData.GetAllUsers();

            foreach (DataRow rwo in dt.Rows)
            {
                Console.WriteLine($"ID : {rwo["UserID"]}, User Name : {rwo["UserName"]}, Password : {rwo["Password"]}" +
                    $", Permessons : {rwo["Permessions"]}, Person Id : {rwo["PersonNationalID"]}");
            }
        }

        static void TestingAddUser()
        {
            UserName = "Hamada";
            Password = "223344";
            Permessions = 3;
            PersonId = 2;

            UserID = clsUsersData.AddUser(UserName, Password, PersonId, Permessions);

            TestingGetUserById(UserID);

        }

        static void TestingUpdatePerson()
        {
            int personID = 21; // Assume 1 is a valid ID in your database
            string firstName = string.Empty;
            string lastName = string.Empty;
            DateTime dateOfBirth = DateTime.Now;
            string address = string.Empty;
            int countryID = 0;
            string email = string.Empty;
            string phone = string.Empty;

            bool isFound = clsPersonData.GetPesonByNational_ID(personID, ref firstName, ref lastName,
                                                               ref dateOfBirth, ref address, ref countryID,
                                                               ref email, ref phone);

            firstName = "lolo";

            isFound = clsPersonData.UpdatePerson(personID, firstName, lastName,
                                                                address, email, phone,
                                                                countryID, dateOfBirth);

            if (isFound)
            {
                Console.WriteLine($"First Name: {firstName}");
                Console.WriteLine($"Last Name: {lastName}");
                Console.WriteLine($"Date of Birth: {dateOfBirth}");
                Console.WriteLine($"Address: {address}");
                Console.WriteLine($"Country ID: {countryID}");
                Console.WriteLine($"Email: {email}");
                Console.WriteLine($"Phone: {phone}");
            }
        }

        static void TestingDeleteUser()
        {
            if (clsUsersData.DeletUser("Hamada"))
            {
                Console.WriteLine("Hamada Was Deleted Succeessfuly");
            }
            else
            {
                Console.WriteLine("Errror");
            }
        }


        public static void TestGetPersonByNational_ID()
        {
            // Test Case 1: Valid PersonID
            int personID = 1; // Assume 1 is a valid ID in your database
            string firstName = string.Empty;
            string lastName = string.Empty;
            DateTime dateOfBirth = DateTime.Now;
            string address = string.Empty;
            int countryID = 0;
            string email = string.Empty;
            string phone = string.Empty;

            bool isFound = clsPersonData.GetPesonByNational_ID(personID, ref firstName, ref lastName,
                                                               ref dateOfBirth, ref address, ref countryID,
                                                               ref email, ref phone);

            Console.WriteLine($"Test Case 1: Valid PersonID");
            Console.WriteLine($"Is Found: {isFound}");
            if (isFound)
            {
                Console.WriteLine($"First Name: {firstName}");
                Console.WriteLine($"Last Name: {lastName}");
                Console.WriteLine($"Date of Birth: {dateOfBirth}");
                Console.WriteLine($"Address: {address}");
                Console.WriteLine($"Country ID: {countryID}");
                Console.WriteLine($"Email: {email}");
                Console.WriteLine($"Phone: {phone}");
            }

        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");

            //TestingGetUserById();
            //TestingGetAllUsers();

            //TestingAddUser();
            //TestingDeleteUser();

            //TestGetPersonByNational_ID();

            //int num = 5;
            //num |= 3;
            //num |= 6;
            //Console.WriteLine(-1 | 6);

            //TestingUpdatePerson();

            Console.WriteLine(52 & (1 << 0));
            Console.WriteLine(52 & (1 << 1));
            Console.WriteLine(52 & (1 << 2));

            Console.ReadKey();
        }
    }
}
