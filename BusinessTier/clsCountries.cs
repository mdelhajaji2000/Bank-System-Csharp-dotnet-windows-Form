using DataAccesstier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsCountries
    {
        public int CountryID { get; private set; }
        public string CountryName { get; set; }

        private clsCountries(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public static clsCountries Find(int CountryID)
        {
            string CountryName = "";

            if (clsCountriesData.GetCountrieByCountryID(CountryID, ref CountryName))
                return new clsCountries(CountryID, CountryName);
            else
                return null;
        }

        public static clsCountries Find(string CountryName)
        {
            int CountryId = -1;

            if (clsCountriesData.GetCountryByCountryName(CountryName, ref CountryId))
            {
                return new clsCountries(CountryId, CountryName);
            }
            else
                return null;
        }

        public static DataTable GetAllCountries()
        {
            return clsCountriesData.GetAllCountries();
        }
    }
}
