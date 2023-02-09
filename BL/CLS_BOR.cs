using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Library_Management_App.BL
{
    internal class CLS_BOR
    {
        DAL.CLS_DAL DAL = new Library_Management_App.DAL.CLS_DAL();

        //Load data
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dataTable = new DataTable();
            dataTable = DAL.read("PR_LOADBOR", pr);
            return dataTable;

        }
        //Load data BOOKS
        public DataTable LoadBOOKS()
        {
            SqlParameter[] pr = null;
            DataTable dataTable = new DataTable();
            dataTable = DAL.read("PR_LOADBOOKFORSELL", pr);
            return dataTable;

        }
        //Load data STUDENT
        public DataTable LoadST()
        {
            SqlParameter[] pr = null;
            DataTable dataTable = new DataTable();
            dataTable = DAL.read("PR_LOADSTFORSELL", pr);
            return dataTable;

        }
        //INSERT DATA
        public void Insert(string BNAME, string BTITLE, string BDATE1,string BDATE2, int PRICE)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("BNAME", BNAME);
            pr[1] = new SqlParameter("BTITLE", BTITLE);
            pr[2] = new SqlParameter("BDATE1", BDATE1);
            pr[3] = new SqlParameter("BDATE2", BDATE2);
            pr[4] = new SqlParameter("PRICE", PRICE);

            DAL.open();
            DAL.Excute("PR_INSERTBOR", pr);
            DAL.close();
        }
        //UPDATE DATA
        public void Update(string BNAME, string BTITLE, string BDATE1, string BDATE2, int PRICE, int ID)
        {
            SqlParameter[] pr = new SqlParameter[6];
            pr[0] = new SqlParameter("BNAME", BNAME);
            pr[1] = new SqlParameter("BTITLE", BTITLE);
            pr[2] = new SqlParameter("BDATE1", BDATE1);
            pr[3] = new SqlParameter("BDATE2", BDATE2);
            pr[4] = new SqlParameter("PRICE", PRICE);
            pr[5] = new SqlParameter("ID", ID);

            DAL.open();
            DAL.Excute("PR_EDITBRO", pr);
            DAL.close();
        }
        //Delete DATA
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);

            DAL.open();
            DAL.Excute("PR_DELETEBOR", pr);
            DAL.close();
        }
        //Search DATA
        public DataTable Search(String search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", search);
            DataTable dataTable = new DataTable();
            dataTable = DAL.read("PR_SEARCHBOR", pr);
            return dataTable; 

        }
    }
}
