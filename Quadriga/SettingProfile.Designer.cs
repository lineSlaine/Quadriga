namespace Quadriga
{
    partial class SettingProfile
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
            this.buttonDelete.Location = new System.Drawing.Point(12, 406);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(256, 38);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete account";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // SettingProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 456);
            this.Controls.Add(this.buttonDelete);
            this.Name = "SettingProfile";
            this.Text = "SettingProfile";
            this.Click += new System.EventHandler(this.SettingProfile_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonDelete;
    }
}