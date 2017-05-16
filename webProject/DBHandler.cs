using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace webProject
{
    public class DBHandler
    {
        public OleDbConnection con;
        string connectionString;
        public DBHandler()
        {
            connectionString = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            

        }
        private void createConnection()
        {
            con = new OleDbConnection(connectionString);
        }
        public string getConnectionString()
        {
            return connectionString;
        }
        public bool validateLogin() {

            return false;
        }

        public int addUser(String name ,
        String email ,
        String contactno,
        String password ,
        String adress,
        int gender )
        {
               createConnection();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO users(userName, pass, gender, phNO, email,address) VALUES( @uname, @pass, @gender, @contactno, @email,@address); ",con);
            
            
            cmd.Parameters.AddWithValue("@uname",name);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@gender",gender );
            cmd.Parameters.AddWithValue("@contactno", contactno);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@address", adress);
         
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }


            return 0;

        }
    }
}