namespace Quadriga
{
    partial class RenameGroup
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
            this.buttonEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelSuccessfully = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEnter
            // 
            this.buttonEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonEnter.FlatAppearance.BorderSize = 0;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEnter.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEnter.Location = new System.Drawing.Point(322, 55);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(256, 61);
            this.buttonEnter.TabIndex = 7;
            this.buttonEnter.Text = "Update";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "New Group name";
            // 
            // textName
            // 
            this.textName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textName.Location = new System.Drawing.Point(33, 93);
            this.textName.Name = "textName";
            this.textName.PlaceholderText = "  Group name";
            this.textName.Size = new System.Drawing.Size(256, 23);
            this.textName.TabIndex = 5;
            // 
            // labelSuccessfully
            // 
            this.labelSuccessfully.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSuccessfully.BackColor = System.Drawing.Color.Transparent;
            this.labelSuccessfully.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSuccessfully.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelSuccessfully.Location = new System.Drawing.Point(33, 137);
            this.labelSuccessfully.Name = "labelSuccessfully";
            this.labelSuccessfully.Size = new System.Drawing.Size(540, 19);
            this.labelSuccessfully.TabIndex = 24;
            this.labelSuccessfully.Text = "Successfully";
            this.labelSuccessfully.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSuccessfully.Visible = false;
            // 
            // RenameGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 417);
            this.Controls.Add(this.labelSuccessfully);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Name = "RenameGroup";
            this.Text = "RenameGroup";
            this.Load += new System.EventHandler(this.RenameGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEnter;
        private Label label1;
        private TextBox textName;
        private Label labelSuccessfully;
    }
}