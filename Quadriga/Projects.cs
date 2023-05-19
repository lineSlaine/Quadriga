using Google.Cloud.Firestore;
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
    public partial class Projects : Form
    {
        FormMain owner;
        Groups groups;
        Authentication authentication;
        Form activeForm;
        public string projectID;
        public string projectName;
        ProjectHelper projectHelper;
        FirestoreDb database;
        public Projects(FormMain owner, Groups groups, Authentication authentication)
        {
            InitializeComponent();
            this.owner = owner;
            this.groups = groups;
            this.authentication = authentication;
            this.database = authentication.database;
            projectHelper = new ProjectHelper();
        }
        void load(int LVL)
        {
            switch (LVL)
            {
                case 2:
                    buttonCreateProject.Enabled = false;
                    buttonCreateProject.Visible = false;

                    buttonDeleteProject.Enabled = false;
                    buttonDeleteProject.Visible = false;

                    buttonAddGroup.Enabled = false;
                    buttonAddGroup.Visible = false;

                    buttonDeleteGroup.Enabled = false;
                    buttonDeleteGroup.Visible = false;
                    break;
                case 1:
                    buttonCreateProject.Enabled = false;
                    buttonCreateProject.Visible = false;

                    buttonDeleteProject.Enabled = false;
                    buttonDeleteProject.Visible = false;
                    break;

            }
        }
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();

            //ActivateButton(sender); object sender
            activeForm = childForm;

            //this.labelTitle.
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelActiveForm.Controls.Add(childForm);
            this.panelActiveForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        void StateSwitch()
        {
            if(projectID == null && owner.LVL != 0)
            {
                panelDelete.Visible = false;
                panelOptions.Visible = false;
                labelProjectName.Visible = false;
            }
            else
            {
                panelDelete.Visible = true;
                panelOptions.Visible = true;
                labelProjectName.Visible = true;
            }
        }

        private void buttonCreateGroup_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateProject(this, authentication));
        }

        private void buttonSelectProject_Click(object sender, EventArgs e)
        {

        }
    }
}
