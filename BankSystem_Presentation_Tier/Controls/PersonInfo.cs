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

namespace BankSystem_Presentation_Tier.Controls
{
    public partial class UserFullInfo : UserControl
    {
        public clsPerson _Person;

        public UserFullInfo()
        {
            InitializeComponent();
        }

        public void FillpersonInfo()
        {

            LB_FirstName.Text = _Person.FirstName;
            LB_LastName.Text = _Person.LastName;
            LB_Email.Text = _Person.Email;
            LB_Phone.Text = _Person.Phone;
            LB_Address.Text = _Person.Address;
            LB_Country.Text = _Person.CountryID.ToString();
            LB_DAteOfBirth.Text = _Person.DateOfBirth.ToString();
            LB_PersonID.Text = _Person.PersonID.ToString();
        }

    }
}
