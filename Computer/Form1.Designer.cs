namespace Computer
{
    partial class Form1
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
            this.Add = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Label();
            this.Mainheading = new System.Windows.Forms.Label();
            this.OptionBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.but_home = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.BackColor = System.Drawing.Color.Red;
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(176, 179);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(114, 35);
            this.Add.TabIndex = 9;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Submit
            // 
            this.Submit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Submit.BackColor = System.Drawing.Color.OrangeRed;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(1253, 685);
            this.Submit.Margin = new System.Windows.Forms.Padding(4);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(86, 34);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "NEXT";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click_1);
            // 
            // Options
            // 
            this.Options.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Options.AutoSize = true;
            this.Options.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.Options.ForeColor = System.Drawing.Color.White;
            this.Options.Location = new System.Drawing.Point(94, 84);
            this.Options.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(76, 21);
            this.Options.TabIndex = 7;
            this.Options.Text = "Options :";
            // 
            // Mainheading
            // 
            this.Mainheading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mainheading.AutoSize = true;
            this.Mainheading.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold);
            this.Mainheading.ForeColor = System.Drawing.Color.White;
            this.Mainheading.Location = new System.Drawing.Point(95, 30);
            this.Mainheading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mainheading.Name = "Mainheading";
            this.Mainheading.Size = new System.Drawing.Size(286, 25);
            this.Mainheading.TabIndex = 6;
            this.Mainheading.Text = "Enter the Device Configurations";
            this.Mainheading.Click += new System.EventHandler(this.Mainheading_Click);
            // 
            // OptionBox
            // 
            this.OptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.OptionBox.ForeColor = System.Drawing.Color.Black;
            this.OptionBox.Location = new System.Drawing.Point(98, 126);
            this.OptionBox.Margin = new System.Windows.Forms.Padding(4);
            this.OptionBox.Name = "OptionBox";
            this.OptionBox.Size = new System.Drawing.Size(282, 29);
            this.OptionBox.TabIndex = 5;
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
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(516, 20);
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
            this.panel1.Controls.Add(this.OptionBox);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.Options);
            this.panel1.Location = new System.Drawing.Point(447, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 294);
            this.panel1.TabIndex = 11;
            // 
            // but_home
            // 
            this.but_home.BackColor = System.Drawing.Color.OrangeRed;
            this.but_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_home.FlatAppearance.BorderSize = 0;
            this.but_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_home.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.but_home.ForeColor = System.Drawing.Color.White;
            this.but_home.Location = new System.Drawing.Point(12, 93);
            this.but_home.Name = "but_home";
            this.but_home.Size = new System.Drawing.Size(101, 31);
            this.but_home.TabIndex = 30;
            this.but_home.Text = "Home";
            this.but_home.UseVisualStyleBackColor = false;
            this.but_home.Click += new System.EventHandler(this.but_home_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.but_home);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Submit);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label Options;
        private System.Windows.Forms.Label Mainheading;
        private System.Windows.Forms.TextBox OptionBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_home;
    }
}