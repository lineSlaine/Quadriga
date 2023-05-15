using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quadriga
{
    public partial class Registration : Form
    {
        Color activeColor = Color.FromArgb(51, 51, 76);
        Color inactiveColor = Color.Silver;
        FormMain owner;
        public Registration(FormMain owner)
        {
            InitializeComponent();
            this.owner = owner;
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            FirstnameCheck(); MiddlenameCheck(); LastnameCheck(); EmailCheck(); PasswordCheck();
            if(FirstnameCheck()&& MiddlenameCheck()&& LastnameCheck()&& EmailCheck()&& PasswordCheck())
            {
                MessageBox.Show("Registration is successful!");
                owner.OpenChildForm(new Login(owner));
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
            if (textUsername.Text.Trim() == "")
            {
                labelIncorrectEmail.Visible = true;
                return false;
            }
            else labelIncorrectEmail.Visible = false;
            return true;
        }
        private bool PasswordCheck()
        {
            if (textPassword.Text.Trim() == "")
            {
                labelIncorrectPass.Visible = true;
                return false;
            }
            else labelIncorrectPass.Visible = false;
            return true;
        }
    }
}
