using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class EventDashboard : Form
    {
        public EventDashboard()
        {
            InitializeComponent();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            var newForm = new Dashboard();
            newForm.Show();
        }

        private void NMbtn_Click(object sender, EventArgs e)
        {
            var newForm = new Notification();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new Notification();
            newForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var newForm = new Notification();
            newForm.Show();
        }

        private void EMbtn_Click(object sender, EventArgs e)
        {
            var newForm = new Event();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Event();
            newForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var newForm = new Event();
            newForm.Show();
        }

        private void SMbtn_Click(object sender, EventArgs e)
        {
            var newForm = new Societies();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new Societies();
            newForm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var newForm = new Societies();
            newForm.Show();
        }
    }
}
