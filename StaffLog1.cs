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
    public partial class StaffLog1 : Form
    {
        public StaffLog1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Reg1 m2 = new Staff_Reg1();
            m2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardStaff ds2 = new DashboardStaff();
            ds2.ShowDialog();
        }
    }
}
