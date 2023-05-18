namespace Quadriga
{
    partial class Settings
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
            this.panelMenuSet = new System.Windows.Forms.Panel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.panelActiveForm = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panelMenuSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuSet
            // 
            this.panelMenuSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            this.panelMenuSet.Controls.Add(this.buttonLogOut);
            this.panelMenuSet.Controls.Add(this.buttonProfile);
            this.panelMenuSet.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuSet.Location = new System.Drawing.Point(0, 0);
            this.panelMenuSet.Name = "panelMenuSet";
            this.panelMenuSet.Size = new System.Drawing.Size(176, 495);
            this.panelMenuSet.TabIndex = 0;
            // 
            // buttonProfile
            // 
            this.buttonProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProfile.Location = new System.Drawing.Point(0, 0);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(176, 52);
            this.buttonProfile.TabIndex = 1;
            this.buttonProfile.Text = " Profile";
            this.buttonProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // panelActiveForm
            // 
            this.panelActiveForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActiveForm.Location = new System.Drawing.Point(176, 0);
            this.panelActiveForm.Name = "panelActiveForm";
            this.panelActiveForm.Size = new System.Drawing.Size(653, 495);
            this.panelActiveForm.TabIndex = 1;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLogOut.Location = new System.Drawing.Point(0, 443);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(176, 52);
            this.buttonLogOut.TabIndex = 2;
            this.buttonLogOut.Text = " Log Out";
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 495);
            this.Controls.Add(this.panelActiveForm);
            this.Controls.Add(this.panelMenuSet);
            this.Name = "Settings";
            this.Text = "SETTINGS";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panelMenuSet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenuSet;
        private Button buttonProfile;
        private Panel panelActiveForm;
        private Button buttonLogOut;
    }
}