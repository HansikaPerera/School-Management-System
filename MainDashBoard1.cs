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
    public partial class MainDashBoard1 : Form
    {
        public MainDashBoard1()
        {
            InitializeComponent();
        }

        private void EMbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLog1 m2 = new MainLog1();
            m2.ShowDialog();
        }

        private void NMbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffLog1 m2 = new StaffLog1();
            m2.ShowDialog();
        }
    }
}
