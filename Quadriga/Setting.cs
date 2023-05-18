using Microsoft.VisualBasic.Logging;
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
    public partial class Settings : Form
    {
        FormMain owner;
        Button currentButton;
        readonly Color baseColor = Color.FromArgb(65, 65, 90);
        readonly Color selectColor;
        Form activeForm;
        Authentication authentication;

        public Settings(FormMain owner, Authentication authentication)
        {
            InitializeComponent();
            this.owner = owner;
            this.authentication = authentication;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelActiveForm.Controls.Add(childForm);
            this.panelActiveForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        public void ActivateButton(object sender)
        {

            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    currentButton = (Button)sender;
                    currentButton.BackColor = selectColor;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 16.75F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control prevBtn in panelMenuSet.Controls)
            {
                if (prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = baseColor;
                    prevBtn.ForeColor = Color.Gainsboro;
                    prevBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }
        public void LogOut()
        {
            owner.Logout();
        }
        private void ButtonGeneralSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new SettingProfile(this, authentication));
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            authentication.LogOut();
            owner.Logout();
        }
    }
}
