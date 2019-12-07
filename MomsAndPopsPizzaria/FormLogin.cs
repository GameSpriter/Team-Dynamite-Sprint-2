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
    public partial class FormLogin : Form
    {
        FormController Parent;

        public FormLogin(FormController Parent)
        {
            this.Parent = Parent;
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

        }

        private void ForgotEmailPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
