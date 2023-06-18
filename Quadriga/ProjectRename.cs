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
    public partial class ProjectRename : Form
    {
        Authentication authentication;
        Projects owner;
        ProjectHelper projectHelper;

        public ProjectRename(Authentication authentication, Projects owner)
        {
            InitializeComponent();
            this.authentication = authentication;
            this.owner = owner;
            projectHelper = new ProjectHelper();
        }

        private void ProjectRename_Load(object sender, EventArgs e)
        {

        }

        private async void buttonRename_Click(object sender, EventArgs e)
        {
            labelIncorrectName.Visible = false;
            labelSuccessfully.Visible = false;

            if (textUsername.Text.Trim() != "")
            {
                await projectHelper.RenameProject(textUsername.Text.Trim(), owner.projectID, authentication.database);
                labelSuccessfully.Visible = true;
                owner.projectName = textUsername.Text.Trim();
                owner.UpdateName();
            }
            else labelIncorrectName.Visible = true;
        }
    }
}
