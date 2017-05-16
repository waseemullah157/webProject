using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace webProject
{
    public class DBHandler
    {
        string connectionString;
        public DBHandler()
        {
            connectionString = ConfigurationManager.ConnectionStrings["CS"].ConnectionString; 
        }
        private void createConnection()
        {

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
            String name = "Wasay";
            String email = "Syedwasay041";
            String contactno = "03445959907";
            String password = "123";
            String adress = "House no 213";

            return 0;
        }
    }
}