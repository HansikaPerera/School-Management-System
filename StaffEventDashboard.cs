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
            var newForm = new StaffEventsDisplay();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new StaffEventsDisplay();
            newForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var newForm = new StaffEventsDisplay();
            newForm.Show();
        }

        private void NMbtn_Click(object sender, EventArgs e)
        {
            var newForm = new StaffNotificationDisplay();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new StaffNotificationDisplay();
            newForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var newForm = new StaffNotificationDisplay();
            newForm.Show();
        }

        private void SMbtn_Click(object sender, EventArgs e)
        {
            var newForm = new StaffSocietyDisplay();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new StaffSocietyDisplay();
            newForm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var newForm = new StaffSocietyDisplay();
            newForm.Show();
        }
    }
}
