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
    public partial class SettingProfile : Form
    {
        Settings owner;
        Authentication authentication;
        public SettingProfile(Settings owner, Authentication authentication)
        {
            InitializeComponent();
            this.owner = owner;
            this.authentication = authentication;
        }
        private void SettingProfile_Click(object sender, EventArgs e)
        {

        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            await authentication.DeleteAccount();
            owner.LogOut();
        }
    }
}
