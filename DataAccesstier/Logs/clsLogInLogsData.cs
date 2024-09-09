using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesstier.Logs
{
    public static class clsLogInLogsData
    {
        public static DataTable GetAllLogin_LogRecords()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            //string Query = "Select * from LogInLogs";
            string Query = "SELECT        LogInLogs.ID, LogInLogs.Date, Users.UserName, Users.Password, Users.Permessions, Persons.FirstName, Persons.LastName, Countries.CountryName\r\nFROM" +
                "                         LogInLogs INNER JOIN\r\n" +
                "                         Users ON LogInLogs.UserID = Users.UserID INNER JOIN\r\n" +
                "                         Persons ON Users.PersonID = Persons.PersonID INNER JOIN\r\n" +
                "                         Countries ON Persons.CountryID = Countries.CountryID;";

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
                Console.WriteLine("Error " + ex);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static void AddRecord(int UserId, ref int ID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "insert into LogInLogs Values (@Date, @UserID);" +
                "select Scope_Identity();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@Date", DateTime.Now);
            command.Parameters.AddWithValue("@UserID", UserId);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int intResult))
                {
                    ID = intResult;
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
        }
    }
}
