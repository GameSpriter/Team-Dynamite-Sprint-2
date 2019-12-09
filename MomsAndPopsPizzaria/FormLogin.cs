using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MomsAndPopsPizzaria
{
    public partial class FormLogin : Form
    {
        FormController Parent;

        public string filename = "LoginInfo.txt";
        
        public FormLogin(FormController Parent)
        {
            this.Parent = Parent;
            InitializeComponent();
        }

        /// <summary>
        /// Takes the values in the "Email" and "Password" textboxes and reads a file to see if the account is created.
        /// If it is, log the user in and take the user to the menu screen. If not, add them and take the user to the menu screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (EmailTextBox.Text != " " && PasswordTextBox.Text !=" ")
            {
                if (!File.Exists(filename))
                {
                    using (var stream = File.Create(filename));
                }
                    
                else if(filename != null)
                {
                    string readText = File.ReadAllText(filename);
                    if (readText.Contains(EmailTextBox.Text) == true && readText.Contains(PasswordTextBox.Text)==true)
                    {
                        MessageBox.Show("Logged In!");
                        Parent.OpenForm("FormMenu");
                    }
                    else
                    {
                        using (StreamWriter sw = File.AppendText(filename))
                        {
                            sw.WriteLine("Email/Username: " + EmailTextBox.Text + "," + " Password: " + PasswordTextBox.Text);
                        }
                        MessageBox.Show("Account Created!");
                        Parent.OpenForm("FormMenu");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter username and password");
            }
        }
        /// <summary>
        /// Takes the user to the sign up screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Parent.OpenForm("FormSignup");
        }

        /// <summary>
        /// Not needed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForgotEmailPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        /// <summary>
        /// Name of the textfield
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailText_Click(object sender, EventArgs e)
        {
            EmailText.Text = "Username/Email";
        }

        /// <summary>
        /// Takes the input of the textfield and assigns it to the string 'userName'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            string userName = EmailTextBox.Text;
            
        }

        /// <summary>
        /// Takes the input of the textfield and assigns it to the string 'password'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            string password = PasswordTextBox.Text;
        }
        /// <summary>
        /// Page template
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pageTemplate1_Load(object sender, EventArgs e)
        {
        }
        
    }
}
