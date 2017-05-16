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

            
           
            if (IsPostBack)
            {
                int a = 0;
               string gen = genderDropDownList.Text;
                if (gen.Equals("Male"))
                    a = 1;
                else if (gen.Equals("Female"))
                    a = 0;
                else
                    a = 2;
                new DBHandler().addUser(fullName.Text, email.Text, phone.Text, pass.Text,addres.Text, a);

                Response.Redirect("Home.aspx");


                    

                //Javaria Laptop Comment
            }
        }
    }
}