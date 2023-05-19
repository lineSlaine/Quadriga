using Google.Cloud.Firestore.V1;
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
    public partial class ProjectGroupList : Form
    {
        Projects owner;
        Authentication authentication;
        ProjectHelper projectHelper;
        public ProjectGroupList( Projects owner,Authentication authentication)
        {
            this.owner = owner;
            this.authentication = authentication;
            projectHelper = new ProjectHelper();
            InitializeComponent();
        }

        private async void ProjectGroupList_Load(object sender, EventArgs e)
        {
            Update();

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if(listBox.SelectedItems.Count != 0)
            {
                await projectHelper.DeleteGroupInProject(owner.projectID, projectHelper.currentGroupsID[listBox.SelectedIndex], authentication.database);
                Update();
            }
            
        }
        async void Update()
        {
            listBox.Items.Clear();
            await projectHelper.GetGroupInProject(owner.projectID, authentication);
            foreach (string item in projectHelper.currentGroups)
            {
                listBox.Items.Add(item);
            }
        }
    }
}
