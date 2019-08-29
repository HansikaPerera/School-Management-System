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
            
            this.Hide();
            Dashboard d1 = new Dashboard();
            d1.ShowDialog();
        }

        private void NMbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notification n1 = new Notification();
            n1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notification n1 = new Notification();
            n1.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notification n1 = new Notification();
            n1.ShowDialog();
        }

        private void EMbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Event v1 = new Event();
            v1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Event v1 = new Event();
            v1.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Event v1 = new Event();
            v1.ShowDialog();
        }

        private void SMbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Societies s1 = new Societies();
            s1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Societies s1 = new Societies();
            s1.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Societies s1 = new Societies();
            s1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffLog1 Ed1 = new StaffLog1();
            Ed1.ShowDialog();
        }
    }
}
