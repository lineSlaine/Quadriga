namespace Quadriga
{
    partial class Projects
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.buttonDeleteProject = new System.Windows.Forms.Button();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.buttonRename = new System.Windows.Forms.Button();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.buttonGroupList = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSelectProject = new System.Windows.Forms.Button();
            this.buttonCreateProject = new System.Windows.Forms.Button();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.panelActiveForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.panelDelete);
            this.panel1.Controls.Add(this.panelOptions);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelProjectName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 450);
            this.panel1.TabIndex = 0;
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.buttonDeleteProject);
            this.panelDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDelete.Location = new System.Drawing.Point(0, 363);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(188, 87);
            this.panelDelete.TabIndex = 12;
            // 
            // buttonDeleteProject
            // 
            this.buttonDeleteProject.BackColor = System.Drawing.Color.Maroon;
            this.buttonDeleteProject.FlatAppearance.BorderSize = 0;
            this.buttonDeleteProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteProject.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteProject.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDeleteProject.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDeleteProject.Location = new System.Drawing.Point(12, 3);
            this.buttonDeleteProject.Name = "buttonDeleteProject";
            this.buttonDeleteProject.Size = new System.Drawing.Size(166, 75);
            this.buttonDeleteProject.TabIndex = 15;
            this.buttonDeleteProject.Text = "Удалить проект";
            this.buttonDeleteProject.UseVisualStyleBackColor = false;
            this.buttonDeleteProject.Click += new System.EventHandler(this.buttonDeleteProject_Click);
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.buttonRename);
            this.panelOptions.Controls.Add(this.buttonAddGroup);
            this.panelOptions.Controls.Add(this.buttonGroupList);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOptions.Enabled = false;
            this.panelOptions.Location = new System.Drawing.Point(0, 169);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(188, 161);
            this.panelOptions.TabIndex = 11;
            this.panelOptions.Visible = false;
            // 
            // buttonRename
            // 
            this.buttonRename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonRename.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRename.FlatAppearance.BorderSize = 0;
            this.buttonRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRename.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRename.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRename.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRename.Location = new System.Drawing.Point(0, 84);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(188, 69);
            this.buttonRename.TabIndex = 14;
            this.buttonRename.Text = "Изменить имя проекта";
            this.buttonRename.UseVisualStyleBackColor = false;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonAddGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddGroup.FlatAppearance.BorderSize = 0;
            this.buttonAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGroup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddGroup.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAddGroup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddGroup.Location = new System.Drawing.Point(0, 42);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(188, 42);
            this.buttonAddGroup.TabIndex = 13;
            this.buttonAddGroup.Text = "Добавить группу";
            this.buttonAddGroup.UseVisualStyleBackColor = false;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // buttonGroupList
            // 
            this.buttonGroupList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonGroupList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGroupList.FlatAppearance.BorderSize = 0;
            this.buttonGroupList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroupList.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGroupList.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonGroupList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGroupList.Location = new System.Drawing.Point(0, 0);
            this.buttonGroupList.Name = "buttonGroupList";
            this.buttonGroupList.Size = new System.Drawing.Size(188, 42);
            this.buttonGroupList.TabIndex = 12;
            this.buttonGroupList.Text = "Список групп";
            this.buttonGroupList.UseVisualStyleBackColor = false;
            this.buttonGroupList.Click += new System.EventHandler(this.buttonGroupList_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSelectProject);
            this.panel2.Controls.Add(this.buttonCreateProject);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 98);
            this.panel2.TabIndex = 10;
            // 
            // buttonSelectProject
            // 
            this.buttonSelectProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonSelectProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSelectProject.FlatAppearance.BorderSize = 0;
            this.buttonSelectProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectProject.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSelectProject.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSelectProject.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSelectProject.Location = new System.Drawing.Point(0, 42);
            this.buttonSelectProject.Name = "buttonSelectProject";
            this.buttonSelectProject.Size = new System.Drawing.Size(188, 42);
            this.buttonSelectProject.TabIndex = 11;
            this.buttonSelectProject.Text = "Выбрать";
            this.buttonSelectProject.UseVisualStyleBackColor = false;
            this.buttonSelectProject.Click += new System.EventHandler(this.buttonSelectProject_Click);
            // 
            // buttonCreateProject
            // 
            this.buttonCreateProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonCreateProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCreateProject.FlatAppearance.BorderSize = 0;
            this.buttonCreateProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateProject.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateProject.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCreateProject.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCreateProject.Location = new System.Drawing.Point(0, 0);
            this.buttonCreateProject.Name = "buttonCreateProject";
            this.buttonCreateProject.Size = new System.Drawing.Size(188, 42);
            this.buttonCreateProject.TabIndex = 10;
            this.buttonCreateProject.Text = "Создать";
            this.buttonCreateProject.UseVisualStyleBackColor = false;
            this.buttonCreateProject.Click += new System.EventHandler(this.buttonCreateGroup_Click);
            // 
            // labelProjectName
            // 
            this.labelProjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.labelProjectName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelProjectName.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProjectName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelProjectName.Location = new System.Drawing.Point(0, 0);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(188, 71);
            this.labelProjectName.TabIndex = 9;
            this.labelProjectName.Text = "Название проекта";
            this.labelProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProjectName.Visible = false;
            // 
            // panelActiveForm
            // 
            this.panelActiveForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActiveForm.Location = new System.Drawing.Point(188, 0);
            this.panelActiveForm.Name = "panelActiveForm";
            this.panelActiveForm.Size = new System.Drawing.Size(612, 450);
            this.panelActiveForm.TabIndex = 1;
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelActiveForm);
            this.Controls.Add(this.panel1);
            this.Name = "Projects";
            this.Text = "PROJECT";
            this.Load += new System.EventHandler(this.Projects_Load);
            this.panel1.ResumeLayout(false);
            this.panelDelete.ResumeLayout(false);
            this.panelOptions.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label labelProjectName;
        private Panel panelDelete;
        private Button buttonDeleteProject;
        private Panel panelOptions;
        private Button buttonAddGroup;
        private Button buttonGroupList;
        private Panel panel2;
        private Button buttonSelectProject;
        private Button buttonCreateProject;
        private Panel panelActiveForm;
        private Button buttonRename;
    }
}