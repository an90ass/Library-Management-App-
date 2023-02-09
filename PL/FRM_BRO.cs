using Library_Management_App.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Library_Management_App.PL
{
    public partial class FRM_BRO : Form
    {
        public int ID;
        public FRM_BRO()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void FRM_ADDBOOKS_Load(object sender, EventArgs e)
        {
            BL.CLS_SELL BLSELL = new BL.CLS_SELL();
            //Load Books
            DataTable dataTable_1 = new DataTable();
            dataTable_1 = BLSELL.LoadBOOKS();
            dataGridView2.DataSource = dataTable_1;
            //Load Student
            DataTable dataTable_2 = new DataTable();
            dataTable_2 = BLSELL.LoadST();
            dataGridView1.DataSource = dataTable_2;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            if (txt_price.Text == "")
            {
                PL.FRM_ERRORINSERT FError = new PL.FRM_ERRORINSERT();
                FError.Show();
                this.Close();
            }
            else
            {
                if (ID == 0)//Add
                {
                    //Add
                    BL.CLS_BOR BLBOR = new CLS_BOR();
                    BLBOR.Insert(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToString(txt_date.Value), Convert.ToString(txt_date2.Value), Convert.ToInt32(txt_price.Text));
                    PL.FRM_DADD Fadd = new PL.FRM_DADD();
                    Fadd.Show();
                    this.Close();
                }
                else //Edit
                {
                    BL.CLS_BOR BLBOR = new CLS_BOR();
                    BLBOR.Update(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToString(txt_date.Value), Convert.ToString(txt_date2.Value), Convert.ToInt32(txt_price.Text),ID);
                    PL.FRM_DEDIT fEDIT = new PL.FRM_DEDIT();
                    fEDIT.Show();
                    this.Close();

                }
            }
        }
    }
}
