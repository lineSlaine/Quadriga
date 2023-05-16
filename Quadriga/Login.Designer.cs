namespace Quadriga
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panellogo = new System.Windows.Forms.Panel();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelIncorrectEmail = new System.Windows.Forms.Label();
            this.labelIncorrectPass = new System.Windows.Forms.Label();
            this.checkRemember = new System.Windows.Forms.CheckBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panellogo);
            this.panel1.Controls.Add(this.labelSignUp);
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Controls.Add(this.labelIncorrectEmail);
            this.panel1.Controls.Add(this.labelIncorrectPass);
            this.panel1.Controls.Add(this.checkRemember);
            this.panel1.Controls.Add(this.buttonEnter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textPassword);
            this.panel1.Controls.Add(this.textUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 495);
            this.panel1.TabIndex = 0;
            // 
            // panellogo
            // 
            this.panellogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panellogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panellogo.BackgroundImage")));
            this.panellogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panellogo.Location = new System.Drawing.Point(285, 17);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(258, 115);
            this.panellogo.TabIndex = 11;
            // 
            // labelSignUp
            // 
            this.labelSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.BackColor = System.Drawing.Color.Transparent;
            this.labelSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelSignUp.ForeColor = System.Drawing.Color.Black;
            this.labelSignUp.Location = new System.Drawing.Point(383, 431);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(63, 21);
            this.labelSignUp.TabIndex = 10;
            this.labelSignUp.Text = "Sign up";
            this.labelSignUp.Click += new System.EventHandler(this.LabelSignUp_Click);
            this.labelSignUp.MouseEnter += new System.EventHandler(this.LabelSignUp_MouseEnter);
            this.labelSignUp.MouseLeave += new System.EventHandler(this.LabelSignUp_MouseLeave);
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelError.Location = new System.Drawing.Point(144, 302);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(540, 19);
            this.labelError.TabIndex = 9;
            this.labelError.Text = "Incorrect Email or Password";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelError.Visible = false;
            // 
            // labelIncorrectEmail
            // 
            this.labelIncorrectEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIncorrectEmail.AutoSize = true;
            this.labelIncorrectEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelIncorrectEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIncorrectEmail.ForeColor = System.Drawing.Color.IndianRed;
            this.labelIncorrectEmail.Location = new System.Drawing.Point(286, 192);
            this.labelIncorrectEmail.Name = "labelIncorrectEmail";
            this.labelIncorrectEmail.Size = new System.Drawing.Size(99, 19);
            this.labelIncorrectEmail.TabIndex = 8;
            this.labelIncorrectEmail.Text = "Incorrect Email";
            this.labelIncorrectEmail.Visible = false;
            // 
            // labelIncorrectPass
            // 
            this.labelIncorrectPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIncorrectPass.AutoSize = true;
            this.labelIncorrectPass.BackColor = System.Drawing.Color.Transparent;
            this.labelIncorrectPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIncorrectPass.ForeColor = System.Drawing.Color.IndianRed;
            this.labelIncorrectPass.Location = new System.Drawing.Point(284, 274);
            this.labelIncorrectPass.Name = "labelIncorrectPass";
            this.labelIncorrectPass.Size = new System.Drawing.Size(125, 19);
            this.labelIncorrectPass.TabIndex = 7;
            this.labelIncorrectPass.Text = "Incorrect Password";
            this.labelIncorrectPass.Visible = false;
            // 
            // checkRemember
            // 
            this.checkRemember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkRemember.AutoSize = true;
            this.checkRemember.FlatAppearance.BorderSize = 0;
            this.checkRemember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkRemember.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkRemember.Location = new System.Drawing.Point(286, 324);
            this.checkRemember.Name = "checkRemember";
            this.checkRemember.Size = new System.Drawing.Size(123, 24);
            this.checkRemember.TabIndex = 6;
            this.checkRemember.Text = "Remember me";
            this.checkRemember.UseVisualStyleBackColor = true;
            this.checkRemember.CheckedChanged += new System.EventHandler(this.checkRemember_CheckedChanged);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonEnter.FlatAppearance.BorderSize = 0;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEnter.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEnter.Location = new System.Drawing.Point(286, 354);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(256, 61);
            this.buttonEnter.TabIndex = 4;
            this.buttonEnter.Text = "Login";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(286, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(286, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // textPassword
            // 
            this.textPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.Location = new System.Drawing.Point(286, 248);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.PlaceholderText = "  Password";
            this.textPassword.Size = new System.Drawing.Size(256, 23);
            this.textPassword.TabIndex = 1;
            // 
            // textUsername
            // 
            this.textUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUsername.Location = new System.Drawing.Point(286, 166);
            this.textUsername.Name = "textUsername";
            this.textUsername.PlaceholderText = "  Email";
            this.textUsername.Size = new System.Drawing.Size(256, 23);
            this.textUsername.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 495);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "LOGIN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonEnter;
        private Label label2;
        private Label label1;
        private TextBox textPassword;
        private TextBox textUsername;
        private CheckBox checkRemember;
        private Label labelIncorrectPass;
        private Label labelIncorrectEmail;
        private Label labelError;
        private Label labelSignUp;
        private Panel panellogo;
    }
}