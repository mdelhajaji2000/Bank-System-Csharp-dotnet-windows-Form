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
            if (value == 1) 
                return true;
            else if (value == 0) 
                return false;
            else if (value > 1) 
                return true;
            else if (value < 0) 
                return false;

            return false;
        }
    }
}
