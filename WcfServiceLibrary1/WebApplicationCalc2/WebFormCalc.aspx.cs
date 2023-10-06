using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationCalc2
{
    public partial class WebFormCalc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.Service1Client obj = new ServiceReference2.Service1Client();
            // Console.Write("enter the first number: ");
            int n1 = Convert.ToInt32(TextBox1.Text);
            // Console.Write("enter the second number: ");
            int n2 = Convert.ToInt32(TextBox2.Text);

            Response.Write("<br> Addition result is : " + obj.Addition(n1, n2));
            Response.Write("<br>Substraction result is : " + obj.Substract(n1, n2));
            Response.Write("<br>Multiplcation result is : " + obj.Multiplication(n1, n2));
            Response.Write("<br>Addition result is : " + obj.Division(n1, n2));
            
        }
    }
}