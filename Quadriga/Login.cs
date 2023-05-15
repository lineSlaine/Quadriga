using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;

namespace Quadriga
{
    public partial class Login : Form
    {
        readonly FormMain owner;
        readonly Color inactiveColor = Color.Black;
        readonly Color activeColor = Color.SteelBlue;
        readonly Color disableColor = Color.Silver;
        readonly Color baseColor = Color.FromArgb(51, 51, 76);
        readonly Regex email = new(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");
        Authentication authentication;
        public Login(FormMain owner, Authentication authentication)
        {
            InitializeComponent();
            this.owner = owner;
            this.authentication = authentication;
        }

        private async void ButtonEnter_Click(object sender, EventArgs e)
        {
            Clear();
            buttonEnter.Enabled = false;
            buttonEnter.BackColor = disableColor;
            if (textUsername.Text.Trim() == "" || !email.IsMatch(textUsername.Text.ToLower())) 
            {
               
                if(labelIncorrectEmail.Visible == false) IncorrectEmailMessage();
                if (labelIncorrectPass.Visible == true) IncorrectPasswordMessage();
                if(labelError.Visible == true) IncorrectMessage();
                buttonEnter.Enabled = true;
                buttonEnter.BackColor = baseColor;
            }
            else if (textPassword.Text.Trim() == "") 
            {
                if (labelIncorrectPass.Visible == false) IncorrectPasswordMessage();
                if (labelIncorrectEmail.Visible == true) IncorrectEmailMessage();
                if (labelError.Visible == true) IncorrectMessage();
                buttonEnter.Enabled = true;
                buttonEnter.BackColor = baseColor;
            }
            else
            {
                await LoginCheck(); 

                if (authentication.authStatus)
                {
                    EnterLogin();
                }
                else
                {
                Clear();
                IncorrectMessage();

                }
            }
                
        }

        private void IncorrectPasswordMessage()
        {
            labelIncorrectPass.Visible = !labelIncorrectPass.Visible;
        }

        private void IncorrectEmailMessage()
        {
            labelIncorrectEmail.Visible = !labelIncorrectEmail.Visible;
        }
        
        private void IncorrectMessage()
        {
            labelError.Text = authentication.ex;
            labelError.Visible = !labelError.Visible;
        }
        private void Clear()
        {
            labelError.Visible = false;
            labelIncorrectEmail.Visible = false;
            labelIncorrectPass.Visible=false;
            buttonEnter.Enabled = true;
            buttonEnter.BackColor = baseColor;
        }

        private void EnterLogin()
        {
            owner.LVL = LoginLVL();
            owner.LoginPass();

        }

        private async Task LoginCheck()
        {

            await authentication.LoginWithEmailAndPassword(textUsername.Text.Trim(), textPassword.Text);
           
        }

        private int LoginLVL()
        {
            //return 2;
            return 1;
            //return 0;
            //return -1;
        }

        private void LabelSignUp_Click(object sender, EventArgs e)
        {
            owner.OpenChildForm(new Registration(owner, authentication));
        }

        private void LabelSignUp_MouseEnter(object sender, EventArgs e)
        {
            labelSignUp.ForeColor = activeColor;
        }

        private void LabelSignUp_MouseLeave(object sender, EventArgs e)
        {
            labelSignUp.ForeColor = inactiveColor;
        }
    }
}
