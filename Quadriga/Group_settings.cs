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
        Form activeForm;
        public string ID;
        public Group_settings(FormMain owner, Groups groups, Authentication authentication)
        {
            InitializeComponent();
            this.owner = owner;
            this.groups = groups;
            this.authentication = authentication;
            ID = owner.selectedGroup;
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

        private void buttonRename_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RenameGroup(this, groups, ID));
        }

        private void Group_settings_Load(object sender, EventArgs e)
        {
            labelGroupName.Text = owner.selectedGroupName;
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            await groups.DeleteGroup(owner.selectedGroup);
            owner.selectedGroup = null;
            owner.selectedGroupName = null;
            owner.LockMenu();
            owner.CloseActiveForm();
        }
        public void UpdateGroupName(string name)
        {
            owner.selectedGroupName = name;
            labelGroupName.Text = name;
        }
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddNewUser(this, authentication));
        }

        private void buttonAddUser_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new AddUser(this, authentication, groups, ID));
        }
    }
}
