using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MomsAndPopsPizzaria
{
    public partial class TemplateAddress : UserControl
    {
        //Putting this Template on a page keeps crashing Visual Studio for me.
        public Address StreetAddress
        {
            get
            {
                updateAddress();
                return StreetAddress;
            }
            private set
            {
                StreetAddress = value;
            }
        }

        public TemplateAddress()
        {
            InitializeComponent();
        }

        private void updateAddress()
        {

        }

        public bool ValidateAddress()
        {
            return false; //Default to avoid errors, remove later
        }

        private bool ValidateStreet()
        {
            return false; //Default to avoid errors, remove later
        }

        private bool ValidateApartment()
        {
            return false; //Default to avoid errors, remove later
        }

        private bool ValidateCity()
        {
            return false; //Default to avoid errors, remove later
        }

        private bool ValidateState()
        {
            return false; //Default to avoid errors, remove later
        }

        private bool ValidateZipCode()
        {
            return false; //Default to avoid errors, remove later
        }

        private bool ValidateCountry()
        {
            return false; //Default to avoid errors, remove later
        }

        private void StreetAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
