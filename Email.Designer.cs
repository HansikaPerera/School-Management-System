namespace Login
{
    partial class Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Email));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.des = new System.Windows.Forms.TextBox();
            this.sub = new System.Windows.Forms.TextBox();
            this.RecMail = new System.Windows.Forms.TextBox();
            this.Decsription = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.des);
            this.panel1.Controls.Add(this.sub);
            this.panel1.Controls.Add(this.RecMail);
            this.panel1.Controls.Add(this.Decsription);
            this.panel1.Controls.Add(this.Subject);
            this.panel1.Controls.Add(this.EmailLabel);
            this.panel1.Location = new System.Drawing.Point(315, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 319);
            this.panel1.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Maroon;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.ForeColor = System.Drawing.Color.SeaShell;
            this.btnSend.Location = new System.Drawing.Point(133, 262);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 35);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "SEND E-MAIL";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // des
            // 
            this.des.Location = new System.Drawing.Point(260, 175);
            this.des.Multiline = true;
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(100, 61);
            this.des.TabIndex = 1;
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(260, 125);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(100, 20);
            this.sub.TabIndex = 1;
            // 
            // RecMail
            // 
            this.RecMail.Location = new System.Drawing.Point(260, 84);
            this.RecMail.Name = "RecMail";
            this.RecMail.Size = new System.Drawing.Size(100, 20);
            this.RecMail.TabIndex = 1;
            // 
            // Decsription
            // 
            this.Decsription.AutoSize = true;
            this.Decsription.Location = new System.Drawing.Point(66, 175);
            this.Decsription.Name = "Decsription";
            this.Decsription.Size = new System.Drawing.Size(60, 13);
            this.Decsription.TabIndex = 0;
            this.Decsription.Text = "Description";
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Location = new System.Drawing.Point(66, 128);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(43, 13);
            this.Subject.TabIndex = 0;
            this.Subject.Text = "Subject";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(66, 84);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(76, 13);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "E mail Address";
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
            this.pictureBox2.Location = new System.Drawing.Point(10, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 131);
            this.pictureBox2.TabIndex = 158;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(112, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(867, 57);
            this.panel3.TabIndex = 23;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(191)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(200, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asoka College - School Management System";
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(71)))), ((int)(((byte)(57)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Orange;
            this.button3.Location = new System.Drawing.Point(13, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 41);
            this.button3.TabIndex = 25;
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
            this.button2.Location = new System.Drawing.Point(13, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 41);
            this.button2.TabIndex = 26;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.images__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Email";
            this.Text = "Email";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Email_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox des;
        private System.Windows.Forms.TextBox sub;
        private System.Windows.Forms.TextBox RecMail;
        private System.Windows.Forms.Label Decsription;
        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}