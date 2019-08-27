using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Login
{
    public partial class Non_Academic_Staff_Mng : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\AsokaCollegeDB\School_DataBase.mdf;Integrated Security=True;Connect Timeout=30");

        int NonStaffId = 0;
        public Non_Academic_Staff_Mng()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
              
                
                    SqlCommand sqlCmd = new SqlCommand("NonStaffAddorEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@NonStaffId", 0);
                    sqlCmd.Parameters.AddWithValue("@Name", textName2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Division", division2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DOB", txtDOB2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Gender", radiButtMale2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@ContactNo", cont2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@NIC", NIC2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@regYear", YOR2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Experiance", exp2.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved successfully");
                
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("NonStaffViewOrSearch", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@NonStaffName", Search2.Text.Trim());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dataGridView1.Columns[0].Visible = false;
            sqlCon.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                NonStaffId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                textName2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                division2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtDOB2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                radiButtMale2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cont2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                NIC2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                YOR2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                exp2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
               
                btnDelete.Enabled = true;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                if (MessageBox.Show("Do you want to remove this StaffMember ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand sqlCmd = new SqlCommand("NonStaffDeletion", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@NonStaffId", NonStaffId);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted successfully");
                }
                else
                {
                    MessageBox.Show("Details not deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            createDocument();
        }

        private void createDocument()
        {
            Document document = new Document();

            PdfWriter.GetInstance(document, new FileStream("F:/1.pdf", FileMode.Create));
            document.Open();

            Paragraph p = new Paragraph("abc");
            document.Add(p);

            document.Close();

            MessageBox.Show("Document Created.");
        }

        private void Non_Academic_Staff_Mng_Load(object sender, EventArgs e)
        {

        }

        private void YOR2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radiButtMale2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtcont1_Click(object sender, EventArgs e)
        {

        }

        private void NIC2_TextChanged(object sender, EventArgs e)
        {

        }

        private void backNASM_Click(object sender, EventArgs e)
        {
            this.Hide();
            sub_staff_dashboard nsdb = new sub_staff_dashboard();
            nsdb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("NonStaffUpdate", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                sqlCmd.Parameters.AddWithValue("@NonStaffId", NonStaffId);
                sqlCmd.Parameters.AddWithValue("@Name", textName2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Division", division2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@DOB", txtDOB2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Gender", radiButtMale2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@ContactNo", cont2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@NIC", NIC2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@regYear", YOR2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Experiance", exp2.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }

        }
    }
}
    

