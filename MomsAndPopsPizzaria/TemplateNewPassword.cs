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
    public partial class TemplateNewPassword : UserControl
    {
        //NOTE: 
        //This is for when a user is entering a new password and the password should meet requirements
        //This is not for logging in.

        public TemplateNewPassword()
        {
            InitializeComponent();
        }

        public bool ValidatePassword()
        {
            return false; //Default to avoid errors, remove later
        }
    }
}
