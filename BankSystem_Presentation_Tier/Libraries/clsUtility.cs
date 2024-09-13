using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_Presentation_Tier.Libraries
{
    public static class clsUtility
    {
        public static string FormatNumberWithPeriods(string numberString)
        {
            if (numberString.Length < 9)
            {
                for (int i = numberString.Length; i < 9; i++)
                {
                    numberString = "0" + numberString;
                }
            }

            return numberString.Substring(0, 3) + "." +
                   numberString.Substring(3, 3) + "." +
                   numberString.Substring(6, 3);
        }
    }
}
