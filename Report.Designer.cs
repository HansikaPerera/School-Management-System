namespace Login
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.btnSpecific = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpecific
            // 
            this.btnSpecific.BackColor = System.Drawing.Color.Maroon;
            this.btnSpecific.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpecific.ForeColor = System.Drawing.Color.SeaShell;
            this.btnSpecific.Location = new System.Drawing.Point(238, 99);
            this.btnSpecific.Name = "btnSpecific";
            this.btnSpecific.Size = new System.Drawing.Size(119, 42);
            this.btnSpecific.TabIndex = 0;
            this.btnSpecific.Text = "REPORT OF SPECIFIC SUBJECT";
            this.btnSpecific.UseVisualStyleBackColor = false;
            this.btnSpecific.Click += new System.EventHandler(this.btnSpecific_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Maroon;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAll.ForeColor = System.Drawing.Color.SeaShell;
            this.btnAll.Location = new System.Drawing.Point(90, 99);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(115, 42);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "REPORT OF ALL SUBJECTS";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSpecific);
            this.panel1.Controls.Add(this.btnAll);
            this.panel1.Location = new System.Drawing.Point(288, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 237);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(-11, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(123, 611);
            this.panel4.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(110, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 57);
            this.panel3.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(-11, -13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 125);
            this.panel2.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(12)))), ((int)(((byte)(2)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Login.Properties.Resources.asoka_new;
            this.pictureBox2.Location = new System.Drawing.Point(8, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 131);
            this.pictureBox2.TabIndex = 159;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(191)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(204, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asoka College - School Management System";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(71)))), ((int)(((byte)(57)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Orange;
            this.button3.Location = new System.Drawing.Point(13, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(71)))), ((int)(((byte)(57)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(13, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 41);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpecific;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}