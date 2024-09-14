using BankSystem_Presentation_Tier.Controls;
using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_Presentation_Tier.ClientsManagements.Forms
{
    public partial class ClientsListForm : Form
    {
        public ClientsListForm()
        {
            InitializeComponent();
        }

        public bool IsOnlyForInactiveAccounts = false;

        private clsClientAccount SelectedClientAccount;

        private Color color1 = Color.FromArgb(27, 31, 49);
        private Color color2 = Color.FromArgb(27, 31, 43);

        static int colorChanger = 0;
        private void FillClientsContainer(DataTable dtClientsAccounts)
        {

            foreach(DataRow row in dtClientsAccounts.Rows)
            {
                ClientCard clientcard = new ClientCard((int)row["AccountNumber"]);
                clientcard.onClientselected += getSelectedClient;
                clientcard.onDetailsbuttonClicked += DetailsButtonClicked;
                ClientsContainer.Controls.Add(clientcard);

                if (colorChanger % 2 == 0)
                    clientcard.BackColor = color1;
                else
                    clientcard.BackColor = color2;

                colorChanger++;
            }
        }

        private void getSelectedClient(int AccountNumber)
        {
            SelectedClientAccount = clsClientAccount.Find(AccountNumber);
            selectedClientMenuStripDisplayName.Text = "Account Number : " + SelectedClientAccount.AccountNumber.ToString();

            if (SelectedClientAccount.ActivationStatus)
            {
                activateDisactivateToolStripMenuItem.Text = "Desactivate Account";
                activateDisactivateToolStripMenuItem.Image = imageList1.Images[0];
            }
            else
            {
                activateDisactivateToolStripMenuItem.Text = "Activate Account";
                activateDisactivateToolStripMenuItem.Image = imageList1.Images[1];
            }
            
        }

        private void DetailsButtonClicked(int AccountNumber)
        {
            this.SelectedClientAccount = clsClientAccount.Find(AccountNumber);
            selectedClientMenuStripDisplayName.Text = "Account Number : " + SelectedClientAccount.AccountNumber.ToString();
            contextMenuStrip1.Show(Cursor.Position);
        }


        public void ShowinactiveOnly()
        {
            FillClientsContainer(clsClientAccount.GetInactivateAccounts());
        }

        public void ShowAllClients()
        {
            FillClientsContainer(clsClientAccount.GetAllClientsAccounts());
        }

        private void detailsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindClientForm findForm = new FindClientForm();

            findForm.FillDataUsingParameter(SelectedClientAccount.AccountNumber);
            findForm.ShowDialog();
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUpdateClientAccount frmAddNew = new AddNewUpdateClientAccount();

            frmAddNew.ShowDialog();
        }

        private void refresh()
        {
            ClientsContainer.Controls.Clear();

            if (IsOnlyForInactiveAccounts)
            {
                ShowinactiveOnly();
                return;
            }    

            FillClientsContainer(clsClientAccount.GetAllClientsAccounts());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void editActivationStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUpdateClientAccount frmupdate = new AddNewUpdateClientAccount(SelectedClientAccount.AccountNumber);

            frmupdate.ShowDialog();
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Delete This Account ? (" + SelectedClientAccount.AccountNumber + ") ?", "Perform Action", MessageBoxButtons.OKCancel);

            Exception ex = new Exception("Fuck You Muther Fucker");

            if (result == DialogResult.Yes)
            {
                if (clsClientAccount.DeleteClient(SelectedClientAccount.AccountNumber) && clsPerson.DeletePerson(SelectedClientAccount.PersonID))
                    MessageBox.Show("Client Deleted Successfuly..!", "Action Performed (Success)");
                else
                    MessageBox.Show("Error Not Deleted");
            }
        }

        private void activateDisactivateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedClientAccount.ActivationStatus)
            {
                SelectedClientAccount.DesactivateAccount();

                activateDisactivateToolStripMenuItem.Text = "Activate Account";
                activateDisactivateToolStripMenuItem.Image = imageList1.Images[0];
            }
            else
            {
                SelectedClientAccount.ActivateAccount();

                activateDisactivateToolStripMenuItem.Text = "Desactivate Account";
                activateDisactivateToolStripMenuItem.Image = imageList1.Images[1];
            }

            refresh();
        }

        private void ClientsListForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
