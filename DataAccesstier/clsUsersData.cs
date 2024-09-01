using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.Remoting.Channels;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using DataAccesstier;

namespace BankSystemDataAccess
{
    public static class clsUsersData
    {
        public static bool GetUserByUserName(string UserName, ref int UserID, ref string Password, ref int Permessions, ref int PersonID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Users Where UserName = @UserName";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Password = (string)reader["Password"];
                    Permessions = (int)reader["Permessions"];
                    PersonID = (int)reader["PersonID"];
                    UserID = (int)reader["UserID"];
                    IsFound = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error in DB : " + ex);
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool GetUserByUserID(int UserID, ref string UserName, ref string Password, ref int Permessions, ref int PersonId)
        {
            bool ISFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Users Where UserID = @UserID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    Permessions = (int)reader["Permessions"];
                    PersonId = (int)reader["PersonID"];

                    ISFound = true;
                    reader.Close();
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

            return ISFound;
        }

        public static int AddUser(string UserName, string Password, int PersonId, int Permessions)
        {
            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Insert into Users (UserName, Password, Permessions, PersonID) " +
                "values " +
                "(@UserName, @Password, @Permessions, @PersonID);" +
                " Select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permessions", Permessions);
            command.Parameters.AddWithValue("@PersonID", PersonId);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int intResult))
                {
                    UserID = intResult;
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

            return UserID;
        }

        public static bool UpdateUser(int UserId, string UserName, string password, int Permessions)
        {
            int AffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Update Users SET " +
                "UserName = @UserName, " +
                "Password = @Password, " +
                "Permessions = @Permessions" +
                " Where UserID = @UserID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Permessions", Permessions);
            command.Parameters.AddWithValue("@UserID", UserId);

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

        public static bool DeletUser(string UserName)
        {
            bool IsDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "delete from Users Where UserName = @UserName";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                int AffectedRwos = 0;

                AffectedRwos = command.ExecuteNonQuery();

                IsDeleted = AffectedRwos > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return IsDeleted;
        }

        public static bool IsUserExist(int UserID)
        {
            bool ISExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select 1 from users Where UserID = @UserID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int intResult))
                {
                    ISExist = (intResult == 1);
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

            return ISExist;
        }

        public static bool IsUserExist(string UserName)
        {
            bool ISExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select 1 from users Where UserName = @UserName";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int intResult))
                {
                    ISExist = (intResult == 1);
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

            return ISExist;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "select * from Users";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
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

            return dt;

        }

        public static bool GetUserByUserNameAndPassword(string UserName, string Password, ref int Permessions, ref int PersonId, ref int UserID)
        {
            bool ISFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Selecte top(1) * from Users Where UserName = @userName and Password = @Password";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@userName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Permessions = (int)reader["Permessions"];
                    PersonId = (int)reader["PersonID"];
                    UserID = (int)reader["UserID"];

                    ISFound = true;
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

            return ISFound;
        }

    }

}
