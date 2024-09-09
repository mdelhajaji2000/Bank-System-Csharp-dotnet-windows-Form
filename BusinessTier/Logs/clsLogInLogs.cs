using DataAccesstier.Logs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier.Logs
{
    public class clsLogInLogs
    {
        public int UserID { get; set; }
        public int ID { get; private set; }
        public DateTime Date { get; set; }

        public clsLogInLogs(clsUsers user)
        {
            this.UserID = user.UserID;
            this.Date = DateTime.Now;
            this.ID = -1;
        }

        public static DataTable GetAllTables()
        {
            return clsLogInLogsData.GetAllLogin_LogRecords();
        }

        public void AddLogInrecord()
        {
            int Id = -1;
            clsLogInLogsData.AddRecord(this.UserID, ref Id);

            this.ID = Id;
        }
        
    }
}
