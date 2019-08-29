using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Login
{
    public partial class StaffEventDashboard : Form
    {
        public StaffEventDashboard()
        {
            InitializeComponent();
        }

        private void EMbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffEventsDisplay sed1 = new StaffEventsDisplay();
            sed1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffEventsDisplay sed1 = new StaffEventsDisplay();
            sed1.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffEventsDisplay sed1 = new StaffEventsDisplay();
            sed1.ShowDialog();
        }

        private void NMbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffNotificationDisplay snd1 = new StaffNotificationDisplay();
            snd1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffNotificationDisplay snd1 = new StaffNotificationDisplay();
            snd1.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffNotificationDisplay snd1 = new StaffNotificationDisplay();
            snd1.ShowDialog();
        }

        private void SMbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffSocietyDisplay ssd1 = new StaffSocietyDisplay();
            ssd1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffSocietyDisplay ssd1 = new StaffSocietyDisplay();
            ssd1.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffSocietyDisplay ssd1 = new StaffSocietyDisplay();
            ssd1.ShowDialog();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardStaff ds1 = new DashboardStaff();
            ds1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffLog1 Ed1 = new StaffLog1();
            Ed1.ShowDialog();
        }
    }
}
