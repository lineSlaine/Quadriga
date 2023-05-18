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
    public partial class SettingProfile : Form
    {
        Settings owner;
        Authentication authentication;
        readonly Regex email = new(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
               @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");
        ProfileUpdater profileUpdater;
        public SettingProfile(Settings owner, Authentication authentication)
        {
            InitializeComponent();
            this.owner = owner;
            this.authentication = authentication;
            profileUpdater = new ProfileUpdater();
        }
        private void SettingProfile_Click(object sender, EventArgs e)
        {

        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            await authentication.DeleteAccount();
            if(authentication.ex == "Done")
            {
                owner.LogOut();
            }

        }


        private void buttonUpdateFN_Click(object sender, EventArgs e)
        {
            if(textFirstname.Text.Trim() != "")
            {
                profileUpdater.UpdateFN(authentication.database, authentication, textFirstname.Text.Trim());
                MessageBox.Show("Successful!");
            }

        }

        private void buttonUpdateMN_Click(object sender, EventArgs e)
        {
            if(textMiddlename.Text.Trim() != "")
            {
                profileUpdater.UpdateMN(authentication.database, authentication, textMiddlename.Text.Trim());
                MessageBox.Show("Successesful!");
            }
        }

        private void buttonUpdateLN_Click(object sender, EventArgs e)
        {
            if(textLastname.Text.Trim() != "")
            {
                profileUpdater.UpdateLN(authentication.database, authentication, textLastname.Text.Trim());
                MessageBox.Show("Successesful!");

            }
        }

        private void buttonUpdatePass_Click(object sender, EventArgs e)
        {
            if(textPassword.Text.Trim() != "")
            {
                profileUpdater.UpdatePass(authentication.database, authentication, textPassword.Text.Trim());
                MessageBox.Show("Successesful!");

            }
        }

        private void buttonUpdateJob_Click(object sender, EventArgs e)
        {
            if(textJob.Text.Trim() != "")
            {
                profileUpdater.UpdateJob(authentication.database, authentication, textJob.Text.Trim());
                MessageBox.Show("Successesful!");

            }
        }
    }
}
