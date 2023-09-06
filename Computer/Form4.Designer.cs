namespace Computer
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.SelectOption = new System.Windows.Forms.GroupBox();
            this.Manual = new System.Windows.Forms.RadioButton();
            this.AllRecords = new System.Windows.Forms.RadioButton();
            this.SearchGroup = new System.Windows.Forms.GroupBox();
            this.but_search = new System.Windows.Forms.Button();
            this.RoomSelection = new System.Windows.Forms.ComboBox();
            this.NameSearchBox = new System.Windows.Forms.TextBox();
            this.NameSearchLabel = new System.Windows.Forms.Label();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.RecordList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Mainheading = new System.Windows.Forms.Label();
            this.NewBox = new System.Windows.Forms.Button();
            this.but_home = new System.Windows.Forms.Button();
            this.but_back = new System.Windows.Forms.Button();
            this.SelectOption.SuspendLayout();
            this.SearchGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectOption
            // 
            this.SelectOption.Controls.Add(this.Manual);
            this.SelectOption.Controls.Add(this.AllRecords);
            this.SelectOption.ForeColor = System.Drawing.Color.White;
            this.SelectOption.Location = new System.Drawing.Point(52, 53);
            this.SelectOption.Margin = new System.Windows.Forms.Padding(4);
            this.SelectOption.Name = "SelectOption";
            this.SelectOption.Padding = new System.Windows.Forms.Padding(4);
            this.SelectOption.Size = new System.Drawing.Size(429, 167);
            this.SelectOption.TabIndex = 19;
            this.SelectOption.TabStop = false;
            this.SelectOption.Text = "Select One Option";
            // 
            // Manual
            // 
            this.Manual.AutoSize = true;
            this.Manual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Manual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manual.Location = new System.Drawing.Point(240, 55);
            this.Manual.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Manual.Name = "Manual";
            this.Manual.Size = new System.Drawing.Size(141, 25);
            this.Manual.TabIndex = 17;
            this.Manual.TabStop = true;
            this.Manual.Text = "Manual Search";
            this.Manual.UseVisualStyleBackColor = true;
            this.Manual.CheckedChanged += new System.EventHandler(this.Manual_CheckedChanged_1);
            // 
            // AllRecords
            // 
            this.AllRecords.AutoSize = true;
            this.AllRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllRecords.Location = new System.Drawing.Point(39, 55);
            this.AllRecords.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.AllRecords.Name = "AllRecords";
            this.AllRecords.Size = new System.Drawing.Size(113, 25);
            this.AllRecords.TabIndex = 16;
            this.AllRecords.TabStop = true;
            this.AllRecords.Text = "All Records";
            this.AllRecords.UseVisualStyleBackColor = true;
            this.AllRecords.CheckedChanged += new System.EventHandler(this.AllRecords_CheckedChanged);
            // 
            // SearchGroup
            // 
            this.SearchGroup.Controls.Add(this.but_search);
            this.SearchGroup.Controls.Add(this.RoomSelection);
            this.SearchGroup.Controls.Add(this.NameSearchBox);
            this.SearchGroup.Controls.Add(this.NameSearchLabel);
            this.SearchGroup.Controls.Add(this.RoomLabel);
            this.SearchGroup.ForeColor = System.Drawing.Color.White;
            this.SearchGroup.Location = new System.Drawing.Point(792, 53);
            this.SearchGroup.Margin = new System.Windows.Forms.Padding(4);
            this.SearchGroup.Name = "SearchGroup";
            this.SearchGroup.Padding = new System.Windows.Forms.Padding(4);
            this.SearchGroup.Size = new System.Drawing.Size(490, 167);
            this.SearchGroup.TabIndex = 20;
            this.SearchGroup.TabStop = false;
            this.SearchGroup.Text = "Search The Record";
            // 
            // but_search
            // 
            this.but_search.BackColor = System.Drawing.Color.OrangeRed;
            this.but_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_search.FlatAppearance.BorderSize = 0;
            this.but_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_search.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.but_search.ForeColor = System.Drawing.Color.White;
            this.but_search.Location = new System.Drawing.Point(206, 120);
            this.but_search.Name = "but_search";
            this.but_search.Size = new System.Drawing.Size(101, 31);
            this.but_search.TabIndex = 29;
            this.but_search.Text = "Search";
            this.but_search.UseVisualStyleBackColor = false;
            this.but_search.Click += new System.EventHandler(this.but_search_Click);
            // 
            // RoomSelection
            // 
            this.RoomSelection.FormattingEnabled = true;
            this.RoomSelection.Location = new System.Drawing.Point(249, 24);
            this.RoomSelection.Margin = new System.Windows.Forms.Padding(4);
            this.RoomSelection.Name = "RoomSelection";
            this.RoomSelection.Size = new System.Drawing.Size(219, 25);
            this.RoomSelection.TabIndex = 13;
            this.RoomSelection.SelectedIndexChanged += new System.EventHandler(this.RoomSelection_SelectedIndexChanged);
            // 
            // NameSearchBox
            // 
            this.NameSearchBox.Location = new System.Drawing.Point(249, 74);
            this.NameSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameSearchBox.Name = "NameSearchBox";
            this.NameSearchBox.Size = new System.Drawing.Size(219, 25);
            this.NameSearchBox.TabIndex = 12;
            this.NameSearchBox.TextChanged += new System.EventHandler(this.NameSearchBox_TextChanged);
            // 
            // NameSearchLabel
            // 
            this.NameSearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameSearchLabel.AutoSize = true;
            this.NameSearchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSearchLabel.Location = new System.Drawing.Point(32, 74);
            this.NameSearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameSearchLabel.Name = "NameSearchLabel";
            this.NameSearchLabel.Size = new System.Drawing.Size(57, 19);
            this.NameSearchLabel.TabIndex = 4;
            this.NameSearchLabel.Text = "Name :";
            // 
            // RoomLabel
            // 
            this.RoomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomLabel.Location = new System.Drawing.Point(32, 27);
            this.RoomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(103, 19);
            this.RoomLabel.TabIndex = 3;
            this.RoomLabel.Text = "Room / Area :";
            // 
            // RecordList
            // 
            this.RecordList.AllowUserToAddRows = false;
            this.RecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordList.ContextMenuStrip = this.contextMenuStrip1;
            this.RecordList.Location = new System.Drawing.Point(52, 228);
            this.RecordList.Margin = new System.Windows.Forms.Padding(4);
            this.RecordList.Name = "RecordList";
            this.RecordList.Size = new System.Drawing.Size(1230, 378);
            this.RecordList.TabIndex = 24;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
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
            this.panel2.TabIndex = 25;
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
            this.panel1.Controls.Add(this.Mainheading);
            this.panel1.Controls.Add(this.SelectOption);
            this.panel1.Controls.Add(this.RecordList);
            this.panel1.Controls.Add(this.SearchGroup);
            this.panel1.Location = new System.Drawing.Point(12, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 620);
            this.panel1.TabIndex = 26;
            // 
            // Mainheading
            // 
            this.Mainheading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mainheading.AutoSize = true;
            this.Mainheading.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.Mainheading.ForeColor = System.Drawing.Color.White;
            this.Mainheading.Location = new System.Drawing.Point(573, 13);
            this.Mainheading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mainheading.Name = "Mainheading";
            this.Mainheading.Size = new System.Drawing.Size(201, 25);
            this.Mainheading.TabIndex = 6;
            this.Mainheading.Text = "Search / View Records";
            // 
            // NewBox
            // 
            this.NewBox.BackColor = System.Drawing.Color.OrangeRed;
            this.NewBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewBox.FlatAppearance.BorderSize = 0;
            this.NewBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.NewBox.ForeColor = System.Drawing.Color.White;
            this.NewBox.Location = new System.Drawing.Point(1254, 80);
            this.NewBox.Name = "NewBox";
            this.NewBox.Size = new System.Drawing.Size(101, 31);
            this.NewBox.TabIndex = 27;
            this.NewBox.Text = "New";
            this.NewBox.UseVisualStyleBackColor = false;
            this.NewBox.Click += new System.EventHandler(this.NewBox_Click);
            // 
            // but_home
            // 
            this.but_home.BackColor = System.Drawing.Color.OrangeRed;
            this.but_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_home.FlatAppearance.BorderSize = 0;
            this.but_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_home.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.but_home.ForeColor = System.Drawing.Color.White;
            this.but_home.Location = new System.Drawing.Point(12, 80);
            this.but_home.Name = "but_home";
            this.but_home.Size = new System.Drawing.Size(101, 31);
            this.but_home.TabIndex = 28;
            this.but_home.Text = "Home";
            this.but_home.UseVisualStyleBackColor = false;
            this.but_home.Click += new System.EventHandler(this.but_home_Click);
            // 
            // but_back
            // 
            this.but_back.BackColor = System.Drawing.Color.OrangeRed;
            this.but_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_back.FlatAppearance.BorderSize = 0;
            this.but_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_back.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.but_back.ForeColor = System.Drawing.Color.White;
            this.but_back.Location = new System.Drawing.Point(133, 80);
            this.but_back.Name = "but_back";
            this.but_back.Size = new System.Drawing.Size(101, 31);
            this.but_back.TabIndex = 29;
            this.but_back.Text = "Back";
            this.but_back.UseVisualStyleBackColor = false;
            this.but_back.Click += new System.EventHandler(this.but_back_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.but_back);
            this.Controls.Add(this.but_home);
            this.Controls.Add(this.NewBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.SelectOption.ResumeLayout(false);
            this.SelectOption.PerformLayout();
            this.SearchGroup.ResumeLayout(false);
            this.SearchGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SelectOption;
        private System.Windows.Forms.RadioButton Manual;
        private System.Windows.Forms.RadioButton AllRecords;
        private System.Windows.Forms.GroupBox SearchGroup;
        private System.Windows.Forms.ComboBox RoomSelection;
        private System.Windows.Forms.TextBox NameSearchBox;
        private System.Windows.Forms.Label NameSearchLabel;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Mainheading;
        private System.Windows.Forms.Button NewBox;
        private System.Windows.Forms.DataGridView RecordList;
        private System.Windows.Forms.Button but_search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button but_home;
        private System.Windows.Forms.Button but_back;
    }
}