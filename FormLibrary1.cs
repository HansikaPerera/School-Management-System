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
    public partial class FormLibrary1 : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Testing.mdf;Integrated Security=True;Connect Timeout=30");

        public FormLibrary1()
        {
            InitializeComponent();
        }


        public void disp_date()
        {

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Payments";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
                con.Close();

            }
        }
    private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
       
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Payments where Book_Id='" + textBox7.Text.Trim()+ "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
            textBox7.Text = "";
        }



        private void insertbtn_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("All Should be Filled!");
                }
                else
                {

                    try
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "Insert into Payments values('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "','" + finelbl.Text + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        disp_date();
                        MessageBox.Show("Record Inserted Successfully");
                        con.Close();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error");
                        con.Close();

                    }

                }
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Payments set Due_Date='" + dateTimePicker2.Text.Trim() + "' where Book_Id ='" + textBox1.Text.Trim() + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                textBox1.Text = "";
                disp_date();
                MessageBox.Show("Record Updated Successfully");
                con.Close();


            }
            catch(Exception ex) {

                MessageBox.Show(ex.Message, "Error");
                con.Close();


            }


        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {


                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Payments where Book_Id ='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                disp_date();
                MessageBox.Show("Record Deleted Successfully");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                con.Close();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            disp_date();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void finedaysttb_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int finedays = Int32.Parse(finedaysttb.Text);
                int finerate = Int32.Parse(fineratetb.Text);

                int sum = finerate * finedays;

                finelbl.Text = sum.ToString();
            }catch(Exception ex)
            {


            }
        }

        private void fineratetb_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int finedays = Int32.Parse(finedaysttb.Text);
                int finerate = Int32.Parse(fineratetb.Text);

                int sum = finerate * finedays;

                finelbl.Text = sum.ToString();

                fineratetb.Text = "";
                finedaysttb.Text = "";
               



            }
            catch (Exception ex)
            {


            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView(object sender, EventArgs e)
        {

        }
    }
}
