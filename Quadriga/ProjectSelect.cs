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
    public partial class ProjectSelect : Form
    {
        Projects owner;
        Authentication authentication;
        ProjectHelper projectHelper;
        public ProjectSelect(Projects owner, Authentication authentication)
        {
            this.owner = owner;
            this.authentication = authentication;
            InitializeComponent();
            projectHelper = new ProjectHelper();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems.Count != 0)
            {
                owner.projectID = projectHelper.projectsID[listBox.SelectedIndex]; 
                owner.projectName = listBox.Items[listBox.SelectedIndex].ToString());
            }
        }

        private void ProjectSelect_Load(object sender, EventArgs e)
        {
            
            
        }

        private async Task ReloadList()
        {
            listBox = null;
            await projectHelper.GetProjectIDList(authentication, authentication.database);
            await projectHelper.GetProjectNames(authentication.database);

            foreach(string name in projectHelper.projectsName)
            {
                listBox.Items.Add(name);
            }
        }
    }
}
