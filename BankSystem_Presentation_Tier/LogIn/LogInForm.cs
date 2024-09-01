using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_Presentation_Tier.LogIn
{
    public partial class LogInForm : Form
    {
        string LogIn_UserName;
        string LogIn_Password;

        public LogInForm()
        {
            InitializeComponent();
        }

        private void TB_UserName_TextChanged(object sender, EventArgs e)
        {
            LogIn_UserName = TB_UserName.Text;
        }

        private void TB_Password_TextChanged(object sender, EventArgs e)
        {
            LogIn_Password = TB_Password.Text;
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            if (LogIn.clsLogin.PerformLogIN(LogIn_UserName, LogIn_Password))
            {
                MainForm frm = new MainForm();

                this.Hide();

                frm.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Error UserName or Password incorrect", "Error");
            }
        }
    }
}
