namespace Quadriga
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.buttonProjects = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonLPeople = new System.Windows.Forms.Button();
            this.buttonTasks = new System.Windows.Forms.Button();
            this.buttonMessages = new System.Windows.Forms.Button();
            this.buttonGSettings = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.buttonSelectGroup = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelActiveForm = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.menuPanel.Controls.Add(this.buttonStatistics);
            this.menuPanel.Controls.Add(this.buttonProjects);
            this.menuPanel.Controls.Add(this.buttonReports);
            this.menuPanel.Controls.Add(this.buttonLPeople);
            this.menuPanel.Controls.Add(this.buttonTasks);
            this.menuPanel.Controls.Add(this.buttonMessages);
            this.menuPanel.Controls.Add(this.buttonGSettings);
            this.menuPanel.Controls.Add(this.buttonSettings);
            this.menuPanel.Controls.Add(this.logoPanel);
            resources.ApplyResources(this.menuPanel, "menuPanel");
            this.menuPanel.Name = "menuPanel";
            // 
            // buttonStatistics
            // 
            resources.ApplyResources(this.buttonStatistics, "buttonStatistics");
            this.buttonStatistics.FlatAppearance.BorderSize = 0;
            this.buttonStatistics.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.ButtonStatistics_Click);
            // 
            // buttonProjects
            // 
            resources.ApplyResources(this.buttonProjects, "buttonProjects");
            this.buttonProjects.FlatAppearance.BorderSize = 0;
            this.buttonProjects.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProjects.Name = "buttonProjects";
            this.buttonProjects.UseVisualStyleBackColor = true;
            this.buttonProjects.Click += new System.EventHandler(this.ButtonProjects_Click);
            // 
            // buttonReports
            // 
            resources.ApplyResources(this.buttonReports, "buttonReports");
            this.buttonReports.FlatAppearance.BorderSize = 0;
            this.buttonReports.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.UseVisualStyleBackColor = true;
            this.buttonReports.Click += new System.EventHandler(this.ButtonReports_Click);
            // 
            // buttonLPeople
            // 
            resources.ApplyResources(this.buttonLPeople, "buttonLPeople");
            this.buttonLPeople.FlatAppearance.BorderSize = 0;
            this.buttonLPeople.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLPeople.Name = "buttonLPeople";
            this.buttonLPeople.UseVisualStyleBackColor = true;
            this.buttonLPeople.Click += new System.EventHandler(this.ButtonLPeople_Click);
            // 
            // buttonTasks
            // 
            resources.ApplyResources(this.buttonTasks, "buttonTasks");
            this.buttonTasks.FlatAppearance.BorderSize = 0;
            this.buttonTasks.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTasks.Name = "buttonTasks";
            this.buttonTasks.UseVisualStyleBackColor = true;
            this.buttonTasks.Click += new System.EventHandler(this.ButtonTasks_Click);
            // 
            // buttonMessages
            // 
            resources.ApplyResources(this.buttonMessages, "buttonMessages");
            this.buttonMessages.FlatAppearance.BorderSize = 0;
            this.buttonMessages.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMessages.Name = "buttonMessages";
            this.buttonMessages.UseVisualStyleBackColor = true;
            this.buttonMessages.Click += new System.EventHandler(this.ButtonMessages_Click);
            // 
            // buttonGSettings
            // 
            resources.ApplyResources(this.buttonGSettings, "buttonGSettings");
            this.buttonGSettings.FlatAppearance.BorderSize = 0;
            this.buttonGSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonGSettings.Name = "buttonGSettings";
            this.buttonGSettings.UseVisualStyleBackColor = true;
            this.buttonGSettings.Click += new System.EventHandler(this.ButtonGSettings_Click);
            // 
            // buttonSettings
            // 
            resources.ApplyResources(this.buttonSettings, "buttonSettings");
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.logoPanel.Controls.Add(this.buttonSelectGroup);
            this.logoPanel.Controls.Add(this.panellogo);
            resources.ApplyResources(this.logoPanel, "logoPanel");
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoPanel_MouseDown);
            // 
            // buttonSelectGroup
            // 
            resources.ApplyResources(this.buttonSelectGroup, "buttonSelectGroup");
            this.buttonSelectGroup.FlatAppearance.BorderSize = 0;
            this.buttonSelectGroup.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSelectGroup.Name = "buttonSelectGroup";
            this.buttonSelectGroup.UseVisualStyleBackColor = true;
            this.buttonSelectGroup.Click += new System.EventHandler(this.ButtonSelectGroup_Click);
            // 
            // panellogo
            // 
            resources.ApplyResources(this.panellogo, "panellogo");
            this.panellogo.Name = "panellogo";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelTitle.Controls.Add(this.buttonMin);
            this.panelTitle.Controls.Add(this.buttonMax);
            this.panelTitle.Controls.Add(this.buttonClose);
            this.panelTitle.Controls.Add(this.labelTitle);
            resources.ApplyResources(this.panelTitle, "panelTitle");
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseDown);
            // 
            // buttonMin
            // 
            resources.ApplyResources(this.buttonMin, "buttonMin");
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.ForeColor = System.Drawing.Color.White;
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            // 
            // buttonMax
            // 
            resources.ApplyResources(this.buttonMax, "buttonMax");
            this.buttonMax.FlatAppearance.BorderSize = 0;
            this.buttonMax.ForeColor = System.Drawing.Color.White;
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.ButtonMax_Click);
            // 
            // buttonClose
            // 
            resources.ApplyResources(this.buttonClose, "buttonClose");
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // labelTitle
            // 
            resources.ApplyResources(this.labelTitle, "labelTitle");
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseDown);
            // 
            // panelActiveForm
            // 
            this.panelActiveForm.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panelActiveForm, "panelActiveForm");
            this.panelActiveForm.Name = "panelActiveForm";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelActiveForm);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.menuPanel);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuPanel;
        private Button buttonGSettings;
        private Button buttonSettings;
        private Panel logoPanel;
        private Panel panelTitle;
        private Button buttonMin;
        private Button buttonMax;
        private Button buttonClose;
        private Label labelTitle;
        private Button buttonTasks;
        private Button buttonMessages;
        private Button buttonProjects;
        private Button buttonReports;
        private Button buttonLPeople;
        private Panel panelActiveForm;
        private Panel panellogo;
        private Button buttonSelectGroup;
        private Button buttonStatistics;
    }
}