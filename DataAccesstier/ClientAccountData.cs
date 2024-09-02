using System;
using System.Data;
using System.Data.SqlClient;

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
                    AccountNumber = (int)reader["AccountNumber"];

                    IsFound = true;
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

        public static bool IsPersonHadAccount(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select 1 from Accounts Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            bool IsHadAccount = false;

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int intresult))
                {
                    IsHadAccount = (intresult == 1);
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

            return IsHadAccount;
        }

        public static int AddNewClient(DateTime CreationDate, bool ActiveStatus, int PersonId)
        {
            int NewClientID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "insert into Accounts values " +
                "(0, @CreationDate, @ActiveStatus, @PersonID); " +
                "select scope_Identity()";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@CreationDate", CreationDate);
            command.Parameters.AddWithValue("@ActiveStatus", clsDataAccessSettings.boolToByte(ActiveStatus));
            command.Parameters.AddWithValue("@PersonID", PersonId);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int intResult))
                {
                    NewClientID = intResult;
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

            return NewClientID;
        }

        public static bool UpdateClient(int AccountNumber, int Balance, bool ActiveStatus)
        {
            int AffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Update Accounts Set " +
                "Balance = @Balance, " +
                "ActiveStatus = @ActiveStatus " +
                "Where AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ActiveStatus", clsDataAccessSettings.boolToByte(ActiveStatus));
            command.Parameters.AddWithValue("@Balance", Balance);

            try
            {
                connection.Open();

                AffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return AffectedRows > 0;
        }

        public static bool UpdateBalance(int AccountNumber, int Balance)
        {
            int AffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "update Accounts Set " +
                "Balance = @Balance " +
                "Where AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Balance", Balance);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

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

        public static bool UpdateActivationStatus(int AccountNumber, bool ActivationStatus)
        {
            int Affectedrows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Update Accounts Set " +
                "ActivationStatus = @ActivationStatus " +
                " Where AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@ActivationStatus", ActivationStatus);

            try
            {
                connection.Open();

                Affectedrows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return Affectedrows == 1;
        }

        public static bool DeleteClient(int AccountNumber)
        {
            int AffectedRows = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Delete from Accounts Where AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

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
    }
}
