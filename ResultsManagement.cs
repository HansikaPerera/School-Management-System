using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class ResultsManagement : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\AsokaCollegeDB\School_DataBase.mdf;Integrated Security=True;Connect Timeout=30");
        public ResultsManagement()
        {
            InitializeComponent();
        }

        private void ResultsManagement_Load(object sender, EventArgs e)
        {
            display();
        }

        private void display()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from ExamResult";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch(Exception e1)
            {
                MessageBox.Show(""+e1);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int intgrade, intterm, intmark;
           
            if (txtStudentID.Text ==""|| txtGrade.Text ==""|| txtTerm.Text == "" || txtSubject.Text == "" || txtMark.Text == "")
            {
                MessageBox.Show("All fields must be filled.");
            }else if (!Int32.TryParse(txtGrade.Text, out intgrade))
            {
                MessageBox.Show("Grade is not a valid number.");
            }
            else if (!Int32.TryParse(txtTerm.Text, out intterm))
            {
                MessageBox.Show("Term is not a valid number.");
            }else if (!Int32.TryParse(txtMark.Text, out intmark))
            {
                MessageBox.Show("Mark is not a valid number.");
            }else if (intgrade>13 || intgrade<1)
            {
                MessageBox.Show("Grade shoud be between 1-13");
            }else if (intterm>3 || intterm<1)
            {
                MessageBox.Show("Term must be 1, 2 or 3");
            }else if (intmark >100 || intmark<0)
            {
                MessageBox.Show("Marks should be 0 - 100");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into ExamResult values ('" + txtStudentID.Text + "'," + txtGrade.Text + "," + txtTerm.Text + ", '" + txtSubject.Text + "'," + txtMark.Text + ")";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    display();

                    MessageBox.Show("Successfully Inserted!");
                    txtStudentID.Text = "";
                    txtGrade.Text = "";
                    txtTerm.Text = "";
                    txtSubject.Text = "";
                    txtMark.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Error occured.");
                }

            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtGrade.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtTerm.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtSubject.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtMark.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                txtStudentID.ReadOnly = true;

            }
            catch (Exception e3)
            {
                MessageBox.Show("" + e3);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int intgrade, intterm, intmark;

            if (txtStudentID.Text == "" || txtGrade.Text == "" || txtTerm.Text == ""
                || txtSubject.Text == "" || txtMark.Text == "")
            {
                MessageBox.Show("All fields must be filled.");
            }
            else if (!Int32.TryParse(txtGrade.Text, out intgrade))
            {
                MessageBox.Show("Grade is not a valid number.");
            }
            else if (!Int32.TryParse(txtTerm.Text, out intterm))
            {
                MessageBox.Show("Term is not a valid number.");
            }
            else if (!Int32.TryParse(txtMark.Text, out intmark))
            {
                MessageBox.Show("Mark is not a valid number.");
            }
            else if (intgrade > 13 || intgrade < 1)
            {
                MessageBox.Show("Grade shoud be between 1-13");
            }
            else if (intterm > 3 || intterm < 1)
            {
                MessageBox.Show("Term must be 1, 2 or 3");
            }
            else if (intmark > 100 || intmark < 0)
            {
                MessageBox.Show("Marks should be 0 - 100");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update ExamResult set Grade = " + txtGrade.Text + ",Term = " + txtTerm.Text + ",Subject = '" + txtSubject.Text + "',Mark =" + txtMark.Text + " where StudentID = '" + txtStudentID.Text + "' ";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    display();
                    MessageBox.Show("Successfully Updated!");
                    txtStudentID.Text = "";
                    txtGrade.Text = "";
                    txtTerm.Text = "";
                    txtSubject.Text = "";
                    txtMark.Text = "";
                }
                catch (Exception e4)
                {
                    MessageBox.Show("" + e4);
                }
                txtStudentID.ReadOnly = false; 
            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtStudentID.Text == "")
            {
                MessageBox.Show("Please fill student ID");
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from ExamResult where StudentID = '" + txtStudentID.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    display();
                    MessageBox.Show("Successfully Deleted!");
                    txtStudentID.Text = "";
                    txtGrade.Text = "";
                    txtTerm.Text = "";
                    txtSubject.Text = "";
                    txtMark.Text = "";
                    txtStudentID.ReadOnly = false;
                }
                catch (Exception e5)
                {
                    MessageBox.Show("" + e5);
                }


            }



        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from ExamResult WHERE StudentID LIKE'%" + txtSearch.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception e6)
            {
                MessageBox.Show("" + e6);
            }

           

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLog1 Ed1 = new MainLog1();
            Ed1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d1 = new Dashboard();
            d1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmailSendingInterface d1 = new EmailSendingInterface();
            d1.ShowDialog();
        }
    }
}
