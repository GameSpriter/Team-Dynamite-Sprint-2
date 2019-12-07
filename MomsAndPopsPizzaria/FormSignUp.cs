using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MomsAndPopsPizzaria
{
    public partial class FormSignUp : Form
    {
        FormController Parent;
        private User user;

        public FormSignUp(FormController Parent)
        {
            this.Parent = Parent;
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateName()
        {
            //Check the user control for NameTemplate, it should already do this
            return false; //Default to avoid errors, remove later
        }

        private bool ValidateDateOfBirth()
        {
            return false; //Default to avoid errors, remove later
        }

        private bool ValidateAddress()
        {
            //Check the user control for AddressTemplate, it should already do this
            return false; //Default to avoid errors, remove later
        }

        private bool ValidatePhoneNumber()
        {
            return false; //Default to avoid errors, remove later
        }

        private bool ValidatePassword()
        {
            //Check the user class for validation
            return false; //Default to avoid errors, remove later
        }

        private void TermsOfServiceCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
