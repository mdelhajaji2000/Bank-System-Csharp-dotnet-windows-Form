using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesstier
{
    public static class clsCountriesData
    {
        public static bool GetCountrieByCountryID(int CountryID, ref string CountryName)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Countries Where CountryID = @CountryID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            bool Isfound = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CountryName = (string)reader["CountryName"];

                    Isfound = true;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }

            return Isfound;
        }

        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Countries";

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

        public static bool GetCountryByCountryName(string CountryName, ref int CountryID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Quey = "Select * from Countries Where CountryName = @CountryName";

            SqlCommand command = new SqlCommand(Quey, connection);

            command.Parameters.AddWithValue("@CountryName", CountryName);

            bool ISFound = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CountryID = (int)reader["CountryID"];

                    ISFound = true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Error  : " + ex);
            }
            finally
            {
                connection.Close();
            }


            return ISFound;
        }
    }
}
