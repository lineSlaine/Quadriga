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
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.textGroupName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonAddGroup.FlatAppearance.BorderSize = 0;
            this.buttonAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGroup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddGroup.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAddGroup.Location = new System.Drawing.Point(40, 341);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(256, 61);
            this.buttonAddGroup.TabIndex = 6;
            this.buttonAddGroup.Text = "Create new group";
            this.buttonAddGroup.UseVisualStyleBackColor = false;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // textGroupName
            // 
            this.textGroupName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textGroupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textGroupName.Location = new System.Drawing.Point(40, 291);
            this.textGroupName.Name = "textGroupName";
            this.textGroupName.PlaceholderText = "  Group name";
            this.textGroupName.Size = new System.Drawing.Size(256, 23);
            this.textGroupName.TabIndex = 7;
            // 
            // Group_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 456);
            this.Controls.Add(this.textGroupName);
            this.Controls.Add(this.buttonAddGroup);
            this.Name = "Group_settings";
            this.Text = "Group_settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAddGroup;
        private TextBox textGroupName;
    }
}