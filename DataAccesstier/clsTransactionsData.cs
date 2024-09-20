using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesstier
{
    public static class clsTransactionsData
    {
        public static DataTable GetAllTransactionsrecords()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT        transactions.TransactionID, transactions.Amount, transactions.BalanceBefore, transactions.BalanceNow, transactions.transferID, transactions.AccountNumber, TransactionType.TransactionTypeName" +
                "\r\nFROM            TransactionType INNER JOIN" +
                "\r\n                         transactions ON TransactionType.ID = transactions.TransactionType;";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

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

            return dt; 
        }

        public static bool GetTransactionRecordById(int TransactionID, ref int AccountNumber, ref int Amount, ref long BalanceBefore, ref long BalanceNow, ref int TransferID, ref string TransactionType)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT        transactions.TransactionID, transactions.Amount, transactions.BalanceBefore, transactions.BalanceNow, transactions.transferID, transactions.AccountNumber, TransactionType.TransactionTypeName" +
                "\r\nFROM            TransactionType INNER JOIN" +
                "\r\n                         transactions ON TransactionType.ID = transactions.TransactionType " +
                "Where TransactionID = @TransactionID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TransactionID", TransactionID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    AccountNumber = (int)reader["AccountNumber"];
                    Amount = (int)reader["Amount"];
                    BalanceBefore = (long)reader["BalanceBefore"];
                    BalanceNow = (long)reader["BalanceNow"];
                    TransactionType = (string)reader["TransactionTypeName"];

                    if (reader["TransferID"] == System.DBNull.Value)
                        TransferID = -1;
                    else
                        TransferID = (int)reader["TransferID"];

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

        public static bool ClearAllRecords()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Delete From Transactions Where 1 = 1;" +
                " Delete From Transfers Where 1 = 1"; // Delete Transfers Also Cause transfer is A transaction Action

            SqlCommand command = new SqlCommand(Query, connection);

            int AffectedRows = -1;

            try
            {
                connection.Open();

                AffectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error + " + ex);
            }
            finally
            {
                connection.Close();
            }

            return (AffectedRows > 0);
        }

        public static int AddNewRecord(int AccountNumber, int Amount, long BalanceBefore, long BalanceNow, int TransferID, int TransactionType)
        {
            int RecordID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "INSERT INTO Transactions (AccountNumber, Amount, BalanceNow, BalanceBefore, TransferID, TransactionType) values " +
                "(@AccountNumber, @Amount, @BalanceNow, @BalanceBefore, @TransferID, @TransactionType); " +
                "Select Scope_Identity(); ";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@BalanceNow", BalanceNow);
            command.Parameters.AddWithValue("@BalanceBefore", BalanceBefore);
            command.Parameters.AddWithValue("@TransferID", TransferID);
            command.Parameters.AddWithValue("@TransactionType", TransactionType);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int intResult))
                    RecordID = intResult;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return RecordID;
        }

        public static void InsertDeposit(int AccountNumber, long Amount, long BalanceBefore, long BalanceNow)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "insert into Transactions (AccountNumber, Amount, BalanceNow, BalanceBefore, TransferID, TransactionType) " +
                "values " +
                "(@AccountNumber, @Amount, @BalanceNow, @BalanceBefore, @TransferID, @TransactionType)";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@BalanceNow", BalanceNow);
            command.Parameters.AddWithValue("@BalanceBefore", BalanceBefore);
            command.Parameters.AddWithValue("@TransferID", System.DBNull.Value);
            command.Parameters.AddWithValue("@TransactionType", 1);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void InsertWithDraw(int AccountNumber, int Amount, long BalanceBefore, long BalanceNow)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "insert into Transactions (AccountNumber, Amount, BalanceNow, BalanceBefore, TransferID, TransactionType) " +
                "values " +
                "(@AccountNumber, @Amount, @BalanceNow, @BalanceBefore, @TransferID, @TransactionType)";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@BalanceNow", BalanceNow);
            command.Parameters.AddWithValue("@BalanceBefore", BalanceBefore);
            command.Parameters.AddWithValue("@TransferID", System.DBNull.Value);
            command.Parameters.AddWithValue("@TransactionType", 2);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public static DataTable GetTransactionsPerAccountByAccounNumber(int AccountNumber)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT        transactions.TransactionID, transactions.Amount, transactions.BalanceBefore, transactions.BalanceNow, transactions.transferID, transactions.AccountNumber, TransactionType.TransactionTypeName" +
                "\r\nFROM            TransactionType INNER JOIN" +
                "\r\n                         transactions ON TransactionType.ID = transactions.TransactionType Where AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);
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

    }

}
