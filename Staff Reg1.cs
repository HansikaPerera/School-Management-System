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
    public partial class Staff_Reg1 : Form
    {
        public Staff_Reg1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffLog1 m2 = new StaffLog1();
            m2.ShowDialog();
        }
    }
}
