using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessTier;

namespace BankSystem_Presentation_Tier.Global
{
    public static class clsGlobal
    {
        private static clsUsers _Currentuser;
        public static clsUsers CurrentUser
        {

            get
            {
                return _Currentuser;
            }

            set
            {
                _Currentuser = value;
                clsShared.DLL_CurrentUser = _Currentuser;
            }
        }

        public const string Version = "Alpha-V1.0.0";
    }
}
