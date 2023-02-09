using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace Library_Management_App.PL
{
    public partial class FRM_REPORT : Form
    {

        //Instance of Categoray
        BL.CLS_CAT BLCAT = new BL.CLS_CAT(); // varabils for Categories used in line 137
                                             //Instance of Books 
        BL.CLS_BOOKS BLBOOKS = new BL.CLS_BOOKS();
        //Instance of Students
        BL.CLS_ST BLST = new BL.CLS_ST();
        //Instance of Students
        BL.CLS_SELL BLSELL = new BL.CLS_SELL();
        //Instance of BORROW
        BL.CLS_BOR BLBOR = new BL.CLS_BOR();
        //Instance of Users
        BL.CLS_USERS BLUSER = new BL.CLS_USERS();
        public FRM_REPORT()
        {
            InitializeComponent();
        }

        private void FRM_REPORT_Load(object sender, EventArgs e)
        {
            PL.FRM_MAIN Home = new PL.FRM_MAIN();
            lb_name.Text = Home.lb_name.Text;
            lb_prem.Text = Home.lb_prem.Text;
            lb_date.Text = DateTime.Now.ToString();
            //

            //For chek number
            //Books
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = BLBOOKS.Load();
                lb_booksNumber.Text = dataTable.Rows.Count.ToString();

            }
            catch
            { }
            //Students
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = BLST.Load();
                lb_STNumber.Text = dataTable.Rows.Count.ToString();

            }
            catch
            { }
            //Selles
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = BLSELL.Load();
                lb_sellsNumber.Text = dataTable.Rows.Count.ToString();

            }
            catch
            { }
            //BRO
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = BLBOR.Load();
                lb_BRONumber.Text = dataTable.Rows.Count.ToString();

            }
            catch
            { }

            //CAT
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = BLCAT.Load();
                lb_CATNumber.Text = dataTable.Rows.Count.ToString();

            }
            catch
            { }
            //USER
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = BLUSER.Load();
                lb_USERNumber.Text = dataTable.Rows.Count.ToString();

            }
            catch
            { }

            /////////////////////////////////////////////



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap img = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(img, new Rectangle(Point.Empty, panel1.Size));
            e.Graphics.DrawImage(img,0,0);
        }
    }
}
