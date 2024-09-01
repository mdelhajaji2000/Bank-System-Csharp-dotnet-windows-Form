using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_Presentation_Tier.UsersManagement
{
    public partial class clsFindUserForm : Form
    {
        public clsFindUserForm()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
        }

        private void clsFindUserForm_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void  SearchUsingUserID(int UserID)
        {
            
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            clsUsers User;

            switch (comboBox1.SelectedIndex)
            {
                case 0:

                    if (FindTextBox.Text != string.Empty)
                    {
                        User = clsUsers.Find(FindTextBox.Text);

                        if (User != null)
                        {
                            userDetailsinfoControl1.User = User;
                            userDetailsinfoControl1.Fillinfo();
                        }
                        else
                            MessageBox.Show("User not Found...!");
                    }

                    break;
                case 1:

                    if (FindTextBox.Text != string.Empty)
                    {
                        if (int.TryParse(FindTextBox.Text, out int userId))
                        {
                            User = clsUsers.Find(userId);

                            if (User != null)
                            {
                                userDetailsinfoControl1.User = User;
                                userDetailsinfoControl1.Fillinfo();
                            }
                            else
                                MessageBox.Show("User not Found...!");


                        }
                    }

                    break;
            }

        }
    }
}
