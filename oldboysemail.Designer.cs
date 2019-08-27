namespace Login
{
    partial class oldboysemail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oldboysemail));
            this.txtEmailAddress = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.Label();
            this.RecMail = new System.Windows.Forms.TextBox();
            this.sub = new System.Windows.Forms.TextBox();
            this.des = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.AutoSize = true;
            this.txtEmailAddress.Location = new System.Drawing.Point(184, 104);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(76, 13);
            this.txtEmailAddress.TabIndex = 0;
            this.txtEmailAddress.Text = "E mail Address";
            // 
            // txtSubject
            // 
            this.txtSubject.AutoSize = true;
            this.txtSubject.Location = new System.Drawing.Point(184, 137);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(43, 13);
            this.txtSubject.TabIndex = 1;
            this.txtSubject.Text = "Subject";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.Location = new System.Drawing.Point(184, 176);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(60, 13);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "Description";
            // 
            // RecMail
            // 
            this.RecMail.Location = new System.Drawing.Point(344, 96);
            this.RecMail.Name = "RecMail";
            this.RecMail.Size = new System.Drawing.Size(174, 20);
            this.RecMail.TabIndex = 3;
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(344, 137);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(174, 20);
            this.sub.TabIndex = 4;
            // 
            // des
            // 
            this.des.Location = new System.Drawing.Point(344, 176);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(174, 20);
            this.des.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(277, 262);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send ";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // oldboysemail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.des);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.RecMail);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtEmailAddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "oldboysemail";
            this.Text = "oldboysemail";
            this.Load += new System.EventHandler(this.Oldboysemail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtEmailAddress;
        private System.Windows.Forms.Label txtSubject;
        private System.Windows.Forms.Label txtDescription;
        private System.Windows.Forms.TextBox RecMail;
        private System.Windows.Forms.TextBox sub;
        private System.Windows.Forms.TextBox des;
        private System.Windows.Forms.Button btnSend;
    }
}