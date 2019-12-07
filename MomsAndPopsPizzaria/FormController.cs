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

        private Timer formHider = new Timer();

        public FormController()
        {
            InitializeComponent();
        }

        private void FormController_Load(object sender, EventArgs e)
        {
            child = new FormHome(this);
            child.Show();
            formHider.Interval = 20;
            formHider.Enabled = true;
            formHider.Tick += new EventHandler(formHide_Tick);
        }

        /// <summary>
        /// Event call to handle hiding the form after setup is complete for the form
        /// </summary>
        /// <param name="sender">The script that sent the call</param>
        /// <param name="e">The event arguments</param>
        private void formHide_Tick(object sender, EventArgs e)
        {
            
            formHider.Stop();
            formHider.Tick -= new EventHandler(formHide_Tick);
            formHider = null;

            Hide();
        }

        /// <summary>
        /// Call to open another form. It will automatically close the form that is currently active
        /// </summary>
        /// <param name="formName">The name of the form to open. To open "FormLocation" use string "Location".</param>
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
