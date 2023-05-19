namespace Quadriga
{
    partial class ListOfPeople
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.labelError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 51);
            this.panel1.TabIndex = 0;
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
            this.buttonDelete.Size = new System.Drawing.Size(210, 51);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Remove from group";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
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
            this.listBox.Location = new System.Drawing.Point(0, 51);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(813, 405);
            this.listBox.TabIndex = 3;
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelError.Location = new System.Drawing.Point(226, 20);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(158, 19);
            this.labelError.TabIndex = 18;
            this.labelError.Text = "You can\'t delete yourself";
            this.labelError.Visible = false;
            // 
            // ListOfPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 456);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.panel1);
            this.Name = "ListOfPeople";
            this.Text = "LIST OF PEOPLE";
            this.Load += new System.EventHandler(this.ListOfPeople_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonDelete;
        private ListBox listBox;
        private Label labelError;
    }
}