namespace Quadriga
{
    partial class ProjectGroupList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 44);
            this.panel1.TabIndex = 3;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 30;
            this.listBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "sefsef"});
            this.listBox.Location = new System.Drawing.Point(0, 44);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(596, 367);
            this.listBox.TabIndex = 4;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelete.Location = new System.Drawing.Point(0, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(272, 44);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete selected group";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ProjectGroupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 411);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.panel1);
            this.Name = "ProjectGroupList";
            this.Text = "ProjectGroupList";
            this.Load += new System.EventHandler(this.ProjectGroupList_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ListBox listBox;
        private Button buttonDelete;
    }
}