using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesstier
{
    public static class clsPersonData
    {
        public static bool GetPesonByNational_ID(int PersonID, ref string FirstName
            , ref string LastName, ref DateTime DateofBirth, ref string Address, ref int CountryID,
             ref string Email, ref string Phone)
        {
            bool ISFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Persons Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Address = (string)reader["Address"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    DateofBirth = (DateTime)reader["DateOfbirth"];
                    CountryID = (int)reader["CountryID"];

                    ISFound = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return ISFound;
        }

        public static int AddNewPerson
        (
                string FirstName, string LastName,
                DateTime Dateofbirth, string Address,
                string Email, string Phone, int CountryID
        )
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Insert into Persons (FirstName, LastName, Address, Email, Phone , CountryID, DateOfBirth) " +
                " Values " +
                " (@FirstName, @LastName, @Address, @Email, @Phone, @CountryID, @DateOFBirth);" +
                " select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@DateOFBirth", Dateofbirth);

            int ID = -1;

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int intResult))
                    ID = intResult;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return ID;
        }

        public static bool UpdatePerson(int PersonID, string FirstName,
            string LastName, string Address, string Email, string Phone, int CountryID, DateTime DateOfBirth)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Update Persons " +
                "set " +
                " FirstName = @FirstName, " +
                " LastName = @LastName, " +
                " Email = @Email, " +
                " phone = @phone, " +
                " Address = @Address, " +
                " CountryID = @CountryID, " +
                " DateOfBirth = @DateOfBirth" +
                " Where PersonID = @PersonID ";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

            int AffectedRows = 0;

            try
            {
                connection.Open();

                AffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return AffectedRows > 0;
        }

        public static bool DeletePerson(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Delete From Persons Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@personID", PersonID);

            int AffectedRows = 0;

            try
            {
                connection.Close();

                AffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return AffectedRows > 0;
        }

        public static bool ISPersonexist(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select 1 From Persons Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            int FoundValue = 0;

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int intResult))
                    FoundValue = intResult;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return FoundValue == 1;
        }

        public static DataTable GetAllPerson()
        {
            DataTable dataTabe = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Persons";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTabe.Load(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return dataTabe;
        }
    }

}
