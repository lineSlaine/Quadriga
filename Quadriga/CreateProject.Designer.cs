namespace Quadriga
{
    partial class CreateProject
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
            this.buttonCreate = new System.Windows.Forms.Button();
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
            this.labelSuccessfully.Location = new System.Drawing.Point(334, 77);
            this.labelSuccessfully.Name = "labelSuccessfully";
            this.labelSuccessfully.Size = new System.Drawing.Size(160, 19);
            this.labelSuccessfully.TabIndex = 29;
            this.labelSuccessfully.Text = "Successfully";
            this.labelSuccessfully.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSuccessfully.Visible = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonCreate.FlatAppearance.BorderSize = 0;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreate.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCreate.Location = new System.Drawing.Point(334, 33);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(160, 41);
            this.buttonCreate.TabIndex = 27;
            this.buttonCreate.Text = "Create project";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelIncorrectName
            // 
            this.labelIncorrectName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIncorrectName.AutoSize = true;
            this.labelIncorrectName.BackColor = System.Drawing.Color.Transparent;
            this.labelIncorrectName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIncorrectName.ForeColor = System.Drawing.Color.IndianRed;
            this.labelIncorrectName.Location = new System.Drawing.Point(38, 77);
            this.labelIncorrectName.Name = "labelIncorrectName";
            this.labelIncorrectName.Size = new System.Drawing.Size(101, 19);
            this.labelIncorrectName.TabIndex = 26;
            this.labelIncorrectName.Text = "Incorrect name";
            this.labelIncorrectName.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // textUsername
            // 
            this.textUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUsername.Location = new System.Drawing.Point(38, 51);
            this.textUsername.Name = "textUsername";
            this.textUsername.PlaceholderText = "  Name";
            this.textUsername.Size = new System.Drawing.Size(256, 23);
            this.textUsername.TabIndex = 24;
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 411);
            this.Controls.Add(this.labelSuccessfully);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelIncorrectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUsername);
            this.Name = "CreateProject";
            this.Text = "CreateProject";
            this.Load += new System.EventHandler(this.CreateProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSuccessfully;
        private Button buttonCreate;
        private Label labelIncorrectName;
        private Label label1;
        private TextBox textUsername;
    }
}