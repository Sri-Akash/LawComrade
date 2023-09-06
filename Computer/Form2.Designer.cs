namespace Computer
{
    partial class Form2
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
            this.AddName = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameControl = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.RadioButton();
            this.Room = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectCategoryGroup = new System.Windows.Forms.GroupBox();
            this.Mainheading = new System.Windows.Forms.Label();
            this.but_back = new System.Windows.Forms.Button();
            this.but_home = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.roomList = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SelectCategoryGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomList)).BeginInit();
            this.SuspendLayout();
            // 
            // AddName
            // 
            this.AddName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddName.BackColor = System.Drawing.Color.Red;
            this.AddName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddName.FlatAppearance.BorderSize = 0;
            this.AddName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.AddName.ForeColor = System.Drawing.Color.White;
            this.AddName.Location = new System.Drawing.Point(221, 323);
            this.AddName.Margin = new System.Windows.Forms.Padding(4);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(117, 35);
            this.AddName.TabIndex = 17;
            this.AddName.Text = "ADD";
            this.AddName.UseVisualStyleBackColor = false;
            this.AddName.Click += new System.EventHandler(this.AddName_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.OrangeRed;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(1241, 695);
            this.Submit.Margin = new System.Windows.Forms.Padding(4);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(88, 31);
            this.Submit.TabIndex = 15;
            this.Submit.Text = "NEXT";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.NameBox.ForeColor = System.Drawing.Color.Black;
            this.NameBox.Location = new System.Drawing.Point(103, 276);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(351, 29);
            this.NameBox.TabIndex = 14;
            // 
            // NameControl
            // 
            this.NameControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameControl.AutoSize = true;
            this.NameControl.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.NameControl.ForeColor = System.Drawing.Color.White;
            this.NameControl.Location = new System.Drawing.Point(99, 248);
            this.NameControl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameControl.Name = "NameControl";
            this.NameControl.Size = new System.Drawing.Size(158, 21);
            this.NameControl.TabIndex = 13;
            this.NameControl.Text = "Room / Area Name :";
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Area.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.Area.ForeColor = System.Drawing.Color.White;
            this.Area.Location = new System.Drawing.Point(48, 51);
            this.Area.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(62, 25);
            this.Area.TabIndex = 11;
            this.Area.TabStop = true;
            this.Area.Text = "Area";
            this.Area.UseVisualStyleBackColor = true;
            // 
            // Room
            // 
            this.Room.AutoSize = true;
            this.Room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Room.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.Room.ForeColor = System.Drawing.Color.White;
            this.Room.Location = new System.Drawing.Point(220, 51);
            this.Room.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(72, 25);
            this.Room.TabIndex = 10;
            this.Room.TabStop = true;
            this.Room.Text = "Room";
            this.Room.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 64);
            this.panel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(516, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "COMPUTER MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(189)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.SelectCategoryGroup);
            this.panel1.Controls.Add(this.Mainheading);
            this.panel1.Controls.Add(this.AddName);
            this.panel1.Controls.Add(this.NameControl);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Location = new System.Drawing.Point(50, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 412);
            this.panel1.TabIndex = 19;
            // 
            // SelectCategoryGroup
            // 
            this.SelectCategoryGroup.Controls.Add(this.Room);
            this.SelectCategoryGroup.Controls.Add(this.Area);
            this.SelectCategoryGroup.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.SelectCategoryGroup.ForeColor = System.Drawing.Color.White;
            this.SelectCategoryGroup.Location = new System.Drawing.Point(103, 107);
            this.SelectCategoryGroup.Name = "SelectCategoryGroup";
            this.SelectCategoryGroup.Size = new System.Drawing.Size(351, 121);
            this.SelectCategoryGroup.TabIndex = 20;
            this.SelectCategoryGroup.TabStop = false;
            this.SelectCategoryGroup.Text = "Select Option";
            // 
            // Mainheading
            // 
            this.Mainheading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mainheading.AutoSize = true;
            this.Mainheading.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.Mainheading.ForeColor = System.Drawing.Color.White;
            this.Mainheading.Location = new System.Drawing.Point(146, 33);
            this.Mainheading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mainheading.Name = "Mainheading";
            this.Mainheading.Size = new System.Drawing.Size(268, 25);
            this.Mainheading.TabIndex = 14;
            this.Mainheading.Text = "Enter the Room / Area Details";
            // 
            // but_back
            // 
            this.but_back.BackColor = System.Drawing.Color.OrangeRed;
            this.but_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_back.FlatAppearance.BorderSize = 0;
            this.but_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_back.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.but_back.ForeColor = System.Drawing.Color.White;
            this.but_back.Location = new System.Drawing.Point(133, 90);
            this.but_back.Name = "but_back";
            this.but_back.Size = new System.Drawing.Size(101, 31);
            this.but_back.TabIndex = 31;
            this.but_back.Text = "Back";
            this.but_back.UseVisualStyleBackColor = false;
            this.but_back.Click += new System.EventHandler(this.but_back_Click);
            // 
            // but_home
            // 
            this.but_home.BackColor = System.Drawing.Color.OrangeRed;
            this.but_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_home.FlatAppearance.BorderSize = 0;
            this.but_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_home.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.but_home.ForeColor = System.Drawing.Color.White;
            this.but_home.Location = new System.Drawing.Point(12, 90);
            this.but_home.Name = "but_home";
            this.but_home.Size = new System.Drawing.Size(101, 31);
            this.but_home.TabIndex = 30;
            this.but_home.Text = "Home";
            this.but_home.UseVisualStyleBackColor = false;
            this.but_home.Click += new System.EventHandler(this.but_home_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(876, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Available Rooms / Areas";
            // 
            // roomList
            // 
            this.roomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomList.Location = new System.Drawing.Point(765, 175);
            this.roomList.Name = "roomList";
            this.roomList.Size = new System.Drawing.Size(436, 412);
            this.roomList.TabIndex = 33;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomList);
            this.Controls.Add(this.but_back);
            this.Controls.Add(this.but_home);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SelectCategoryGroup.ResumeLayout(false);
            this.SelectCategoryGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddName;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameControl;
        private System.Windows.Forms.RadioButton Area;
        private System.Windows.Forms.RadioButton Room;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox SelectCategoryGroup;
        private System.Windows.Forms.Label Mainheading;
        private System.Windows.Forms.Button but_back;
        private System.Windows.Forms.Button but_home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView roomList;
    }
}