using Library_Management_App.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_App.PL
{
    public partial class FRM_ADDUSER : Form
    {
        public int ID;
        public FRM_ADDUSER()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_timer.Text = DateTime.Now.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            if (txt_name.Text == "" || txt_user.Text == "" || txt_password.Text == "" || txt_perm.Text == "")
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
                    BL.CLS_USERS BLUSER = new CLS_USERS();
                    BLUSER.Insert(txt_name.Text,txt_user.Text,txt_password.Text,txt_perm.Text,"False");//False means that the user is not logged in.
                    PL.FRM_DADD Fadd = new PL.FRM_DADD();
                    Fadd.Show();
                    this.Close();
                }
                else //Edit
                {
                    BL.CLS_USERS BLUSER = new CLS_USERS();
                    BLUSER.Update(txt_name.Text, txt_user.Text, txt_password.Text, txt_perm.Text, ID);//False means that the user is not logged in.
                    PL.FRM_DEDIT fEDIT = new PL.FRM_DEDIT();
                    fEDIT.Show();
                    this.Close();
                }
            }
        }
    }
}
