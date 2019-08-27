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
    }
}
