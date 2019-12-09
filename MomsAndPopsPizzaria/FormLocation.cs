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
    public partial class FormLocation : Form
    {
        FormController Parent;

        public FormLocation(FormController Parent)
        {
            this.Parent = Parent;
            InitializeComponent();
        }
    }
}
