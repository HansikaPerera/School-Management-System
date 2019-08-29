using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class SpesificReport : Form
    {
        public SpesificReport()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            documentcreate();
        }

        private void documentcreate()
        {
            //  Document document = new Document();
            iTextSharp.text.Document document = new iTextSharp.text.Document();


            PdfWriter.GetInstance(document, new FileStream("D:/testReport.pdf", FileMode.Create));
            document.Open();

            Document open;
            Paragraph p = new Paragraph("--- Reprot Of All Subjects Details ---");

            PdfPTable pdfTable = new PdfPTable(6);


            document.Add(p);
            document.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report r = new Report();
            r.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLog1 Ed1 = new MainLog1();
            Ed1.ShowDialog();
        }
    }
    }
