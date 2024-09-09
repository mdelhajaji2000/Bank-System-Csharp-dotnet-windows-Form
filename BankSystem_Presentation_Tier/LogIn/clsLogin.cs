using BusinessTier;
using BusinessTier.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_Presentation_Tier.LogIn
{
    public static class clsLogin
    {
        public static bool PerformLogIN(string UserName, string Password)
        {
            bool ISAcceptedLogIn = false;

            clsUsers User = clsUsers.CheckLogInInfo(UserName, Password);

            if (User != null)
            {
                ISAcceptedLogIn = true;

                Global.clsGlobal.CurrentUser = User;
                clsLogInLogs newLog = new clsLogInLogs(User);

                newLog.AddLogInrecord();
            }

            return ISAcceptedLogIn;
        }
    }
}
