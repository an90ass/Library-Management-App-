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


namespace Library_Management_App.PL
{
    public partial class FRM_ADDBOOKS : Form
    {
        public int ID;
        public FRM_ADDBOOKS()
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
            OpenFileDialog OFD = new OpenFileDialog();
            var result = OFD.ShowDialog();
            if (result == DialogResult.OK)
            {
                cover.Image = Image.FromFile(OFD.FileName);
            }
        }

        private void FRM_ADDBOOKS_Load(object sender, EventArgs e)
        {
            try
            {
                BL.CLS_BOOKS BLBOOKS = new BL.CLS_BOOKS();
                DataTable dataTable = new DataTable();
                dataTable = BLBOOKS.LOADCAT();
                object[] obj = new object[dataTable.Rows.Count];
                int i;
                for (i = 0; i < dataTable.Rows.Count; i++)
                {
                    obj[i] = dataTable.Rows[i]["Cat_Name"];
                }
                comboBox2.Items.AddRange(obj);
            }
            catch
            {

            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            PL.FRM_ADDCAT FCAT = new PL.FRM_ADDCAT();
            FCAT.btnadd.ButtonText = "Add";
            FCAT.ID = 0;
            FCAT.Show();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txt_title.Text == "" || txt_author.Text == "" || txt_price.Text == "")
            {
                PL.FRM_ERRORINSERT FError = new PL.FRM_ERRORINSERT();
                FError.Show();
                this.Close();
            }
            else
            {
                if (ID == 0)//Add
                {
                    MemoryStream ma = new MemoryStream();
                    cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //Add
                    BL.CLS_BOOKS BLBOOKS = new CLS_BOOKS();
                    BLBOOKS.Insert(txt_title.Text, txt_author.Text, comboBox2.Text, txt_price.Text, txt_date.Value.ToString(), txt_rate.Value, ma);//ma = COVER
                    PL.FRM_DADD Fadd = new PL.FRM_DADD();
                    Fadd.Show();
                  //  this.Close();
                }
                else //Edit
                {
                    MemoryStream ma = new MemoryStream();
                    cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    BL.CLS_BOOKS BLBOOKS = new CLS_BOOKS();
                    BLBOOKS.Update(txt_title.Text, txt_author.Text, comboBox2.Text, txt_price.Text, txt_date.Value.ToString(), txt_rate.Value, ma,ID);//ma = COVER
                    PL.FRM_DEDIT fEDIT = new PL.FRM_DEDIT();
                    fEDIT.Show();
                    this.Close();
                }
            }
        }
    }
}
