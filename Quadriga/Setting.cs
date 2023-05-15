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

        public Settings(FormMain owner)
        {
            InitializeComponent();
            this.owner = owner;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

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

        private void ButtonGeneralSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
