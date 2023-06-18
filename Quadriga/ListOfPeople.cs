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
    public partial class ListOfPeople : Form
    {
        FormMain owner;
        Authentication authentication;
        UserHelper userHelper;

        public ListOfPeople(FormMain owner, Authentication authentication)
        {
            InitializeComponent();
            this.owner = owner;
            this.authentication = authentication;
            userHelper = new UserHelper();

        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            if(listBox.SelectedItems.Count != 0)
            {
                if (authentication.firebaseAuthLink.User.Email != userHelper.currentUserID[listBox.SelectedIndex])
                {
                    Groups groups = new Groups(authentication.database);
                    await groups.RemoveUser(owner.selectedGroup, userHelper.currentUserID[listBox.SelectedIndex]);
                    Update();
                }
                else labelError.Visible = true;
            }
        }

        private void ListOfPeople_Load(object sender, EventArgs e)
        {
            if(owner.LVL != 0) 
            { 
                buttonDelete.Enabled = false;
                buttonDelete.Visible = false;
            }
            if (owner.LVL < 2)
            {
                panel1.Visible = true;
                panel1.Enabled = true;
            }

            Update();
        }
        async void Update()
        {
            listBox.Items.Clear();
            await userHelper.getUsersIdInGroup(owner.selectedGroup, authentication.database);
            await userHelper.getUsersNames(authentication.database);
            for(int i =  0; i < userHelper.currentUserID.Count; i++)
            {
                listBox.Items.Add(userHelper.currentUserID[i]+ " " + userHelper.currentUserNames[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox.SelectedItems.Count != 0)
            {
                owner.OpenChildForm(new MyTasksMenu(owner, authentication, true, userHelper.currentUserID[listBox.SelectedIndex]));
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
