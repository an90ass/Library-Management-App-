using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Library_Management_App.DAL
{
     class CLS_DAL//Data acsess layer
    {
        SqlConnection con = new SqlConnection();
    
  // constructur
   public CLS_DAL()
    {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anass\Desktop\Lip\Library Management App\Library Management App\DBLILMA.mdf;Integrated Security=True");
    }
        //Method to open Sql Connection
        public void open()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        //Method to close Sql Connection
        public void close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        //Function to read Data
        public DataTable read(String store, SqlParameter[]pr )
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store; 
            if(pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            return dataTable;
        }

        //Excute to Insert ,Edit , Delete
        public void Excute(String store, SqlParameter[] pr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;
            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            cmd.ExecuteNonQuery();
        }



    }
}