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
    public partial class Books_Issued : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-83SSJ0U;Initial Catalog=ConnectionDb;Integrated Security=True ");
        public Books_Issued()
        {
            InitializeComponent();
        }

        private void Books_Issued_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into  Books_issued values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + " ','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox7.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();


                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";

                MessageBox.Show("Data added succesfully");
            }
        }

    }

