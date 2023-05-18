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
    public partial class GroupsForm : Form
    {
        FormMain owner;
        Groups groups;
        Authentication authentication;
        public GroupsForm(FormMain owner, Groups groups, Authentication authentication)
        {
            InitializeComponent();
            this.owner = owner;
            this.groups = groups;
            this.authentication = authentication;
        }

        private void GroupsForm_Load(object sender, EventArgs e)
        {
            if(owner.LVL == 0)
            {
                panelCreate.Visible = true;
                textGroupName.Visible = true;
            }
            else 
            {
                textGroupName.Visible = false;
                panelCreate.Visible = false;
            }

            SetList();
        }

        private async Task SetList()
        {
            if(listBox.Items.Count != 0)
            {
                listBox.Items.Clear();
            }
            await groups.GetGroupsID(authentication.firebaseAuthLink);
            await groups.GetGroupsNames();
            try
            {
                if(groups.groupsNames != null)
                {
                    foreach(string name in groups.groupsNames)
                    {
                        listBox.Items.Add(name);
                    }
                }
                
                
            }
            catch { }
            
        }
        private async void buttonAddGroup_Click(object sender, EventArgs e)
        {
            buttonAddGroup.Enabled = false;
            buttonAddGroup.BackColor = Color.Silver;
            if (textGroupName.Text != "")
            {
                await groups.AddGroup(textGroupName.Text, authentication.firebaseAuthLink);
            }
            await SetList();
            buttonAddGroup.Enabled = true;
            buttonAddGroup.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if(listBox.SelectedItems.Count != 0)
            {
                owner.SelectGroup(groups.groupsID[listBox.SelectedIndex], listBox.Items[listBox.SelectedIndex].ToString());
                owner.UnlockMenu();
            }
        }
    }
}
