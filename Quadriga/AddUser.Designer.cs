namespace Quadriga
{
    partial class AddUser
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
            this.labelIncorrectEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelSuccessfully = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIncorrectEmail
            // 
            this.labelIncorrectEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIncorrectEmail.AutoSize = true;
            this.labelIncorrectEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelIncorrectEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIncorrectEmail.ForeColor = System.Drawing.Color.IndianRed;
            this.labelIncorrectEmail.Location = new System.Drawing.Point(52, 109);
            this.labelIncorrectEmail.Name = "labelIncorrectEmail";
            this.labelIncorrectEmail.Size = new System.Drawing.Size(99, 19);
            this.labelIncorrectEmail.TabIndex = 19;
            this.labelIncorrectEmail.Text = "Incorrect Email";
            this.labelIncorrectEmail.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Email";
            // 
            // textUsername
            // 
            this.textUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUsername.Location = new System.Drawing.Point(52, 83);
            this.textUsername.Name = "textUsername";
            this.textUsername.PlaceholderText = "  Email";
            this.textUsername.Size = new System.Drawing.Size(256, 23);
            this.textUsername.TabIndex = 17;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonAddUser.FlatAppearance.BorderSize = 0;
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAddUser.Location = new System.Drawing.Point(348, 65);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(160, 41);
            this.buttonAddUser.TabIndex = 20;
            this.buttonAddUser.Text = "Add user";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelError.Location = new System.Drawing.Point(27, 34);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(540, 19);
            this.labelError.TabIndex = 22;
            this.labelError.Text = "The user does not exist.";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelError.Visible = false;
            // 
            // labelSuccessfully
            // 
            this.labelSuccessfully.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSuccessfully.BackColor = System.Drawing.Color.Transparent;
            this.labelSuccessfully.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSuccessfully.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelSuccessfully.Location = new System.Drawing.Point(27, 153);
            this.labelSuccessfully.Name = "labelSuccessfully";
            this.labelSuccessfully.Size = new System.Drawing.Size(540, 19);
            this.labelSuccessfully.TabIndex = 23;
            this.labelSuccessfully.Text = "Successfully";
            this.labelSuccessfully.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSuccessfully.Visible = false;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 417);
            this.Controls.Add(this.labelSuccessfully);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.labelIncorrectEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUsername);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelIncorrectEmail;
        private Label label1;
        private TextBox textUsername;
        private Button buttonAddUser;
        private Label labelError;
        private Label labelSuccessfully;
    }
}