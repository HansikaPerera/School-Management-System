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
    public partial class sub_staff_dashboard : Form
    {
        public sub_staff_dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Non_Academic_Staff_Mng non_aca_mng = new Non_Academic_Staff_Mng();
            non_aca_mng.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AcademicToDash aca_dash = new AcademicToDash();
            aca_dash.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account_dashboard accd = new Account_dashboard();
            accd.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.Show();
        }
    }
}
