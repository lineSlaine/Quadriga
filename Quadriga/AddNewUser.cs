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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Quadriga
{
    public partial class AddNewUser : Form
    {
        readonly Regex email = new(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");
        Group_settings owner;
        Authentication authentication;
        
        public AddNewUser(Group_settings owner, Authentication authentication)
        {
            InitializeComponent();
            this.owner = owner;
            this.authentication = authentication;
        }

        private async void buttonEnter_Click(object sender, EventArgs e)
        {
            buttonEnter.BackColor = Color.Silver;
            buttonEnter.Enabled = false;
            if (FirstnameCheck()&& MiddlenameCheck()&& LastnameCheck()&& EmailCheck() && PasswordCheck() && JobCheck())
            {
                await authentication.Registration(textUsername.Text.ToLower().Trim(), textPassword.Text.Trim(), textFirstname.Text.Trim(), textMiddlename.Text.Trim(), textLastname.Text.Trim(), textJob.Text.Trim(), 2, new List<string>() { owner.ID });

            }
            buttonEnter.Enabled = true;
            buttonEnter.BackColor = Color.FromArgb(51, 51, 76);

        }
        private void Clear()
        {
            labelIncorrectPass.Visible = false;
            labelIncorrectEmail.Visible = false;
            labelIncorrectLast.Visible = false;
            labelIncorrectMiddle.Visible = false;
            labelIncorrectFirst.Visible = false;
            labelIncorrectJob.Visible = false;
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
            if (textPassword.Text.Trim() == "" || textPassword.Text.Length < 8)
            {
                labelIncorrectPass.Visible = true;
                return false;
            }
            else labelIncorrectPass.Visible = false;
            return true;
        }
        private bool JobCheck()
        {
            if (textJob.Text.Trim() == "")
            {
                labelIncorrectJob.Visible = true;
                return false;
            }
            else labelIncorrectJob.Visible = false;
            return true;
        }
    }
}
