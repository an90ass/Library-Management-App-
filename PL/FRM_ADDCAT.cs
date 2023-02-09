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
    public partial class FRM_ADDCAT : Form
    {
        public int ID;
        public FRM_ADDCAT()
        {
            InitializeComponent();
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(txt_catname.Text == "")
            {
                PL.FRM_ERRORINSERT FError = new PL.FRM_ERRORINSERT();
                FError.Show();
                this.Close();
            }
            else
            {
                if(ID == 0)//Add
                {
                    BL.CLS_CAT BLACT = new BL.CLS_CAT();
                    BLACT.Insert(txt_catname.Text);
                    PL.FRM_DADD Fadd = new PL.FRM_DADD();
                    Fadd.Show();
                    this.Close();
                }
                else //Edit
                {
                    BL.CLS_CAT BLACT = new BL.CLS_CAT();
                    BLACT.Update(txt_catname.Text,ID);
                    PL.FRM_DEDIT fEDIT = new PL.FRM_DEDIT();
                    fEDIT.Show();
                    this.Close();
                }
               
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
