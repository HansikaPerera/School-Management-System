using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;

namespace Login
{
    public partial class EmailSendingInterface : Form
    {
        public EmailSendingInterface()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sendemail();
        }

        private void sendemail()
        {
            try
            {
                btnSend.Enabled = false;

                this.Cursor = Cursors.WaitCursor;
                MailMessage mail = new MailMessage("asokacollegecolombo10@gmail.com", "dissanayakechamod@gmail.com", sub.Text, des.Text);
                //SmtpClient client = new SmtpClient(smtp.Text);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("asokacollegecolombo10@gmail.com", "itpproject");
                client.EnableSsl = true;
                client.Send(mail);

                btnSend.Enabled = true;
                this.Cursor = Cursors.Default;

                MessageBox.Show("Mail sent successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while sending message - " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ResultsManagement obj = new ResultsManagement();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLog1 Ed1 = new MainLog1();
            Ed1.ShowDialog();
        }
    }
}
