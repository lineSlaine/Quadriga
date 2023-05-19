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
    public partial class CreateProject : Form
    {
        Projects owner;
        Authentication authentication;
        ProjectHelper projectHelper;
        public CreateProject(Projects owner, Authentication authentication)
        {
            this.owner = owner;
            this.authentication = authentication;
            InitializeComponent();
            projectHelper = new ProjectHelper();
        }

        private void CreateProject_Load(object sender, EventArgs e)
        {


        }

        private async void buttonCreate_Click(object sender, EventArgs e)
        {
            labelIncorrectName.Visible = false;
            labelSuccessfully.Visible = false;
            if (textUsername.Text.Trim() != "")
            {
                await projectHelper.CreateProject(textUsername.Text.Trim(), authentication.firebaseAuthLink.User.Email, authentication.database);
                labelSuccessfully.Visible = true;
            }
            else labelIncorrectName.Visible = true;
        }
    }
}
