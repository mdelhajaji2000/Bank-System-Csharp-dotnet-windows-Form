using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesstier
{
    public static class ClientAccountData
    {
        public static bool GetClientAccountByAccountNumber(int AccountNumber, ref int Balance, ref DateTime CreationDate, ref bool IsActive, ref int PersonID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Accounts Where AccountNumber = @AccNumber";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@AccNum", AccountNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Balance = (int)reader["Balance"];
                    CreationDate = (DateTime)reader["CreationDate"];
                    IsActive = clsDataAccessSettings.intToBool((int)reader["ActiveStatus"]);
                    PersonID = (int)reader["PersonID"];

                    IsFound = true;
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

            return IsFound;
        }

        public static bool GetAccountByPersonID(int PersonID, ref int AccountNumber, ref int Balance, ref DateTime CreationDate, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Accounts Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Balance = (int)reader["Balance"];
                    CreationDate = (DateTime)reader["CreationDate"];
                    IsActive = clsDataAccessSettings.intToBool((int)reader["ActiveStatus"]);
                    PersonID = (int)reader["PersonID"];

                    IsFound = true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static DataTable GetAllAccounts()
        {
            DataTable dtAccounts = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Accounts";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtAccounts.Load(reader);
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


            return dtAccounts;
        }

        public static bool IsAccountExist(int AccountNumber)
        {
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select 1 from Accounts Where AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int intResult))
                {
                    IsExist = intResult == 1;
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

            return IsExist;
        }
    }
}
