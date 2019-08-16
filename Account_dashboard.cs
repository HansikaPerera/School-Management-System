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
    public partial class Account_dashboard : Form
    {
        public Account_dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Non_academic_Account non_aca_acc = new Non_academic_Account();
            non_aca_acc.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Academic_staff_Account aca_acc = new Academic_staff_Account();
            aca_acc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Hide();
            Dashboard db = new Dashboard();
            db.Show();

        }
    }
}
