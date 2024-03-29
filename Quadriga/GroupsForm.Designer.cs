﻿namespace Quadriga
{
    partial class GroupsForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textGroupName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.panelCreate = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonAddGroup.FlatAppearance.BorderSize = 0;
            this.buttonAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGroup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddGroup.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAddGroup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddGroup.Location = new System.Drawing.Point(12, 6);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(166, 70);
            this.buttonAddGroup.TabIndex = 8;
            this.buttonAddGroup.Text = "Создать группу";
            this.buttonAddGroup.UseVisualStyleBackColor = false;
            this.buttonAddGroup.Click += new System.EventHandler(this.ButtonAddGroup_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(188, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 450);
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
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(612, 450);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            this.panel3.Controls.Add(this.textGroupName);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panelCreate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 450);
            this.panel3.TabIndex = 2;
            // 
            // textGroupName
            // 
            this.textGroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textGroupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textGroupName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textGroupName.Location = new System.Drawing.Point(0, 339);
            this.textGroupName.Name = "textGroupName";
            this.textGroupName.PlaceholderText = "  Имя группы";
            this.textGroupName.Size = new System.Drawing.Size(188, 23);
            this.textGroupName.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.buttonSelect);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(188, 100);
            this.panel5.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Веберете группу";
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonSelect.FlatAppearance.BorderSize = 0;
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelect.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSelect.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSelect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSelect.Location = new System.Drawing.Point(12, 45);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(166, 42);
            this.buttonSelect.TabIndex = 9;
            this.buttonSelect.Text = "Выбрать";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // panelCreate
            // 
            this.panelCreate.Controls.Add(this.buttonAddGroup);
            this.panelCreate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCreate.Location = new System.Drawing.Point(0, 362);
            this.panelCreate.Name = "panelCreate";
            this.panelCreate.Size = new System.Drawing.Size(188, 88);
            this.panelCreate.TabIndex = 10;
            // 
            // GroupsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "GroupsForm";
            this.Text = "ВЫБОР ГРУППЫ";
            this.Load += new System.EventHandler(this.GroupsForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelCreate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonAddGroup;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Button buttonSelect;
        private Panel panel1;
        private ListBox listBox;
        private TextBox textGroupName;
        private Panel panel5;
        private Panel panelCreate;
    }
}