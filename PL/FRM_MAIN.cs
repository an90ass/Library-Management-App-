using Bunifu.Framework.UI;
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

namespace Library_Management_App.PL
{
    public partial class FRM_MAIN : Form
    {
        string State; //With this variable, we can separate operations
        int ID;

        //Instance of Categoray
        BL.CLS_CAT BLCAT = new BL.CLS_CAT(); // varabils for Categories used in line 137
                                             //Instance of Books 
        BL.CLS_BOOKS BLBOOKS = new BL.CLS_BOOKS();
        //Instance of Students
        BL.CLS_ST BLST = new BL.CLS_ST();
        //Instance of Students
        BL.CLS_SELL BLSELL = new BL.CLS_SELL();
        //Instance of BORROW
        BL.CLS_BOR BLBOR= new BL.CLS_BOR();
        //Instance of Users
        BL.CLS_USERS BLUSER = new BL.CLS_USERS();
        public FRM_MAIN()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /*
         private void button1_Click(object sender, EventArgs e)
         {
             Environment.Exit(0);
         }*/

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if (P_MB.Size.Width == 175)
            {
                P_MB.Width = 50;
                //  button1.LeftToRight = LeftToRight.Yes;
                lb_name.Visible = false;
                lb_prem.Visible = false;

            }
            else
            {
                P_MB.Width = 175;
                //  button1.RightToLeft = Led;
                lb_name.Visible = true;
                lb_prem.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            txt_seach.Visible = true;
            bunifuThinButton24.Visible = true;
            State = "BOOKS"; 
            lb_Title.Text = "Books";
            //Load Data
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = BLBOOKS.Load();
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Sequencing"; //sequencing = التسلسل
                dataGridView1.Columns[1].HeaderText = "Book's Name";
                dataGridView1.Columns[2].HeaderText = "Author";
                dataGridView1.Columns[3].HeaderText = "Category";
                dataGridView1.Columns[4].HeaderText = "Price";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            txt_seach.Visible = true;
            bunifuThinButton24.Visible = true;
            State = "ST"; //CAT = Category
            lb_Title.Text = "Students";
            //Load Data
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = BLST.Load();
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Sequencing"; //sequencing = التسلسل
                dataGridView1.Columns[1].HeaderText = "Student's Name";
                dataGridView1.Columns[2].HeaderText = "Address";
                dataGridView1.Columns[3].HeaderText = "Phone";
                dataGridView1.Columns[4].HeaderText = "Email";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            txt_seach.Visible = true;
            bunifuThinButton24.Visible = false;
            State = "BOR";
            lb_Title.Text = "Borrowing";
            //Load Data
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = BLBOR.Load();
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Sequencing"; //sequencing = التسلسل
                dataGridView1.Columns[1].HeaderText = "Buyer's Name";
                dataGridView1.Columns[2].HeaderText = "Book's Name";
                dataGridView1.Columns[3].HeaderText = "Beginning of borrow";
                dataGridView1.Columns[4].HeaderText = "End of borrow";
                dataGridView1.Columns[5].HeaderText = "Price";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    
    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void P_HOME_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void P_TB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            txt_seach.Visible = true;

            bunifuThinButton24.Visible = false;
            State = "CAT"; //CAT = Category
            lb_Title.Text = "Categories";
            //Load Data
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = BLCAT.Load();
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Sequencing"; //sequencing = التسلسل
                dataGridView1.Columns[1].HeaderText = "Category Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            P_HOME.Visible = true;
            P_MAIN.Visible = false;
            lb_Title.Text = "Home";


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //Add Category
            if (State == "CAT")
            {
                PL.FRM_ADDCAT FCAT = new PL.FRM_ADDCAT();
                FCAT.btnadd.ButtonText = "Add";
                FCAT.ID = 0;
                bunifuTransition1.ShowSync(FCAT);// = FCAT.Show();
            }
            //Add Books
            if (State == "BOOKS")
            {
                PL.FRM_ADDBOOKS FBOOKS = new PL.FRM_ADDBOOKS();
                FBOOKS.btnadd.ButtonText = "Add";
                FBOOKS.ID = 0;
                bunifuTransition1.ShowSync(FBOOKS);// = FBOOKS.Show();


            }
            //Add Students
            if (State == "ST")
            {
                PL.FRM_ADDSTUDENT FSTUDENSTS = new PL.FRM_ADDSTUDENT();
                FSTUDENSTS.btnadd.ButtonText = "Add";
                FSTUDENSTS.ID = 0;
                bunifuTransition1.ShowSync(FSTUDENSTS);// = FSTUDENSTS.Show();


            }
            //Add SELL
            if (State == "SELL")
            {
                PL.FRM_MAKSELL FSELL = new PL.FRM_MAKSELL();
                FSELL.btnadd.ButtonText = "Add";
                FSELL.ID = 0;
                bunifuTransition1.ShowSync(FSELL);


            } 
            //Add BOR
            if (State == "BOR")
            {
                PL.FRM_BRO FBRO = new PL.FRM_BRO();
                FBRO.btnadd.ButtonText = "Add";
                FBRO.ID = 0;
                bunifuTransition1.ShowSync(FBRO);


            }
            //Add USER
            if (State == "US")
            {
                PL.FRM_ADDUSER FUSER = new PL.FRM_ADDUSER();
                FUSER.btnadd.ButtonText = "Add";
                FUSER.ID = 0;
                bunifuTransition1.ShowSync(FUSER);


            }
        }

        private void FRM_MAIN_Activated(object sender, EventArgs e)
        {
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

            //For Prem
            if (lb_prem.Text == "Admin")
            {
                bunifuThinButton23.Enabled = true;
                button6.Enabled = true;
            }
            else
            {
                bunifuThinButton23.Enabled = false;
                button6.Enabled = false;
                bunifuThinButton23.Visible = false;
            }
            if (State == "CAT")
            {
               
                //Load Data CAT
                try
                {
                    DataTable dataTable = new DataTable();
                    dataTable = BLCAT.Load();
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Sequencing"; //sequencing = التسلسل
                    dataGridView1.Columns[1].HeaderText = "Category Name";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (State == "BOOKS")
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    dataTable = BLBOOKS.Load();
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Sequencing"; //sequencing = التسلسل
                    dataGridView1.Columns[1].HeaderText = "Book Name";
                    dataGridView1.Columns[2].HeaderText = "The Author";
                    dataGridView1.Columns[3].HeaderText = "The Category";
                    dataGridView1.Columns[4].HeaderText = "The Price";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else if(State == "ST")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                bunifuThinButton24.Visible = true;
                State = "ST"; //CAT = Category
                lb_Title.Text = "Students";
                //Load Data
                try
                {
                    DataTable dataTable = new DataTable();
                    dataTable = BLST.Load();
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Sequencing"; //sequencing = التسلسل
                    dataGridView1.Columns[1].HeaderText = "Student's Name";
                    dataGridView1.Columns[2].HeaderText = "Address";
                    dataGridView1.Columns[3].HeaderText = "Phone";
                    dataGridView1.Columns[4].HeaderText = "Email";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (State == "SELL") {

                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                bunifuThinButton24.Visible = false;
                State = "SEEL"; //CAT = Category
                lb_Title.Text = "Seel";
                //Load Data
                try
                {
                    DataTable dataTable = new DataTable();
                    dataTable = BLSELL.Load();
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Sequencing"; //sequencing = التسلسل
                    dataGridView1.Columns[1].HeaderText = "Book's Name";
                    dataGridView1.Columns[2].HeaderText = "Buyer";
                    dataGridView1.Columns[3].HeaderText = "Price";
                    dataGridView1.Columns[4].HeaderText = "Date";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(State == "BOR")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                bunifuThinButton24.Visible = false;
                State = "BOR";
                lb_Title.Text = "Borrowing";
                //Load Data
                try
                {
                    DataTable dataTable = new DataTable();
                    dataTable = BLBOR.Load();
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Sequencing"; //sequencing = التسلسل
                    dataGridView1.Columns[1].HeaderText = "Buyer's Name";
                    dataGridView1.Columns[2].HeaderText = "Book's Name";
                    dataGridView1.Columns[3].HeaderText = "Beginning of borrow";
                    dataGridView1.Columns[4].HeaderText = "End of borrow";
                    dataGridView1.Columns[5].HeaderText = "Price";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else if(State == "US")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                bunifuThinButton24.Visible = false;
                State = "US";
                lb_Title.Text = "Users";
                //Load Data
                try
                {
                    DataTable dataTable = new DataTable();
                    dataTable = BLUSER.Load();
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Sequencing"; //sequencing = التسلسل
                    dataGridView1.Columns[1].HeaderText = "Full Name";
                    dataGridView1.Columns[2].HeaderText = "User Name";
                    dataGridView1.Columns[3].HeaderText = "Password";
                    dataGridView1.Columns[4].HeaderText = "Permission";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //Edit Category
            
                if (State == "CAT")
                {
                    PL.FRM_ADDCAT FCAT = new PL.FRM_ADDCAT();
                    FCAT.btnadd.ButtonText = "Edit";
                    FCAT.txt_catname.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                    FCAT.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                    bunifuTransition1.ShowSync(FCAT);// = FCAT.Show();

                }
            //Edit Books
            else if (State == "BOOKS")
                {
                try
                {
                    PL.FRM_ADDBOOKS FBOOKS = new PL.FRM_ADDBOOKS();
                    FBOOKS.btnadd.ButtonText = "Edit";
                    FBOOKS.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                    DataTable dataTable = new DataTable();
                    dataTable = BLBOOKS.LOADEDIT(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dataTable.Rows[0]["TITLE"];
                    object obj2 = dataTable.Rows[0]["AUTHER"];
                    object obj3 = dataTable.Rows[0]["CAT"];
                    object obj4 = dataTable.Rows[0]["PRICE"];
                    object obj5 = dataTable.Rows[0]["BDATE"];
                    object obj6 = dataTable.Rows[0]["RATE"];
                    object obj7 = dataTable.Rows[0]["COVER"];
                    FBOOKS.txt_title.Text = obj1.ToString();
                    FBOOKS.txt_author.Text = obj2.ToString();
                    FBOOKS.comboBox2.Text = obj3.ToString();
                    FBOOKS.txt_price.Text = obj4.ToString();
                    FBOOKS.txt_date.Text = obj5.ToString();
                    FBOOKS.txt_rate.Value = (int)obj6;
                    //Load Image
                    byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                    FBOOKS.cover.Image = Image.FromStream(ma);
                    bunifuTransition1.ShowSync(FBOOKS);// = FOOKS.Show();
                }
                catch
                {  }              
                }
            //Edit Student
            else if (State == "ST")
            {
                try
                {
                    PL.FRM_ADDSTUDENT FSTUDENT = new PL.FRM_ADDSTUDENT();
                    FSTUDENT.btnadd.ButtonText = "Edit";
                    FSTUDENT.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                    DataTable dataTable = new DataTable();
                    dataTable = BLST.LOADEDIT(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dataTable.Rows[0]["SNAME"];
                    object obj2 = dataTable.Rows[0]["TLOCATION"];
                    object obj3 = dataTable.Rows[0]["PHONE"];
                    object obj4 = dataTable.Rows[0]["EMAIL"];
                    object obj5 = dataTable.Rows[0]["UNIVERSITY"];
                    object obj6 = dataTable.Rows[0]["DEP"];
                    object obj7 = dataTable.Rows[0]["COVER"];
                    FSTUDENT.txt_name.Text = obj1.ToString();
                    FSTUDENT.txt_location.Text = obj2.ToString();   
                    FSTUDENT.txt_phone.Text = obj3.ToString();
                    FSTUDENT.txt_email.Text = obj4.ToString();
                    FSTUDENT.txt_school.Text = obj5.ToString();
                    FSTUDENT.txt_dept.Text = obj6.ToString();
                    //Load Image
                    byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                    FSTUDENT.cover.Image = Image.FromStream(ma);
                    bunifuTransition1.ShowSync(FSTUDENT);// = FSTUDENT.Show();
                }
                catch
                { }
            }
            //Edit SELL
            else if (State == "SELL")
            {
                try
                {
                    PL.FRM_MAKSELL FSELL= new PL.FRM_MAKSELL();
                    FSELL.btnadd.ButtonText = "Edit";
                    FSELL.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                 
                    bunifuTransition1.ShowSync(FSELL);// = FSTUDENT.Show();
                }
                catch
                { }
            }
            //Edit BOR
            else if (State == "BOR")
            {
                try
                {
                    PL.FRM_BRO FBRO = new PL.FRM_BRO();
                    FBRO.btnadd.ButtonText = "Edit";
                    FBRO.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);

                    bunifuTransition1.ShowSync(FBRO);// = FBRO.Show();
                }
                catch
                { }
            }
            //Edit BOR
            else if (State == "US")
            {
                try
                {
                    PL.FRM_ADDUSER FUSER = new PL.FRM_ADDUSER();
                    FUSER.btnadd.ButtonText = "Edit";
                    FUSER.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);

                    bunifuTransition1.ShowSync(FUSER);// = FSTUDENT.Show();
                }
                catch
                { }
            }
        }
            

        
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            //Delete Category
            if (State == "CAT")
            {
                BLCAT.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fDelete = new PL.FRM_DDELETE();
                fDelete.Show();
            }
            //Delete Books
            else if (State == "BOOKS")
            {                           
                BLBOOKS.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fDelete = new PL.FRM_DDELETE();
                fDelete.Show();
            }
            //Delete Student
            else if (State == "ST")
            {
                BLST.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fDelete = new PL.FRM_DDELETE();
                fDelete.Show();

            }
            //Delete SELL
            else if (State == "SELL")
            {
                BLSELL.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fDelete = new PL.FRM_DDELETE();
                fDelete.Show();

            }
            //Delete BOR
            else if (State == "BOR")
            {
                BLBOR.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fDelete = new PL.FRM_DDELETE();
                fDelete.Show();

            }
            //Delete USER
            else if (State == "US")
            {
                BLUSER.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fDelete = new PL.FRM_DDELETE();
                fDelete.Show();

            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            //Search Category
            if (State == "CAT")
            {
                DataTable dataTable = new DataTable();
               dataTable= BLCAT.Search(txt_seach.Text);                   
                    dataGridView1.DataSource = dataTable;
             
            }
            //Search Books
            if (State == "BOOKS")
            {
                DataTable dataTable = new DataTable();
                dataTable = BLBOOKS.Search(txt_seach.Text);
                dataGridView1.DataSource = dataTable;

            }
            //Search Student
            if (State == "ST")
            {
                DataTable dataTable = new DataTable();
                dataTable = BLST.Search(txt_seach.Text);
                dataGridView1.DataSource = dataTable;

            }
            //Search SELL
            if (State == "SELL")
            {
                DataTable dataTable = new DataTable();
                dataTable = BLSELL.Search(txt_seach.Text);
                dataGridView1.DataSource = dataTable;

            }
            //Search BOR
            if (State == "BOR")
            {
                DataTable dataTable = new DataTable();
                dataTable = BLBOR.Search(txt_seach.Text);
                dataGridView1.DataSource = dataTable;

            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            //Detals Books
            if(State == "BOOKS")
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    dataTable = BLBOOKS.LOADEDIT(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dataTable.Rows[0]["TITLE"];
                    object obj2 = dataTable.Rows[0]["AUTHER"];
                    object obj3 = dataTable.Rows[0]["CAT"];
                    object obj4 = dataTable.Rows[0]["PRICE"];
                    object obj5 = dataTable.Rows[0]["BDATE"];
                    object obj6 = dataTable.Rows[0]["RATE"];
                    object obj7 = dataTable.Rows[0]["COVER"];
                    PL.FRM_DETBOOKS DETBOOKS = new PL.FRM_DETBOOKS();

                    DETBOOKS.txt_title.Text = obj1.ToString();
                    DETBOOKS.txt_author.Text = obj2.ToString();
                    DETBOOKS.txt_cat.Text = obj3.ToString();
                    DETBOOKS.txt_price.Text = obj4.ToString();
                    DETBOOKS.txt_date.Text = obj5.ToString();
                    DETBOOKS.txt_rate.Value = (int)obj6;
                    //Load Image
                    byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                    DETBOOKS.cover.Image = Image.FromStream(ma);
                    bunifuTransition1.ShowSync(DETBOOKS);// = FBOOKS.Show();
                }
                catch
                { }
            }
            //Detals Student
            else if (State == "ST")
            {
                try
                {
                    PL.FRM_DETST FSTUDENT = new PL.FRM_DETST();
                    DataTable dataTable = new DataTable();
                    dataTable = BLST.LOADEDIT(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dataTable.Rows[0]["SNAME"];
                    object obj2 = dataTable.Rows[0]["TLOCATION"];
                    object obj3 = dataTable.Rows[0]["PHONE"];
                    object obj4 = dataTable.Rows[0]["EMAIL"];
                    object obj5 = dataTable.Rows[0]["UNIVERSITY"];
                    object obj6 = dataTable.Rows[0]["DEP"];
                    object obj7 = dataTable.Rows[0]["COVER"];
                    FSTUDENT.txt_name.Text = obj1.ToString();
                    FSTUDENT.txt_location.Text = obj2.ToString();
                    FSTUDENT.txt_phone.Text = obj3.ToString();
                    FSTUDENT.txt_email.Text = obj4.ToString();
                    FSTUDENT.txt_school.Text = obj5.ToString();
                    FSTUDENT.txt_dept.Text = obj6.ToString();
                    //Load Image
                    byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                    FSTUDENT.cover.Image = Image.FromStream(ma);
                    bunifuTransition1.ShowSync(FSTUDENT);// = FSTUDENT.Show();
                }
                catch
                { }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            txt_seach.Visible = true;
            bunifuThinButton24.Visible = false;
            State = "SELL"; 
            lb_Title.Text = "Sell";
            //Load Data
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = BLSELL.Load();
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Sequencing"; //sequencing = التسلسل
                dataGridView1.Columns[1].HeaderText = "Book's Name";
                dataGridView1.Columns[2].HeaderText = "Buyer";
                dataGridView1.Columns[3].HeaderText = "Price";
                dataGridView1.Columns[4].HeaderText = "Date";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    }

        private void button6_Click(object sender, EventArgs e)
        {

            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            txt_seach.Visible = false;

            bunifuThinButton24.Visible = false;
            State = "US";
            lb_Title.Text = "Users";
            //Load Data
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = BLUSER.Load();
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Sequencing"; //sequencing = التسلسل
                dataGridView1.Columns[1].HeaderText = "Full Name";
                dataGridView1.Columns[2].HeaderText = "User Name";
                dataGridView1.Columns[3].HeaderText = "Password";
                dataGridView1.Columns[4].HeaderText = "Permission";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            PL.FRM_LOGIN Login = new PL.FRM_LOGIN();
            BLUSER.Logout();
            this.Hide();
            Login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = true;
            P_MAIN.Visible = false;
            lb_Title.Text = "Home";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Add Category
           
                PL.FRM_ADDCAT FCAT = new PL.FRM_ADDCAT();
                FCAT.btnadd.ButtonText = "Add";
                FCAT.ID = 0;
                bunifuTransition1.ShowSync(FCAT);// = FCAT.Show();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
                PL.FRM_ADDBOOKS FBOOKS = new PL.FRM_ADDBOOKS();
                FBOOKS.btnadd.ButtonText = "Add";
                FBOOKS.ID = 0;
                bunifuTransition1.ShowSync(FBOOKS);// = FBOOKS.Show();


            
        }

        private void button9_Click(object sender, EventArgs e)
        {

            PL.FRM_ADDSTUDENT FSTUDENSTS = new PL.FRM_ADDSTUDENT();
            FSTUDENSTS.btnadd.ButtonText = "Add";
            FSTUDENSTS.ID = 0;
            bunifuTransition1.ShowSync(FSTUDENSTS);// = FSTUDENSTS.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            PL.FRM_MAKSELL FSELL = new PL.FRM_MAKSELL();
            FSELL.btnadd.ButtonText = "Add";
            FSELL.ID = 0;
            bunifuTransition1.ShowSync(FSELL);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PL.FRM_BRO FBRO = new PL.FRM_BRO();
            FBRO.btnadd.ButtonText = "Add";
            FBRO.ID = 0;
            bunifuTransition1.ShowSync(FBRO);
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            PL.FRM_REPORT Reaport = new PL.FRM_REPORT();
            Reaport.Show();
        }
    }
}
