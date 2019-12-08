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
    public partial class TemplatePage : UserControl
    {
        public TemplatePage()
        {
            InitializeComponent();
        }

        public void ChangeName(string newPageTitle)
        {
            PageTitle.Text = newPageTitle;
        }
    }
}
