using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quadriga
{
    public partial class Registration : Form
    {
        readonly Color activeColor = Color.FromArgb(51, 51, 76);
        readonly Color inactiveColor = Color.Silver;
        readonly Regex email = new(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");
        FormMain owner;
        Authentication authentication;
        public Registration(FormMain owner, Authentication authentication)
        {
            InitializeComponent();
            this.owner = owner;
            this.authentication = authentication;
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private async void buttonEnter_Click(object sender, EventArgs e)
        {
            Clear();
            buttonEnter.BackColor = inactiveColor;
            buttonEnter.Enabled = false;
            FirstnameCheck(); MiddlenameCheck(); LastnameCheck(); EmailCheck(); PasswordCheck();
            if(FirstnameCheck()&& MiddlenameCheck()&& LastnameCheck()&& EmailCheck()&& PasswordCheck())
            {
                Task task = authentication.Registration(textUsername.Text.Trim(), textPassword.Text, textFirstname.Text.Trim(), textMiddlename.Text.Trim(), textLastname.Text.Trim());
                await task;
                if (authentication.regStatus)
                {
                    
                    owner.OpenChildForm(new Login(owner, authentication));
                }
                else
                {
                    labelError.Text = authentication.ex;
                }
                
            }





            if (checkAgree.Checked)
            {
                buttonEnter.BackColor = activeColor;
                buttonEnter.Enabled = true;
            }
            else
            {
                buttonEnter.BackColor = inactiveColor;
                buttonEnter.Enabled = false;
            }
        }

        private void checkAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAgree.Checked)
            {
                buttonEnter.BackColor = activeColor;
                buttonEnter.Enabled = true;
            }
            else
            {
                buttonEnter.BackColor = inactiveColor;
                buttonEnter.Enabled = false;
            }
        }

        private bool FirstnameCheck()
        {
            if (textFirstname.Text.Trim() == "")
            {
                labelIncorrectFirst.Visible = true;
                return false;
            }
            else labelIncorrectFirst.Visible = false;
            return true;
        }
        private bool MiddlenameCheck()
        {
            if (textMiddlename.Text.Trim() == "")
            {
                labelIncorrectMiddle.Visible = true;
                return false;
            }
            else labelIncorrectMiddle.Visible = false;
            return true;
        }
        private bool LastnameCheck()
        {
            if (textLastname.Text.Trim() == "")
            {
                labelIncorrectLast.Visible = true;
                return false;
            }
            else labelIncorrectLast.Visible = false;
            return true;
        }
        private bool EmailCheck()
        {
            if (textUsername.Text.Trim() == "" || !email.IsMatch(textUsername.Text.ToLower()))
            {
                labelIncorrectEmail.Visible = true;
                return false;
            }
            else labelIncorrectEmail.Visible = false;
            return true;
        }
        private bool PasswordCheck()
        {
            if(textPassword.Text.Trim() == "" || textPassword.Text.Length < 8)
            {
                labelIncorrectPass.Visible = true;
                return false;
            }
            else labelIncorrectPass.Visible = false;
            return true;
        }

        private void Clear()
        {
            labelIncorrectPass.Visible = false;
            labelIncorrectEmail.Visible = false;
            labelIncorrectLast.Visible = false;
            labelIncorrectMiddle.Visible = false;
            labelIncorrectFirst.Visible = false;
            labelError.Visible = false;
        }
    }
}
