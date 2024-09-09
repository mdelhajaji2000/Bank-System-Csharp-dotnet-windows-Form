using BusinessTier.Logs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_Presentation_Tier.LogInLog
{
    public partial class LogInLogsrecords : Form
    {
        public LogInLogsrecords()
        {
            InitializeComponent();

            dataGridView1.DataSource = clsLogInLogs.GetAllTables();
        }
    }
}
