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
    public partial class FRM_START : Form
    {
        public FRM_START()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BL.CLS_USERS userfrm = new BL.CLS_USERS();
            DataTable dataTable = new DataTable();
            dataTable = userfrm.STARTLOADDATA();
            if (dataTable.Rows.Count > 0)
            {
                PL.FRM_MAIN frmmain = new PL.FRM_MAIN();
                object lbname = dataTable.Rows[0]["CNAME"];
                object lbprem = dataTable.Rows[0]["CPREM"];
                frmmain.lb_name.Text = lbname.ToString();
                frmmain.lb_prem.Text = lbprem.ToString();
                frmmain.Show();
                this.Hide();
                timer1.Enabled = false;
            }
            else
            {
                PL.FRM_LOGIN frmlogin = new PL.FRM_LOGIN();
                frmlogin.Show();
                this.Hide();
                timer1.Enabled = false;

            }
        }
    }
}
