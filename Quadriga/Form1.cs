using Google.Api;
using System.Runtime.InteropServices;

namespace Quadriga
{
    public partial class FormMain : Form
    {

        Form activeForm;
        Button currentButton;
        readonly Color baseColor = Color.FromArgb(51, 51, 76);
        readonly Color selectColor = Color.FromArgb(65, 65, 90);
        public int LVL;
        Authentication authentication;


        public FormMain()
        {
            InitializeComponent();
        }

        private void StartProgram()
        {
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            logoPanel.Visible = false;
            menuPanel.Visible = false;
            OpenChildForm(new Login(this, authentication));
        }
        public void LoginPass()
        {
            if (LoadMenu(LVL))
            {
                logoPanel.Visible = true;
                menuPanel.Visible = true;
                CloseActiveForm();
                labelTitle.Text = "HOME";
            }
            
        }
        public void CloseActiveForm()
        {
            activeForm.Close();
            activeForm = null;
        }

        private bool LoadMenu(int LVL)
        {
            if (LVL == 0)
            {
                buttonTasks.Enabled = false;
                buttonTasks.Visible = false;

                buttonReports.Enabled = false;
                buttonReports.Visible = false;
            }
            else if (LVL == 1)
            {
                buttonStatistics.Enabled = false;
                buttonStatistics.Visible = false;
            }
            else if (LVL == 2)
            {
                buttonGSettings.Enabled = false;
                buttonGSettings.Visible = false;

                buttonStatistics.Enabled = false;
                buttonStatistics.Visible = false;
            }
            else
            {
                MessageBox.Show("Ошибка прогрузки меню");
                return false;
            }
            return true;
        }

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();

            //ActivateButton(sender); object sender
            activeForm = childForm;
            this.labelTitle.Text = childForm.Text;
            //this.labelTitle.
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelActiveForm.Controls.Add(childForm);
            this.panelActiveForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ButtonMessages_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        public void ActivateButton(object sender)
        {
            
            if (sender != null)
            {
                if(currentButton != (Button)sender)
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
            foreach(System.Windows.Forms.Control prevBtn in menuPanel.Controls)
            {
                if(prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = baseColor;
                    prevBtn.ForeColor = Color.Gainsboro;
                    prevBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
                    if(activeForm != null) activeForm.Close();
                }

            }
        }

        private void ButtonTasks_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //OpenChildForm(Form childForm);
        }

        private void ButtonLPeople_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //OpenChildForm(Form childForm);
        }


        private void ButtonReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //OpenChildForm(Form childForm);
        }

        private void ButtonProjects_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //OpenChildForm(Form childForm);
        }


        private void ButtonStatistics_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //OpenChildForm(Form childForm);
        }

        private void ButtonGSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //OpenChildForm(Form childForm);
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Settings(this));
        }

        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LogoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LabelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonMax_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void ButtonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            authentication = new Authentication();
            StartProgram();
        }

        private void LabelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}