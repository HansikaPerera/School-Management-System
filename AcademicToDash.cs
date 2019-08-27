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
    public partial class AcademicToDash : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\AsokaCollegeDB\School_DataBase.mdf;Integrated Security=True;Connect Timeout=30");

        int StaffId = 0;
        public AcademicToDash()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand("StaffAddorEdit", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Add");
                sqlCmd.Parameters.AddWithValue("@StaffId", 0);
                sqlCmd.Parameters.AddWithValue("@FirstName", textBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@LastName", textBox2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Sex", radiButtMale.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@ContactNo", textBox5.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@NIC", textBox6.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@regYear", dateTimePicker2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@eduQul", txtboxx.Text.Trim());
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
            SqlDataAdapter sqlDa = new SqlDataAdapter("StaffViewOrSearch", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@StaffName", txtSearch.Text.Trim());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dataGridView1.Columns[0].Visible = false;
            sqlCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow.Index != -1)
            {
                StaffId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                radiButtMale.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtboxx.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
               
                btnDelete.Enabled = true;

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

                    SqlCommand sqlCmd = new SqlCommand("StaffDeletion", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@StaffId", StaffId);
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

       

       
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public void exportDataGrid(DataGridView dgw, string fileName)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfpt = new PdfPTable(dgw.Columns.Count);
            pdfpt.DefaultCell.Padding = 3;
            pdfpt.WidthPercentage = 100;
            pdfpt.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfpt.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            //Add Header
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.Color(191, 47, 47);
                pdfpt.AddCell(cell);
            }


            //Add datarow
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfpt.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialog = new SaveFileDialog();
            savefiledialog.FileName = fileName;
            savefiledialog.DefaultExt = ".pdf";

            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialog.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfpt);

                    DateTime now = DateTime.Now;
                    Paragraph pEnd = new Paragraph("- System generated Academic Staff Report on " + now + " - ");
                    pdfdoc.Add(pEnd);

                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }
        private void butReport_Click(object sender, EventArgs e)
        {
            exportDataGrid(dataGridView1, "Academic Staff Report");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backASM_Click(object sender, EventArgs e)
        {
            this.Hide();
            sub_staff_dashboard sdb = new sub_staff_dashboard();
            sdb.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
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

                SqlCommand sqlCmd = new SqlCommand("StaffUpdate", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                sqlCmd.Parameters.AddWithValue("@StaffId", StaffId);
                sqlCmd.Parameters.AddWithValue("@FirstName", textBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@LastName", textBox2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Sex", radiButtMale.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@ContactNo", textBox5.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@NIC", textBox6.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@regYear", dateTimePicker2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@eduQul", txtboxx.Text.Trim());
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
