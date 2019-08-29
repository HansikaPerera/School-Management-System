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
    
    public partial class library_StudentDetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\AsokaCollegeDB\School_DataBase.mdf;Integrated Security=True;Connect Timeout=30");

        public library_StudentDetails()
        {
            InitializeComponent();
        }
         private void Student_details_Load(object sender, EventArgs e)
        {
           
                
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Student_details1 values(" +textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "' )";
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
           
            MessageBox.Show("Student details added succesfully");
        }
        public void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student_details1 ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("All should be filled.");
            }
            else
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "update Student_details1 set SName='" + textBox2.Text + "',ContactNo='" + textBox3.Text+ "' where admissionNo='" + textBox1.Text + "'" ;
                cmd.ExecuteNonQuery();

                
                con.Close();
                display();
                MessageBox.Show("Successfully updated");
            }
        }

       private void StudentDetails_Load(object sender, EventArgs e)
        {
            display();
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Student_details where admissionNo  = '" + textBox4.Text + "'";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLog1 Ed1 = new MainLog1();
            Ed1.ShowDialog();
        }
    }
}
