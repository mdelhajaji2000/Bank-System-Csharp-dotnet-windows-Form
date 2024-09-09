using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace BankSystem_Presentation_Tier.ClientsManagements.Forms
{
    public partial class FindClientMiniForm : Form
    {
        public FindClientMiniForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;
        }

        public delegate void DataBackEventHandler(object sender, int Accountnumber, bool performAction);
        public event DataBackEventHandler DataBack;

        int Accountnumber = -1;
        bool PerformAction = false;

        private void btn_Find_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(FindTextBox.Text) && int.TryParse(FindTextBox.Text, out int result))
            //{
            //    Accountnumber = result;
            //}
            //else
            //{
            //    MessageBox.Show("Input Validation Error", "Input Error");
            //    return;
            //}

            if (int.TryParse(FindTextBox.Text, out int result))
            {
                Accountnumber = result;
            }

            if (clsClientAccount.IsclientExist(Accountnumber))
            {
                PerformAction = true;
                SendData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Client Account Not Found", "Not Found (404)");
                return;
            }
                
        }

        private void SendData()
        {
            DataBack?.Invoke(this, Accountnumber, PerformAction);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PerformAction = false;
            SendData();
        }
    }
}
