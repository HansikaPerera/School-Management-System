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
    public partial class StaffSocietyDisplay : Form
    {
        SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\AsokaCollegeDB\School_DataBase.mdf;Integrated Security=True;Connect Timeout=30");

        public StaffSocietyDisplay()
        {
            InitializeComponent();
            fillDataGridView();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffEventDashboard Sed1 = new StaffEventDashboard();
            Sed1.ShowDialog();
        }

        void fillDataGridView()
        {
            if (sqlConn.State == ConnectionState.Closed)
                sqlConn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("AssociationSearch_Procedure", sqlConn);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@AssociationName", txtSearch.Text.Trim());


            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dataGridView1.Columns[0].Visible = false;

            sqlConn.Close();
        }

        private void Search_Click(object sender, EventArgs e)
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
    }
}
