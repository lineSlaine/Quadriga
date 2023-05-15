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
        Color inactiveColor = Color.Black;
        Color activeColor = Color.SteelBlue;
        Regex email = new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");
        Authentication authentication;
        public Login(FormMain owner)
        {
            InitializeComponent();
            this.owner = owner;
            authentication = new Authentication();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            
            if (textUsername.Text.Trim() == "" || !email.IsMatch(textUsername.Text.ToLower())) 
            {
               
               if(labelIncorrectEmail.Visible == false) IncorrectEmailMessage();
               if (labelIncorrectPass.Visible == true) IncorrectPasswordMessage();
               if(labelError.Visible == true) IncorrectMessage();
            }
            else if (textPassword.Text.Trim() == "") 
            {
                if (labelIncorrectPass.Visible == false) IncorrectPasswordMessage();
                if (labelIncorrectEmail.Visible == true) IncorrectEmailMessage();
                if (labelError.Visible == true) IncorrectMessage();
            }
            else if (LoginCheck())
            {
                EnterLogin();
            }
            else
            {
                Clear();
                IncorrectMessage();
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
            labelError.Visible = !labelError.Visible;
        }
        private void Clear()
        {
            labelError.Visible = false;
            labelIncorrectEmail.Visible = false;
            labelIncorrectPass.Visible=false;
        }

        private void EnterLogin()
        {
            owner.LVL = LoginLVL();
            owner.LoginPass();

        }

        private bool LoginCheck()
        {
            authentication.LoginWithEmailAndPassword(textUsername.Text.Trim(), textPassword.Text);
            return authentication.authStatus; 
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
            owner.OpenChildForm(new Registration(owner));
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
