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
