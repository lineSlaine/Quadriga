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
    
    public partial class AddUser : Form
    {
        Group_settings owner;
        Authentication authentication;
        Groups group;
        string ID;
        readonly Regex email = new(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");

        public AddUser(Group_settings owner,Authentication authentication, Groups group, string ID)
        {
            this.authentication = authentication;
            this.owner = owner;
            this.group = group;
            this.ID = ID;
            InitializeComponent();
        }

        private async void buttonAddUser_Click(object sender, EventArgs e)
        {
            Clear();
            buttonAddUser.Enabled = false;
            buttonAddUser.BackColor = Color.Silver;
            if (EmailCheck())
            {
                await authentication.AccCheck(textUsername.Text.ToLower().Trim());
                if (authentication.ex != null)
                {
                    await group.AddNewUser(ID, textUsername.Text.Trim().ToLower());
                    labelSuccessfully.Visible = true;
                }
                else labelError.Visible = true;
            }
            buttonAddUser.Enabled = true;
            buttonAddUser.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void Clear()
        {
            labelError.Visible = false;
            labelIncorrectEmail.Visible = false;
            labelSuccessfully.Visible = false;
        }
        private bool EmailCheck()
        {
            if (textUsername.Text.Trim() == "" || !email.IsMatch(textUsername.Text.ToLower().Trim()))
            {
                labelIncorrectEmail.Visible = true;
                return false;
            }
            else labelIncorrectEmail.Visible = false;
            return true;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
