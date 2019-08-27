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
    public partial class StuDetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\AsokaCollegeDB\School_DataBase.mdf;Integrated Security=True;Connect Timeout=30");

        public StuDetails()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            disp_data();
            textBox2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Student_Details values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "', " + textBox5.Text + ",'" + textBox6.Text + "','" + textBox7.Text + "','"+ textBox8.Text+ "','" + textBox9.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Details added Successfully!");
            



        }
        public void disp_data() {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Student_Details";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
            con.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from Student_Details where Admission_Number='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                disp_data();
                MessageBox.Show("Record Delete Successfully!");

            }
            catch (Exception msg) {


                MessageBox.Show(msg.Message, "Eorror");

            }

                


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Student_Details set Full_Name ='" + textBox2.Text + "',Address='" + textBox3.Text + "',Parents_Names='" + textBox4.Text + "',Contact_numbers= '"+textBox5.Text+"',Blood_Group='"+textBox6.Text+"',Religion='"+textBox7.Text+ "',Nationalism='" + textBox8.Text + "',Email='" + textBox9.Text + "'where Admission_Number='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                disp_data();
                MessageBox.Show("Record Update Successfully!");
            }catch(Exception msg)
            {

                MessageBox.Show(msg.Message, "Error");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new Sendemail();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var newForm = new printdetails();
            newForm.Show();
        }
    }
}
