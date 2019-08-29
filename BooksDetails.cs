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
    public partial class BooksDetails : Form
    {
        public BooksDetails()
        {
            InitializeComponent();
        }

        private void BooksDetails_Load(object sender, EventArgs e)
        {

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewBooks vb1 = new ViewBooks();
            vb1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Books ab = new Add_Books();
            ab.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Removed_Books rb1 = new Removed_Books();
            rb1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryDashBoard ld1 = new LibraryDashBoard();
            ld1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book_Issue bi1 = new Book_Issue();
            bi1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLog1 Ed1 = new MainLog1();
            Ed1.ShowDialog();
        }
    }
}
