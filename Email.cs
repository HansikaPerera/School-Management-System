using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                btnSend.Enabled = false;

                this.Cursor = Cursors.WaitCursor;
                MailMessage mail = new MailMessage("asokacollegecolombo10@gmail.com", RecMail.Text, sub.Text, des.Text);
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

        private void Email_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subject s1 = new Subject();
            s1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
