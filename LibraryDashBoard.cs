using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class LibraryDashBoard : Form
    {
        public LibraryDashBoard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LibraryDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BooksDetails bk = new BooksDetails();
            bk.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            library_StudentDetails lsd1 = new library_StudentDetails();
            lsd1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberDetails mbrD = new MemberDetails();
            mbrD.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard ld1 = new Dashboard();
            ld1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLog1 Ed1 = new MainLog1();
            Ed1.ShowDialog();
        }
    }
}
