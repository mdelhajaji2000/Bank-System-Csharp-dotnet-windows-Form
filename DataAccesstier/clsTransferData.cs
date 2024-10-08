﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesstier
{
    public static class clsTransferData
    {
        public static DataTable GetAllTransferRecords()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Transfers";

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

        public static bool InsertTransferRecord(int AccountNumberFrom, int AccountNumberTo, int Amount, long AccFrom_BalanceBefore, long AccFrom_BalanceNow
           , long AccTo_BalanceBefore, long Acc_ToBalanceNow )
        {
            bool IsPereformed = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Insert into Transfers (AccNumberFrom, AccNumberTo, Amount) Values (@AccNumberFrom, @AccNumberTo, @Amount); " +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@AccNumberFrom", AccountNumberFrom);
            command.Parameters.AddWithValue("@AccNumberTo", AccountNumberTo);

            int TransferID = -1;

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int intResult))
                {
                    TransferID = intResult;
                    clsTransactionsData.AddNewRecord(AccountNumberFrom, Amount, AccFrom_BalanceBefore, AccFrom_BalanceNow, TransferID, 3);
                    clsTransactionsData.AddNewRecord(AccountNumberTo, Amount, Acc_ToBalanceNow, AccTo_BalanceBefore, TransferID, 3);

                    IsPereformed = intResult != -1;
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

            return IsPereformed;
        }

        public static bool GetTransferRecordByTransferId(int TransferID, ref int Amount, ref int AccountNumberFrom, ref int AccountNumberTo)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * from Transfers Where TransferID = @TransferID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TransferID", TransferID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Amount = (int)reader["Amount"];
                    AccountNumberFrom = (int)reader["AccNumberFrom"];
                    AccountNumberTo = (int)reader["AccNumberTo"];

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

        public static DataTable GetAllTransfersPerAccountByAccountNumber(int AccountNumber)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * From Transfers Where AccNumberFrom  = @AccountNumber OR AccNumberTo = @AccountNumber";

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

        public static DataTable GetTransfersPerAccountFromByAccNumber(int AccountNumber)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * From Transfers Where AccNumberFrom  = @AccountNumber";

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

        public static DataTable GetTransfersPerAccountToByAccNumber(int AccountNumber)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * From Transfers Where AccNumberTo = @AccountNumber";

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
