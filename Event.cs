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
    public partial class Event : Form
    {
        SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\AsokaCollegeDB\School_DataBase.mdf;Integrated Security=True;Connect Timeout=30");

        public Event()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("EventInsert_Procedure", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Insert");
                sqlCmd.Parameters.AddWithValue("@EventID", 0);
                sqlCmd.Parameters.AddWithValue("@EventName", txtName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                sqlCmd.Parameters.AddWithValue("@Time", txtTime.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Venue", txtVenue.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Teacher", txtTeacher.Text.Trim());
                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Inserted Successfully.");

                fillDataGridView();
                reset();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlConn.Close();
            }
        }

        void fillDataGridView()
        {
            if (sqlConn.State == ConnectionState.Closed)
                sqlConn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("EventSearch_Procedure", sqlConn);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@EventName", txtSearch.Text.Trim());

            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            //if(dtbl.Rows.Count >= 1) {
            //  MessageBox.Show("Date is not available");
            //}
            dataGridView1.DataSource = dtbl;
            // dataGridView1.Columns[0].Visible = false;

            sqlConn.Close();
        }


        void reset()
        {
            txtName.Text = txtTime.Text = txtVenue.Text = txtTeacher.Text = "";
            dateTimePicker1.ResetText();
            txtID.ResetText();
            btnDelete.Enabled = false;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("EventUpdate_Procedure", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Update");
                sqlCmd.Parameters.AddWithValue("@EventID", txtID.Text);
                sqlCmd.Parameters.AddWithValue("@EventName", txtName.Text.Trim());


                sqlCmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                sqlCmd.Parameters.AddWithValue("@Time", txtTime.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Venue", txtVenue.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Teacher", txtTeacher.Text.Trim());
                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Updated Successfully.");

                fillDataGridView();
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                fillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message.");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtTime.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtVenue.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtTeacher.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();


                btnUpdate.Text = "Update";
                btnDelete.Enabled = true;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();
                if (MessageBox.Show("Do you want to delete this event ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    SqlCommand sqlCmd = new SqlCommand("EventDelete_Procedure", sqlConn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@EventID", txtID.Text);

                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Deleted Successfully.");

                    fillDataGridView();
                    reset();
                }
                else
                {
                    MessageBox.Show("Event not deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message.");
            }
            finally
            {
                sqlConn.Close();
            }
        }
    }
}
