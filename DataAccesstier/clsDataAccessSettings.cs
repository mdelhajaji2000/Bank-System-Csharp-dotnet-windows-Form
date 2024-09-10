using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace DataAccesstier
{
    public class clsDataAccessSettings
    {
        public static string ConnectionString = "Server=.;Database=BankDB;User Id=sa;Password=sa123456;";

        // Here i was tring to connect with 
        //public static string ConnectionString = @"Server=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BankDB.mdf;Database=BankDB;Trusted_Connection=True;";


        public static bool intToBool(int value)
        {
            return (value == 1);
        }

        public static byte boolToByte(bool value)
        {
            if (value)
                return 1;
            else
                return 0;
        }
    }
}
