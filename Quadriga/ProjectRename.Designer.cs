namespace Quadriga
{
    partial class ProjectRename
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
            this.labelSuccessfully = new System.Windows.Forms.Label();
            this.buttonRename = new System.Windows.Forms.Button();
            this.labelIncorrectName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSuccessfully
            // 
            this.labelSuccessfully.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSuccessfully.BackColor = System.Drawing.Color.Transparent;
            this.labelSuccessfully.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSuccessfully.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelSuccessfully.Location = new System.Drawing.Point(325, 84);
            this.labelSuccessfully.Name = "labelSuccessfully";
            this.labelSuccessfully.Size = new System.Drawing.Size(160, 19);
            this.labelSuccessfully.TabIndex = 34;
            this.labelSuccessfully.Text = "Успешно";
            this.labelSuccessfully.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSuccessfully.Visible = false;
            // 
            // buttonRename
            // 
            this.buttonRename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonRename.FlatAppearance.BorderSize = 0;
            this.buttonRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRename.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRename.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRename.Location = new System.Drawing.Point(325, 40);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(160, 41);
            this.buttonRename.TabIndex = 33;
            this.buttonRename.Text = "Изменить";
            this.buttonRename.UseVisualStyleBackColor = false;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // labelIncorrectName
            // 
            this.labelIncorrectName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIncorrectName.AutoSize = true;
            this.labelIncorrectName.BackColor = System.Drawing.Color.Transparent;
            this.labelIncorrectName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIncorrectName.ForeColor = System.Drawing.Color.IndianRed;
            this.labelIncorrectName.Location = new System.Drawing.Point(29, 84);
            this.labelIncorrectName.Name = "labelIncorrectName";
            this.labelIncorrectName.Size = new System.Drawing.Size(133, 19);
            this.labelIncorrectName.TabIndex = 32;
            this.labelIncorrectName.Text = "Неверное название";
            this.labelIncorrectName.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Название";
            // 
            // textUsername
            // 
            this.textUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUsername.Location = new System.Drawing.Point(29, 58);
            this.textUsername.Name = "textUsername";
            this.textUsername.PlaceholderText = "  Name";
            this.textUsername.Size = new System.Drawing.Size(256, 23);
            this.textUsername.TabIndex = 30;
            // 
            // ProjectRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 411);
            this.Controls.Add(this.labelSuccessfully);
            this.Controls.Add(this.buttonRename);
            this.Controls.Add(this.labelIncorrectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUsername);
            this.Name = "ProjectRename";
            this.Text = "ProjectRename";
            this.Load += new System.EventHandler(this.ProjectRename_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSuccessfully;
        private Button buttonRename;
        private Label labelIncorrectName;
        private Label label1;
        private TextBox textUsername;
    }
}