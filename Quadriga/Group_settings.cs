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
    public partial class Group_settings : Form
    {
        FormMain owner;
        Groups groups;
        Authentication authentication;
        public Group_settings(FormMain owner, Groups groups, Authentication authentication)
        {
            InitializeComponent();
            this.owner = owner;
            this.groups = groups;
            this.authentication = authentication;
        }

        private async void buttonAddGroup_Click(object sender, EventArgs e)
        {
            if(textGroupName.Text != "")
            {
                await groups.AddGroup("", authentication.firebaseAuthLink);
            }
        }
    }
}
