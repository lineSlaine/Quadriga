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
    public partial class RenameGroup : Form
    {
        Group_settings owner;
        Groups groups;
        string ID;
        public RenameGroup(Group_settings owner, Groups groups, string ID)
        {
            this.owner = owner;
            this.groups = groups;
            this.ID = ID;
            InitializeComponent();
        }

        private void RenameGroup_Load(object sender, EventArgs e)
        {

        }

        private async void buttonEnter_Click(object sender, EventArgs e)
        {
            labelSuccessfully.Visible = false;
            if(textName.Text.Trim() != "")
            {
                await groups.RenameGroup(ID, textName.Text.Trim());
                owner.UpdateGroupName(textName.Text.Trim());
                labelSuccessfully.Visible = true;
            }
        }
    }
}
