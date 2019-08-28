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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void eventBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventDashboard ed1 = new EventDashboard();
            ed1.ShowDialog();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            sub_staff_dashboard ssd1 = new sub_staff_dashboard();
            ssd1.ShowDialog();
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StuDetails sd1 = new StuDetails();
            sd1.ShowDialog();
        }

        private void oldBoysBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOldBoys1 f1 = new FormOldBoys1();
            f1.ShowDialog();
        }

        private void libraryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryDashBoard ld1 = new LibraryDashBoard();
            ld1.ShowDialog();
        }

        private void subjectBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subject s1 = new Subject();
            s1.ShowDialog();
        }
    }
}
