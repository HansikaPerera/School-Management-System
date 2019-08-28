using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class Notification : Form
    {
        SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\AsokaCollegeDB\School_DataBase.mdf;Integrated Security=True;Connect Timeout=30");


        public Notification()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTag.Text == "" || comboBox1.Text == "" || txtNoti.Text == "")
                {
                    MessageBox.Show("Please fill all feilds!");
                }
                else if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("NotificationInsert_Procedure", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Insert");
                sqlCmd.Parameters.AddWithValue("@NotificationID", 0);
                sqlCmd.Parameters.AddWithValue("@NotificationTag", txtTag.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@RelevantParties", comboBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Notification", txtNoti.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Inserted Successfully.");

                fillDataGridView();
                reset();
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

        void fillDataGridView()
        {
            if (sqlConn.State == ConnectionState.Closed)
                sqlConn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("NotificationSearch_Procedure", sqlConn);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@NotiTag", txtSearch.Text.Trim());

            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dataGridView1.Columns[0].Visible = false;

            sqlConn.Close();
        }


        void reset()
        {
            txtTag.Text = comboBox1.Text = txtNoti.Text = "";
            dateTimePicker1.ResetText();
            txtID.ResetText();
            btnDelete.Enabled = false;


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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("NotificationUpdate_Procedure", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Update");
                sqlCmd.Parameters.AddWithValue("@NotificationID", txtID.Text);
                sqlCmd.Parameters.AddWithValue("@NotificationTag", txtTag.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@RelevantParties", comboBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Notification", txtNoti.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Updated Successfully.");

                fillDataGridView();
                reset();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();
                if (MessageBox.Show("Do you want to delete this Notification ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    SqlCommand sqlCmd = new SqlCommand("NotificationDelete_Procedure", sqlConn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@NotificationID", txtID.Text);

                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Deleted Successfully.");

                    fillDataGridView();
                    reset();
                }

                else
                {
                    MessageBox.Show("Notification not deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                //NotificationID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtTag.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtNoti.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                btnUpdate.Text = "Update";
                btnDelete.Enabled = true;

            }
        }


        public void exportDataGrid(DataGridView dgw, string fileName)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.NOT_EMBEDDED);
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
                    Paragraph pEnd = new Paragraph("- System generated Notices Report on " + now + " - ");
                    pdfdoc.Add(pEnd);

                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }



        private void btnReport_Click(object sender, EventArgs e)
        {
            exportDataGrid(dataGridView1, "Notices Report");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventDashboard Ed1 = new EventDashboard();
            Ed1.ShowDialog();
        }
    }
}
