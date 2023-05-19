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
    public partial class ProjectAddGroup : Form
    {
        Projects owner; 
        Authentication authentication;
        ProjectHelper projectHelper;
        public ProjectAddGroup(Projects owner, Authentication authentication)
        {
            this.owner = owner;
            this.authentication = authentication;
            InitializeComponent();
            projectHelper = new ProjectHelper();
        }

        private async void buttonSelect_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems.Count != 0)
            {
                string id = projectHelper.currentGroupsID[listBox.SelectedIndex];
                await projectHelper.AddGroupInProject(owner.projectID, id, authentication.database);
                Update();
            }
        }

        private async void ProjectAddGroup_Load(object sender, EventArgs e)
        {
            Update();
            
        }

        async void Update()
        {
            listBox.Items.Clear();
            await projectHelper.GetGroupsOutProject(owner.projectID, authentication);
            foreach(string item in projectHelper.currentGroups) { listBox.Items.Add(item); }
        }
    }
}
