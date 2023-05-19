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

                    buttonRename.Enabled = false;
                    buttonRename.Visible = false;

                    break;
                case 1:
                    buttonCreateProject.Enabled = false;
                    buttonCreateProject.Visible = false;

                    buttonDeleteProject.Enabled = false;
                    buttonDeleteProject.Visible = false;

                    buttonRename.Enabled = false;
                    buttonRename.Visible = false;
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
            if(projectID != null)
            {
                labelProjectName.Visible = true;
                if(owner.LVL == 0)
                {
                    panelOptions.Visible = true;
                    panelOptions.Enabled = true;

                    panelDelete.Visible = true;
                    panelDelete.Enabled = true;
                }
                else
                {
                    panelOptions.Visible = true;
                    panelOptions.Enabled = true;
                }
            }
            else
            {
                labelProjectName.Visible = false;
                panelOptions.Visible = false;
                panelOptions.Enabled = false;
                panelDelete.Visible = false;
                panelDelete.Enabled = false;
            }
        }

        public void Select()
        {
            labelProjectName.Text = projectName;
            StateSwitch();
        }

        private void buttonCreateGroup_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateProject(this, authentication));
        }

        private void buttonSelectProject_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProjectSelect(this, authentication));
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            load(owner.LVL);
            StateSwitch();
        }

        private void buttonGroupList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProjectGroupList(this, authentication));
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProjectAddGroup(this, authentication));
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProjectRename(authentication, this));
        }

        private async void buttonDeleteProject_Click(object sender, EventArgs e)
        {
            await projectHelper.DeleteProject(projectID, database);
            projectID = null;
            projectName = null;
            StateSwitch();
            activeForm.Close();
        }
    }
}
