﻿namespace Quadriga
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
            this.buttonGeneralSetting = new System.Windows.Forms.Button();
            this.panelMenuSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuSet
            // 
            this.panelMenuSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            this.panelMenuSet.Controls.Add(this.buttonGeneralSetting);
            this.panelMenuSet.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuSet.Location = new System.Drawing.Point(0, 0);
            this.panelMenuSet.Name = "panelMenuSet";
            this.panelMenuSet.Size = new System.Drawing.Size(176, 495);
            this.panelMenuSet.TabIndex = 0;
            // 
            // buttonGeneralSetting
            // 
            this.buttonGeneralSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGeneralSetting.FlatAppearance.BorderSize = 0;
            this.buttonGeneralSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeneralSetting.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGeneralSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonGeneralSetting.Location = new System.Drawing.Point(0, 0);
            this.buttonGeneralSetting.Name = "buttonGeneralSetting";
            this.buttonGeneralSetting.Size = new System.Drawing.Size(176, 52);
            this.buttonGeneralSetting.TabIndex = 0;
            this.buttonGeneralSetting.Text = " General";
            this.buttonGeneralSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGeneralSetting.UseVisualStyleBackColor = true;
            this.buttonGeneralSetting.Click += new System.EventHandler(this.ButtonGeneralSetting_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 495);
            this.Controls.Add(this.panelMenuSet);
            this.Name = "Settings";
            this.Text = "SETTINGS";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panelMenuSet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenuSet;
        private Button buttonGeneralSetting;
    }
}