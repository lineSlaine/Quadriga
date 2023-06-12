using Google.Api;
using Google.Cloud.Firestore;
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
        Groups groups;
        public string selectedGroupName; 
        public string selectedGroup;


        public FormMain(FirestoreDb database)
        {
            authentication = new Authentication(database);
            groups = new Groups(database);
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

        public void Logout()
        {
            LockMenu();
            logoPanel.Visible = false;
            menuPanel.Visible = false;
            CloseActiveForm();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            logoPanel.Visible = false;
            menuPanel.Visible = false;
            OpenChildForm(new Login(this, authentication));
        }
        void LoadMEnu()
        {
                logoPanel.Visible = true;
                menuPanel.Visible = true;
                CloseActiveForm();
                labelTitle.Text = "√À¿¬Õ¿ﬂ";
        }
        public void CloseActiveForm()
        {
            activeForm.Close();
            activeForm = null;
        }
        public void UnlockMenu()
        {
            buttonGSettings.Enabled = true;
            buttonTasks.Enabled = true;
            buttonLPeople.Enabled = true;
        }
        public void LockMenu()
        {
            buttonGSettings.Enabled = false;
            buttonTasks.Enabled = false;
            buttonLPeople.Enabled = false;
        }

        public bool LoadLVL()
        {
            switch (LVL)
            {
                case 0:
                    buttonTasks.Enabled = false;
                    buttonTasks.Visible = false;

                    //buttonReports.Enabled = false;
                    //buttonReports.Visible = false;
                    LoadMEnu();
                    break;
                case 1:
                    //buttonStatistics.Enabled = false;
                    //buttonStatistics.Visible = false;
                    LoadMEnu();
                    break;
                case 2:
                    buttonGSettings.Enabled = false;
                    buttonGSettings.Visible = false;

                    //buttonStatistics.Enabled = false;
                    //buttonStatistics.Visible = false;
                    LoadMEnu();
                    break;
                default:
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

        public void SelectGroup(string docID, string groupName)
        {
            selectedGroup = docID;
            selectedGroupName = groupName;
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
            OpenChildForm(new ListOfPeople(this, authentication));
        }


        private void ButtonReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //OpenChildForm(Form childForm);
        }

        private void ButtonProjects_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Projects(this, groups, authentication));
        }


        private void ButtonStatistics_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //OpenChildForm(Form childForm);
        }

        private void ButtonGSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Group_settings(this, groups, authentication));
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Settings(this, authentication));
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
            StartProgram();
        }

        private void LabelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ButtonSelectGroup_Click(object sender, EventArgs e)
        {
            DisableButton();
            currentButton = null;
            OpenChildForm(new GroupsForm(this, groups,authentication));

            
        }
    }
}