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
    public partial class Form1 : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\AsokaCollegeDB\School_DataBase.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
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
                cmd.CommandText = "select Student_ID,Book_ID,Issue_Date,Due_Date from BookIssue";
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
        private void sub_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "Insert into BookIssue values('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "','" + groupBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    dateTimePicker1.Text = "";
                    dateTimePicker2.Text = "";
                    groupBox1.Text = "";
                    disp_date();
                    MessageBox.Show("Record Inserted Successfully!!!");
                    con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error");
                    con.Close();

                }
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
            cmd.CommandText = "select * from BookIssue where Book_Id='" + textBox7.Text.Trim() + "'";
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

        }
        private void updatebtn_Click(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

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
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        private void dataGridView1_DoubleClick(object sender, EvaluateException e)
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
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
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
                        cmd.CommandText = "Insert into Pay values('"+textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "','" + finelbl.Text + "')";
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
                this.Hide();
                Last d1 = new Last();
                d1.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            BooksDetails Bd1 = new BooksDetails();
            Bd1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLog1 Ed1 = new MainLog1();
            Ed1.ShowDialog();
        }
    }
    }

