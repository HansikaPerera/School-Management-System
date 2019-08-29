using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace Login
{
    public partial class Non_aca_Email : Form
    {
        public Non_aca_Email()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {

                if (textSub.Text == "" || textBody.Text == "")
                {
                    MessageBox.Show("Please fill all feilds!");
                }

                btnSend.Enabled = false;

                this.Cursor = Cursors.WaitCursor;
                MailMessage mail = new MailMessage("asokacollegecolombo10@gmail.com", "sashinkakumarage@gmail.com", textSub.Text, textBody.Text);
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

        private void backNE_Click(object sender, EventArgs e)
        {

            this.Hide();
            Non_academic_Account non_aca_acc = new Non_academic_Account();
            non_aca_acc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffLog1 Ed1 = new StaffLog1();
            Ed1.ShowDialog();
        }
    }
}
    

