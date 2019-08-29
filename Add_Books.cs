using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Add_Books : Form
    {
       public string constring = "Data Source=DESKTOP-83SSJ0U;Initial Catalog=ConnectionDb;Integrated Security=True ";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\AsokaCollegeDB\School_DataBase.mdf;Integrated Security=True;Connect Timeout=30");
        public Add_Books()
        {
            InitializeComponent();
        }

        private void Add_Books_Load(object sender, EventArgs e)
        {
            display();        
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("All should be filled.");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into books_info values(" + textBox7.Text + ",'" + textBox3.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + textBox4.Text + "', " + textBox5.Text + ", " + textBox6.Text + " )";
                cmd.ExecuteNonQuery();
                con.Close();

                textBox7.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";
                textBox1.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                display();
               
                MessageBox.Show("Books added succesfully");

                
            }
        }
        public void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from books_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text == ""|| textBox3.Text == ""|| textBox4.Text == ""|| textBox5.Text == ""|| textBox6.Text == ""|| textBox7.Text == "")
            {
                MessageBox.Show("All should be filled.");
            }else
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
            
                cmd.CommandText = "update books_info set books_name='" +textBox3.Text + "',books_author_name='" +textBox2.Text + "',books_publication_name='" + textBox1.Text + "',books_purchase_date='" + textBox4.Text + "',books_price=" + textBox5.Text + " ,books_quantity=" + textBox6.Text + " where Id='"+textBox7.Text+"'";
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("Successfully updated");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox7.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        //search
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where books_name  = '" + textBox9.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)

            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into DeleteBooks_details values(" + textBox7.Text + ",'" + textBox3.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + textBox4.Text + "', " + textBox5.Text + ", " + textBox6.Text + " )";
                cmd.ExecuteNonQuery();
              
                //textBox7.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";
                textBox1.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                MessageBox.Show("Books Deleted succesfully");

           // con.Open();
            //SqlCommand cmd1 = con.CreateCommand();
            //cmd1.CommandType = CommandType.Text;
            
            cmd.CommandText = "Delete from books_info where Id  = '" + textBox7.Text + "'";
            MessageBox.Show("Deleted successfully.");
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryDashBoard ld1 = new LibraryDashBoard();
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