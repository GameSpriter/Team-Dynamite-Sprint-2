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

<<<<<<< HEAD
        public void ChangeName(string newPageTitle)
=======
        public void ChangePageTitle(string newPageTitle)
>>>>>>> master
        {
            PageTitle.Text = newPageTitle;
        }
    }
}
