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
    public partial class MainLog1 : Form
    {
        public MainLog1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainlog m2 = new Mainlog();
            m2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dm2 = new Dashboard();
            dm2.ShowDialog();
        }
    }
}
