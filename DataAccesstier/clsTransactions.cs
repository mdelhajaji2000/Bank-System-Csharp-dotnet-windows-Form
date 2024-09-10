using System;
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
    public static class clsTransactions
    {
        public static DataTable GetAllTransactionsrecords()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * From Transactions";

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

        public static bool TransactionRecordById(int TransactionID, ref int AccountNumber, ref int Amount, ref int BalanceBefore, ref int BalanceNow, ref int TransferID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Transactions Where transactionID = @TransactionID";

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
                    BalanceBefore = (int)reader["BalanceBefore"];
                    BalanceNow = (int)reader["BalanceNow"];

                    if (reader["TransferID"] == System.DBNull.Value)
                        BalanceNow = -1;
                    else
                        TransferID = (int)reader["TransferID"];

                    IsFound = true;
                }

                IsFound = false;
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

        public static int AddNewRecord(int AccountNumber, int Amount, int BalanceBefore, int BalanceNow, int TransferID)
        {
            int RecordID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "INSERT INTO Transactions (AccountNumber, Amount, BalanceNow, BalanceBefore, TransferID) values " +
                "(@AccountNumber, @Amount, @BalanceNow, @BalanceBefore, @TransferID); " +
                "Select Scope_Identity(); ";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@BalanceNow", BalanceNow);
            command.Parameters.AddWithValue("@BalanceBefore", BalanceBefore);
            command.Parameters.AddWithValue("@TransferID", TransferID);

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
    }

}
