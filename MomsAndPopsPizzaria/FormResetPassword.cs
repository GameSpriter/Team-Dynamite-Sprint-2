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
    public partial class FormResetPassword : Form
    {
        public FormResetPassword()
        {
            InitializeComponent();
        }

        private bool ValidatePassword()
        {
            //Check the user class for validation
            return false; //Default to avoid errors, remove later
        }

        private void ResetPasswordButton_Click(object sender, EventArgs e)
        {

        }
    }
}
