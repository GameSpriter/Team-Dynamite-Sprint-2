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
    public partial class FormController : Form
    {
        private Form child;

        public FormController()
        {
            InitializeComponent();
            child = new FormHome(this);
            child.Show();
            SetVisibleCore(true);
        }

        public void OpenForm(string formName)
        {
            child.Close();
            child = null;
            switch (formName)
            {
                case "Location":
                    child = new FormLocation(this);
                    break;
            }
            child.Show();
        }
    }
}
