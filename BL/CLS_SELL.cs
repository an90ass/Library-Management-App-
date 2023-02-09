using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Library_Management_App.BL
{
    internal class CLS_SELL
    {
        DAL.CLS_DAL DAL = new Library_Management_App.DAL.CLS_DAL();

        //Load data
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dataTable = new DataTable();
            dataTable = DAL.read("PR_LOADSELL", pr);
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
        public void Insert(string SNAME, string BTITLE, int PRICE, string BDATE)
        {
            SqlParameter[] pr = new SqlParameter[4];
            pr[0] = new SqlParameter("SNAME", SNAME);
            pr[1] = new SqlParameter("BTITLE", BTITLE);
            pr[2] = new SqlParameter("PRICE", PRICE);
            pr[3] = new SqlParameter("BDATE", BDATE);

            DAL.open();
            DAL.Excute("PR_INSERTSELL", pr);
            DAL.close();
        }
        //UPDATE DATA
        public void Update(string SNAME, string BTITLE, int PRICE, string BDATE,int ID)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("SNAME", SNAME);
            pr[1] = new SqlParameter("BTITLE", BTITLE);
            pr[2] = new SqlParameter("PRICE", PRICE);
            pr[3] = new SqlParameter("BDATE", BDATE);
            pr[4] = new SqlParameter("ID", ID);

            DAL.open();
            DAL.Excute("PR_EDITSELL", pr);
            DAL.close();
        }
        //Delete DATA
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);

            DAL.open();
            DAL.Excute("PR_DELETESELL", pr);
            DAL.close();
        }
        //Search DATA
        public DataTable Search(String search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", search);
            DataTable dataTable = new DataTable();
            dataTable = DAL.read("PR_SEARCHSELL", pr);
            return dataTable; 

        }
    }
}
