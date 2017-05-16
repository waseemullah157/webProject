using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webProject;

namespace webProject
{
    public partial class SignUp : System.Web.UI.Page
    {
        //Wasay Comment From Laptop
        protected void Page_Load(object sender, EventArgs e)
        {
            
            fullName.Text = (new DBHandler()).getConnectionString();
            if (IsPostBack)
            {
                new DBHandler().addUser();
                //Javaria Laptop Comment
            }
        }
    }
}