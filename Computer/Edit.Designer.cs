using System;
using System.Windows.Forms;

namespace Computer
{
    partial class Edit
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
            this.SearchBox = new System.Windows.Forms.Button();
            this.Configurations = new System.Windows.Forms.GroupBox();
            this.ConfigOpions = new System.Windows.Forms.CheckedListBox();
            this.computerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerDataSet = new Computer.ComputerDataSet();
            this.Reset = new System.Windows.Forms.Button();
            this.but_update = new System.Windows.Forms.Button();
            this.SelectArea = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.AreaChoosingBox = new System.Windows.Forms.ComboBox();
            this.AreaOrRoom = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Mainheading = new System.Windows.Forms.Label();
            this.but_back = new System.Windows.Forms.Button();
            this.Configurations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDataSet)).BeginInit();
            this.AreaOrRoom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.OrangeRed;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBox.FlatAppearance.BorderSize = 0;
            this.SearchBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.SearchBox.ForeColor = System.Drawing.Color.White;
            this.SearchBox.Location = new System.Drawing.Point(1250, 91);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(108, 31);
            this.SearchBox.TabIndex = 10;
            this.SearchBox.Text = "Search";
            this.SearchBox.UseVisualStyleBackColor = false;
            this.SearchBox.Click += new System.EventHandler(this.SearchBox_Click);
            // 
            // Configurations
            // 
            this.Configurations.Controls.Add(this.ConfigOpions);
            this.Configurations.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.Configurations.ForeColor = System.Drawing.Color.White;
            this.Configurations.Location = new System.Drawing.Point(679, 119);
            this.Configurations.Name = "Configurations";
            this.Configurations.Size = new System.Drawing.Size(635, 344);
            this.Configurations.TabIndex = 12;
            this.Configurations.TabStop = false;
            this.Configurations.Text = "Configurations";
            // 
            // ConfigOpions
            // 
            this.ConfigOpions.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.ConfigOpions.FormattingEnabled = true;
            this.ConfigOpions.Location = new System.Drawing.Point(6, 28);
            this.ConfigOpions.MultiColumn = true;
            this.ConfigOpions.Name = "ConfigOpions";
            this.ConfigOpions.ScrollAlwaysVisible = true;
            this.ConfigOpions.Size = new System.Drawing.Size(623, 304);
            this.ConfigOpions.TabIndex = 0;
            // 
            // computerDataSetBindingSource
            // 
            this.computerDataSetBindingSource.DataSource = this.computerDataSet;
            this.computerDataSetBindingSource.Position = 0;
            // 
            // computerDataSet
            // 
            this.computerDataSet.DataSetName = "ComputerDataSet";
            this.computerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Red;
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.FlatAppearance.BorderSize = 0;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.Reset.ForeColor = System.Drawing.Color.White;
            this.Reset.Location = new System.Drawing.Point(739, 541);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(101, 31);
            this.Reset.TabIndex = 14;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // but_update
            // 
            this.but_update.BackColor = System.Drawing.Color.Red;
            this.but_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_update.FlatAppearance.BorderSize = 0;
            this.but_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_update.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.but_update.ForeColor = System.Drawing.Color.White;
            this.but_update.Location = new System.Drawing.Point(507, 541);
            this.but_update.Name = "but_update";
            this.but_update.Size = new System.Drawing.Size(101, 31);
            this.but_update.TabIndex = 15;
            this.but_update.Text = "Update";
            this.but_update.UseVisualStyleBackColor = false;
            this.but_update.Click += new System.EventHandler(this.but_update_Click);
            // 
            // SelectArea
            // 
            this.SelectArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectArea.AutoSize = true;
            this.SelectArea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectArea.Location = new System.Drawing.Point(46, 71);
            this.SelectArea.Name = "SelectArea";
            this.SelectArea.Size = new System.Drawing.Size(103, 19);
            this.SelectArea.TabIndex = 3;
            this.SelectArea.Text = "Room / Area :";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(46, 151);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(106, 19);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Device Name :";
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(172, 150);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(165, 29);
            this.SearchName.TabIndex = 12;
            // 
            // AreaChoosingBox
            // 
            this.AreaChoosingBox.FormattingEnabled = true;
            this.AreaChoosingBox.Location = new System.Drawing.Point(172, 69);
            this.AreaChoosingBox.Name = "AreaChoosingBox";
            this.AreaChoosingBox.Size = new System.Drawing.Size(165, 29);
            this.AreaChoosingBox.TabIndex = 13;
            this.AreaChoosingBox.SelectedIndexChanged += new System.EventHandler(this.AreaChoosingBox_SelectedIndexChanged);
            // 
            // AreaOrRoom
            // 
            this.AreaOrRoom.Controls.Add(this.AreaChoosingBox);
            this.AreaOrRoom.Controls.Add(this.SearchName);
            this.AreaOrRoom.Controls.Add(this.NameLabel);
            this.AreaOrRoom.Controls.Add(this.SelectArea);
            this.AreaOrRoom.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.AreaOrRoom.ForeColor = System.Drawing.Color.White;
            this.AreaOrRoom.Location = new System.Drawing.Point(23, 119);
            this.AreaOrRoom.Name = "AreaOrRoom";
            this.AreaOrRoom.Size = new System.Drawing.Size(478, 246);
            this.AreaOrRoom.TabIndex = 11;
            this.AreaOrRoom.TabStop = false;
            this.AreaOrRoom.Text = "Area / Room";
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
            this.panel2.TabIndex = 23;
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
            this.panel1.Controls.Add(this.AreaOrRoom);
            this.panel1.Controls.Add(this.Configurations);
            this.panel1.Controls.Add(this.but_update);
            this.panel1.Controls.Add(this.Mainheading);
            this.panel1.Controls.Add(this.Reset);
            this.panel1.Location = new System.Drawing.Point(12, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 600);
            this.panel1.TabIndex = 24;
            // 
            // Mainheading
            // 
            this.Mainheading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mainheading.AutoSize = true;
            this.Mainheading.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.Mainheading.ForeColor = System.Drawing.Color.White;
            this.Mainheading.Location = new System.Drawing.Point(488, 22);
            this.Mainheading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mainheading.Name = "Mainheading";
            this.Mainheading.Size = new System.Drawing.Size(371, 25);
            this.Mainheading.TabIndex = 6;
            this.Mainheading.Text = "Enter the Device Name and Specifications";
            // 
            // but_back
            // 
            this.but_back.BackColor = System.Drawing.Color.OrangeRed;
            this.but_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_back.FlatAppearance.BorderSize = 0;
            this.but_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_back.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.but_back.ForeColor = System.Drawing.Color.White;
            this.but_back.Location = new System.Drawing.Point(12, 91);
            this.but_back.Name = "but_back";
            this.but_back.Size = new System.Drawing.Size(101, 31);
            this.but_back.TabIndex = 31;
            this.but_back.Text = "Back";
            this.but_back.UseVisualStyleBackColor = false;
            this.but_back.Click += new System.EventHandler(this.but_back_Click_1);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.but_back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SearchBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Edit";
            this.Text = "Manage Configurations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Configurations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.computerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDataSet)).EndInit();
            this.AreaOrRoom.ResumeLayout(false);
            this.AreaOrRoom.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        

        private void AreaChoosingBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        

 

        #endregion
        private System.Windows.Forms.Button SearchBox;
        private System.Windows.Forms.GroupBox Configurations;
        private System.Windows.Forms.CheckedListBox ConfigOpions;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button but_update;
        private BindingSource computerDataSetBindingSource;
        private ComputerDataSet computerDataSet;
        private Label SelectArea;
        private Label NameLabel;
        private TextBox SearchName;
        private ComboBox AreaChoosingBox;
        private GroupBox AreaOrRoom;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Label Mainheading;
        private Button but_back;
    }
}