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
        private User user;

        public FormSignUp()
        {
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
    }
}
