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
    public partial class FormCart : Form
    {
        FormController Parent;

        public FormCart(FormController Parent)
        {
            this.Parent = Parent;
            InitializeComponent();
        }

        private void FormCart_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            pageTemplate1.ChangePageTitle("Pizza");
>>>>>>> master
        }
    }
}
