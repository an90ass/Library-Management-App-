using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Library_Management_App.BL
{
    internal class CLS_USERS
    {

        DAL.CLS_DAL DAL = new Library_Management_App.DAL.CLS_DAL();

        //Load data
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dataTable = new DataTable();
            dataTable = DAL.read("PR_LOADUSER", pr);
            return dataTable;

        }
        //INSERT DATA
        public void Insert(string CNAME, string CUSER, string  CPASSWORD, string CPREM, string CSTATE)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("CNAME", CNAME);
            pr[1] = new SqlParameter("CUSER", CUSER);
            pr[2] = new SqlParameter("CPASSWORD", CPASSWORD);
            pr[3] = new SqlParameter("CPREM", CPREM);
            pr[4] = new SqlParameter("CSTATE", CSTATE);

            DAL.open();
            DAL.Excute("PR_INSERTUSER", pr);
            DAL.close();
        }
        //Update DATA
        public void Update(string CNAME, string CUSER, string CPASSWORD, string CPREM, int ID)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("CNAME", CNAME);
            pr[1] = new SqlParameter("CUSER", CUSER);
            pr[2] = new SqlParameter("CPASSWORD", CPASSWORD);
            pr[3] = new SqlParameter("CPREM", CPREM);
            pr[4] = new SqlParameter("ID", ID);

            DAL.open();
            DAL.Excute("PR_EDITUSER", pr);
            DAL.close();
        }
        //Delete DATA
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);

            DAL.open();
            DAL.Excute("PR_DELETEUSER", pr);
            DAL.close();
        }
        //Logout
        public void Logout()
        {
            SqlParameter[] pr =null;
           
            DAL.open();
            DAL.Excute("PR_LOGOUT", pr);
            DAL.close();
        }
        //Load data for login
        public DataTable Login(string CUSER,string CPASSWORD)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("CUSER", CUSER);
            pr[1] = new SqlParameter("CPASSWORD", CPASSWORD);

            DataTable dataTable = new DataTable();
            dataTable = DAL.read("PR_LOGIN", pr);
            return dataTable;

        }
        //Update DATA for login
        public void UpdateLOGIN(string CUSER, string CPASSWORD)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("CUSER", CUSER);
            pr[1] = new SqlParameter("CPASSWORD", CPASSWORD);
            DAL.open();
            DAL.Excute("PR_updatelogin", pr);
            DAL.close();
        }
        //Load data for chek start
        public DataTable STARTLOADDATA()
        {
            SqlParameter[] pr = null;
            DataTable dataTable = new DataTable();
            dataTable = DAL.read("PR_START", pr);
            return dataTable;

        }
    }
}
