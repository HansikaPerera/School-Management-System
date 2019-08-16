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
    public partial class Non_academic_Account : Form
    {
        public Non_academic_Account()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Non_aca_Email nonmail = new Non_aca_Email();
            nonmail.Show();
        }

        private void backNA_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account_dashboard aca_dash1 = new Account_dashboard();
            aca_dash1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.Show();
        }
    }
}
