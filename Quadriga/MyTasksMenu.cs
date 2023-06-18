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
    public partial class MyTasksMenu : Form
    {
        FormMain owner;
        Authentication authentication;
        TasksHelper tasksHelper;
        bool statusAdmin;
        string selectedUserID;
        public MyTasksMenu(FormMain owner, Authentication authentication, bool status, string ID)
        {
            InitializeComponent();
            this.owner = owner;
            this.authentication = authentication;
            tasksHelper = new TasksHelper(authentication.database);
            statusAdmin = status;
            selectedUserID = ID;
        }

        private void MyTasksMenu_Load(object sender, EventArgs e)
        {
            if(selectedUserID == "")
            {
                panelAdmin.Visible = false;
                panelAdmin.Enabled = false;
            }
            SetList();
            if (statusAdmin)
            {
               panelAdmin.Visible = true;
                panelAdmin.Enabled = true;
            }
        }

        private async Task SetList()
        {
            if (listBox.Items.Count != 0)
            {
                listBox.Items.Clear();
            }
            try
            {
                if (selectedUserID == "")
                {
                    await tasksHelper.getTaskID(authentication.firebaseAuthLink.User.Email);
                }
                else await tasksHelper.getTaskID(selectedUserID);

                await tasksHelper.getTaskNames();
                if(tasksHelper.currentTaskNames == null)
                {
                    textBoxDesc.Text = "Нет задач!";
                }
                else
                {
                    foreach(string name in tasksHelper.currentTaskNames)
                    {
                        listBox.Items.Add(name);
                    }
                }
            }
            catch { }

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setDesc(listBox.SelectedIndex);
        }
        private async Task setDesc(int selectID)
        {
            textBoxDesc.Clear();
            await tasksHelper.getDescription(tasksHelper.currentTasksID[selectID]);
            textBoxDesc.Text = tasksHelper.description;
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if(listBox.SelectedItems.Count != 0)
            {
                await tasksHelper.DeleteTask(tasksHelper.currentTasksID[listBox.SelectedIndex]);
            }
            await SetList();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            if (textUsername.Text.Trim() != "" && richTextBox1.Text.Trim() != "")
            {
                await tasksHelper.CreateTask(owner.selectedGroup, "", richTextBox1.Text, textUsername.Text, selectedUserID);
                panel2.Visible = !panel2.Visible;
                await SetList();
            }
            else
            {
                labelError.Visible = true;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }
    }
}
