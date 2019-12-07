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
        public User user;
        public List<Pizza> pizzas;
        public List<Item> extras;

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
            formHider.Tick += new EventHandler(FormHide_Tick);

            child.FormClosed += new FormClosedEventHandler(EndApplication);
        }

        /// <summary>
        /// Event call to handle closing the application when a child form is closed.
        /// </summary>
        /// <param name="sender">The script that sent the call</param>
        /// <param name="e">The event arguments</param>
        private void EndApplication(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Event call to handle hiding the form after setup is complete for the form
        /// </summary>
        /// <param name="sender">The script that sent the call</param>
        /// <param name="e">The event arguments</param>
        private void FormHide_Tick(object sender, EventArgs e)
        {
            
            formHider.Stop();
            formHider.Tick -= new EventHandler(FormHide_Tick);
            formHider = null;

            Hide();
        }

        /// <summary>
        /// Call to open another form. It will automatically close the form that is currently active.
        /// </summary>
        /// <param name="formName">To open "FormLocation" use "Location" or "FormLocation". Not case Sensitive.</param>
        public void OpenForm(string formName)
        {
            child.Close();
            child = null;
            switch (formName.ToLower())
            {
                case "formaboutus":
                case "aboutus":
                    child = new FormAboutUs(this);
                    break;
                case "formaccountrecovery":
                case "accountrecovery":
                    child = new FormAccountRecovery(this);
                    break;
                case "formcart":
                case "cart":
                    child = new FormCart(this);
                    break;
                case "formcontactus":
                case "contactus":
                    child = new FormContactUs(this);
                    break;
                case "formcustompizza":
                case "custompizza":
                    child = new FormCustomPizza(this);
                    break;
                case "formhome":
                case "home":
                    child = new FormHome(this);
                    break;
                case "formlocation":
                case "location":
                    child = new FormLocation(this);
                    break;
                case "formlogin":
                case "login":
                    child = new FormLogin(this);
                    break;
                case "formmenu":
                case "menu":
                    child = new FormMenu(this);
                    break;
                case "formnutritioninformation":
                case "nutritioninformation":
                    child = new FormNutritionInformation(this);
                    break;
                case "formpaymentcheckout":
                case "paymentcheckout":
                    child = new FormPaymentCheckout(this);
                    break;
                case "formpolicyinformation":
                case "policyinformation":
                    child = new FormPolicyInformation(this);
                    break;
                case "formresetpassword":
                case "resetpassword":
                    child = new FormResetPassword(this);
                    break;
                case "formsignup":
                case "signup":
                    child = new FormSignUp(this);
                    break;
                case "formusersettings":
                case "usersettings":
                    child = new FormUserSettings(this);
                    break;
            }
            child.Show();
        }
    }
}
