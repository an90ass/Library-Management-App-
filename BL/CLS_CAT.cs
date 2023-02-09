using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Library_Management_App.BL
{
    internal class CLS_CAT
    {
      
        DAL.CLS_DAL DAL = new Library_Management_App.DAL.CLS_DAL();

        // mthod to bring the data
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dataTable = new DataTable();
           dataTable=  DAL.read("PR_LOADCAT",pr);
            return dataTable;

        }
        //Search DATA
        public DataTable Search(String search)
        {
            SqlParameter []pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", search);
            DataTable dataTable = new DataTable();
            dataTable = DAL.read("P_CATSEARCH", pr);
            return dataTable;

        }
        //INSERT DATA
        public void Insert(string CAT_NAME)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("CAT_NAME", CAT_NAME);
            DAL.open();
            DAL.Excute("P_ADDCAT", pr);
            DAL.close();
        }
        //Update DATA
        public void Update(string CAT_NAME,int ID)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("CAT_NAME", CAT_NAME);
            pr[1] = new SqlParameter("ID", ID);

            DAL.open();
            DAL.Excute("P_EDITCAT", pr);
            DAL.close();
        }
        //Delete DATA
        public void Delete( int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);

            DAL.open();
            DAL.Excute("P_DELETECAT", pr);
            DAL.close();
        }
    }
}
