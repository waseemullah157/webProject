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
        OleDbConnection con;
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

        public int addUser()
        {
            
            OleDbCommand cmd = new OleDbCommand("INSERT INTO users(userName, pass, gender, phNO, email,address) VALUES("
               + " @uname, @pass, @gender, @contactno, @email,@address); ", con);
            String name = "Wasay";
            String email = "Syedwasay041";
            String contactno = "03445959907";
            String password = "123";
            String adress = "House no 213";
            int gender = 0;
            cmd.Parameters.AddWithValue("@uname",name);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@gender",gender );
            cmd.Parameters.AddWithValue("@contactno", contactno);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@address", adress);
            createConnection();
            con.Open();
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