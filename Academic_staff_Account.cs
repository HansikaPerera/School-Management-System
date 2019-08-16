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
    public partial class Academic_staff_Account : Form
    {
        public Academic_staff_Account()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aca_Email mail = new Aca_Email();
            mail.Show();
        }

        private void backAA_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account_dashboard aca_dash2 = new Account_dashboard();
            aca_dash2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.Show();
        }
    }
}
