using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;
using System.IO;
namespace Library_Management_App.BL
{
    internal class CLS_ST
    {
        DAL.CLS_DAL DAL = new Library_Management_App.DAL.CLS_DAL();

        //Load data
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dataTable = new DataTable();
            dataTable = DAL.read("PR_LOADST", pr);
            return dataTable;

        }
        //INSERT DATA
        public void Insert(string SNAME, string TLOCATION, string PHONE,string EMAIL, string UNIVERSITY, string DEP,MemoryStream COVER)
        {
            SqlParameter[] pr = new SqlParameter[7];
            pr[0] = new SqlParameter("SNAME", SNAME);
            pr[1] = new SqlParameter("TLOCATION", TLOCATION);
            pr[2] = new SqlParameter("PHONE", PHONE);
            pr[3] = new SqlParameter("EMAIL", EMAIL);
            pr[4] = new SqlParameter("UNIVERSITY", UNIVERSITY);
            pr[5] = new SqlParameter("DEP", DEP);
            pr[6] = new SqlParameter("COVER", COVER.ToArray());

            DAL.open();
            DAL.Excute("PR_INSERTST", pr);
            DAL.close();
        }
        //Load Data for edit
        public DataTable LOADEDIT(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);

            DataTable dataTable = new DataTable();
            dataTable = DAL.read("PR_SELECTEDITST", pr);
            return dataTable;
            
        }
        //Update DATA
        public void Update(string SNAME, string TLOCATION, string PHONE, string EMAIL, string UNIVERSITY, string DEP, MemoryStream COVER,int ID)
        {
            SqlParameter[] pr = new SqlParameter[8];
            pr[0] = new SqlParameter("SNAME", SNAME);
            pr[1] = new SqlParameter("TLOCATION", TLOCATION);
            pr[2] = new SqlParameter("PHONE", PHONE);
            pr[3] = new SqlParameter("EMAIL", EMAIL);
            pr[4] = new SqlParameter("UNIVERSITY", UNIVERSITY);
            pr[5] = new SqlParameter("DEP", DEP);
            pr[6] = new SqlParameter("COVER", COVER.ToArray());
            pr[7] = new SqlParameter("ID", ID);

            DAL.open();
            DAL.Excute("PR_EDITST", pr);
            DAL.close();
        }
        //Delete DATA
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);

            DAL.open();
            DAL.Excute("P_DELETEST", pr);
            DAL.close();
        }
        //Search DATA
        public DataTable Search(String search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", search);
            DataTable dataTable = new DataTable();
            dataTable = DAL.read("PR_SEARCHST", pr); 
            return dataTable;

        }

    }
}
