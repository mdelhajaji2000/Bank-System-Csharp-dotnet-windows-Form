using DataAccesstier;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessTier
{
    public static class clsStatsData
    {
        public static int GetTotaleNumberOfAccounts()
        {
            int AccountsCount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select Count(AccountNumber) From Accounts";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int intResult))
                {
                    AccountsCount = intResult;
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

            return AccountsCount;
        }

        public static long GetTotaleBalances()
        {
            long stat = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select Sum(cast(Balance as BIGINT)) From Accounts";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && long.TryParse(result.ToString(), out long intResult))
                {
                    stat = intResult;
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

            return stat;
        }

        public static long GetTotaleBalanceOfTransfers()
        {
            long stat = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT Sum(cast(Amount as BIGINT)) From Transfers";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && long.TryParse(result.ToString(), out long intResult))
                {
                    stat = intResult;
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

            return stat;
        }

        //Include Transfers
        public static long GetTotaleBalancesOfTransactions()
        {
            long stat = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT sum(cast(Amount as BIGINT)) from transactions";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && long.TryParse(result.ToString(), out long intResult))
                {
                    stat = intResult;
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

            return stat;
        }

        public static int GetNumberOfDepositTransactions()
        {
            int stat = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select count(Amount) from transactions where transactionType = 1";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int intResult))
                {
                    stat = intResult;
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

            return stat;
        }

        public static int GetNumberOFWithDrawtransactions()
        {
            int stat = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select count(Amount) from transactions where transactionType = 2";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int intResult))
                {
                    stat = intResult;
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

            return stat;
        }

        public static int GetNumberOfTransfersTransactions()
        {
            int stat = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select count(Amount) from transactions where transferID is not null";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int intResult))
                {
                    stat = intResult;
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

            return stat;
        }

        public static long GetTotaleDepositAmount()
        {
            long stat = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select SUM(CAST(Amount AS BIGINT)) from transactions where transactionType = 1";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && long.TryParse(result.ToString(), out long intResult))
                {
                    stat = intResult;
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

            return stat;
        }

    }
}
