using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Login
{
    public partial class Sendemail : Form
    {
        public Sendemail()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            StuDetails std1 = new StuDetails();
            std1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;

                this.Cursor = Cursors.WaitCursor;
                MailMessage mail = new MailMessage("asokacollegecolombo10@gmail.com", textBox1.Text, textBox2.Text, textBox3.Text);
                //SmtpClient client = new SmtpClient(smtp.Text);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("asokacollegecolombo10@gmail.com", "itpproject");
                client.EnableSsl = true;
                client.Send(mail);

                button1.Enabled = true;
                this.Cursor = Cursors.Default;

                MessageBox.Show("Mail sent successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while sending message - " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLog1 Ed1 = new MainLog1();
            Ed1.ShowDialog();
        }
    }
}
