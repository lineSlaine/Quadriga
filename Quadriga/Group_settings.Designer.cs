namespace Quadriga
{
    partial class Group_settings
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelActive = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.labelGroupName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.Maroon;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDelete.Location = new System.Drawing.Point(12, 16);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(160, 41);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete group";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelActive);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 456);
            this.panel2.TabIndex = 3;
            // 
            // panelActive
            // 
            this.panelActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActive.Location = new System.Drawing.Point(188, 0);
            this.panelActive.Name = "panelActive";
            this.panelActive.Size = new System.Drawing.Size(625, 456);
            this.panelActive.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.labelGroupName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 456);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonDelete);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 387);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 69);
            this.panel3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAddUser);
            this.panel1.Controls.Add(this.buttonDeleteUser);
            this.panel1.Controls.Add(this.buttonRename);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 151);
            this.panel1.TabIndex = 9;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonAddUser.FlatAppearance.BorderSize = 0;
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAddUser.Location = new System.Drawing.Point(12, 7);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(160, 41);
            this.buttonAddUser.TabIndex = 6;
            this.buttonAddUser.Text = "Add new user";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonDeleteUser.FlatAppearance.BorderSize = 0;
            this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDeleteUser.Location = new System.Drawing.Point(12, 54);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(160, 41);
            this.buttonDeleteUser.TabIndex = 7;
            this.buttonDeleteUser.Text = "Delete user";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            // 
            // buttonRename
            // 
            this.buttonRename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonRename.FlatAppearance.BorderSize = 0;
            this.buttonRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRename.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRename.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRename.Location = new System.Drawing.Point(12, 101);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(160, 41);
            this.buttonRename.TabIndex = 5;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = false;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // labelGroupName
            // 
            this.labelGroupName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.labelGroupName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGroupName.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGroupName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelGroupName.Location = new System.Drawing.Point(0, 0);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(188, 71);
            this.labelGroupName.TabIndex = 8;
            this.labelGroupName.Text = "group name";
            this.labelGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Group_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 456);
            this.Controls.Add(this.panel2);
            this.Name = "Group_settings";
            this.Text = "GROUP SETTINGS";
            this.Load += new System.EventHandler(this.Group_settings_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonDelete;
        private Panel panel2;
        private Panel panelActive;
        private Panel panel4;
        private Button buttonAddUser;
        private Button buttonDeleteUser;
        private Button buttonRename;
        private Label labelGroupName;
        private Panel panel3;
        private Panel panel1;
    }
}