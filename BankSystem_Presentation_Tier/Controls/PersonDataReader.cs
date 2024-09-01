using BusinessTier;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BankSystem_Presentation_Tier.Controls
{
    public partial class PersonDataReader : UserControl
    {
        public PersonDataReader()
        {
            InitializeComponent();
            LoadDataToTheComboBox();
        }

        clsPerson person;

        public void FillData(int PersonId)
        {
            clsPerson Person = clsPerson.Find(PersonId);
            if (Person != null)
            {
                TB_FirstName.Text = Person.FirstName;
                TB_Lastname.Text = Person.LastName;
                TB_Address.Text = Person.Address;
                TB_email.Text = Person.Email;
                Tbphone.Text = Person.Phone;
                CBCountry.SelectedIndex = CBCountry.FindString(clsCountries.Find(Person.CountryID).CountryName);
                DisplayPersonID.Text = Person.PersonID.ToString();
            }
        }

        public clsPerson ReadDataForUpdate(int PersonId)
        {
            clsPerson Person = clsPerson.Find(PersonId);

            try
            {
                Person.FirstName = TB_FirstName.Text;
                Person.LastName = TB_Lastname.Text;
                Person.Address = TB_Address.Text;
                Person.Email = TB_email.Text;
                Person.Phone = Tbphone.Text;
                Person.DateOfBirth = DTP_DateOfBirth.Value;
                clsCountries Country = clsCountries.Find(CBCountry.Text);
                Person.CountryID = Country.CountryID;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }

            return Person;
        }

        public clsPerson ReadData()
        {
            clsPerson NewPerson = new clsPerson();

            NewPerson.FirstName = TB_FirstName.Text;
            NewPerson.LastName = TB_Lastname.Text;
            NewPerson.Address = TB_Address.Text;
            NewPerson.Email = TB_email.Text;
            NewPerson.Phone = Tbphone.Text;
            NewPerson.DateOfBirth = DTP_DateOfBirth.Value;
            Console.WriteLine(CBCountry.Text);
            clsCountries Country = clsCountries.Find(CBCountry.Text);
            NewPerson.CountryID = Country.CountryID;

            return NewPerson;
        }

        private void LoadDataToTheComboBox()
        {
            CBCountry.DataSource = clsCountries.GetAllCountries();

            CBCountry.DisplayMember = "CountryName";
            CBCountry.ValueMember = "CountryID";
        }
        private void PersonDataReader_Load(object sender, EventArgs e)
        {

        }
    }
}
