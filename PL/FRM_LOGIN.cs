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
using Library_Management_App.BL;

namespace Library_Management_App.PL
{
    public partial class FRM_LOGIN : Form
    {
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;


            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                BL.CLS_USERS CLUSER = new CLS_USERS();
                DataTable dataTable = new DataTable();
                dataTable = CLUSER.Login(txt_user.Text, txt_password.Text);
                if (dataTable.Rows.Count > 0) //This means that there is a login process.
                {
                    CLUSER.UpdateLOGIN(txt_user.Text, txt_password.Text);
                    PL.FRM_MAIN frmmain = new PL.FRM_MAIN();
                    object lbname = dataTable.Rows[0]["CNAME"];
                    object lbprem = dataTable.Rows[0]["CPREM"];
                    frmmain.lb_name.Text = lbname.ToString();
                    frmmain.lb_prem.Text = lbprem.ToString();
                    frmmain.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in login information");
                MessageBox.Show(ex.Message);

            }
        }
    }
}
