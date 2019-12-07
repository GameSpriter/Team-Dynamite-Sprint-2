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
    public partial class FormHome : Form
    {
        FormController Parent;

        public FormHome(FormController Parent)
        {
            this.Parent = Parent;
            InitializeComponent();
            Parent.Hide(); //Hiding FormController didn't work in FormController's constructor due to timings
        }

        public void OpenForm(string formName)
        {
            Parent.OpenForm(formName);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            OpenForm("Location");
        }
    }
}
