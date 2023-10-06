using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webapiapplication;

namespace WEBFORM2WITHREFERNCEOFEXISTINGWEBAPI
{
    public partial class WebForm2REFERNCE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            webapi web = new webapi();
            int a = web.add(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
            int b = web.sub(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
            int c = web.mul(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));

            Response.Write("<br> Addition : " + a);
            Response.Write("<br> Subtraction : " + b);
            Response.Write("<br> Multiplication : " + c);
        }
    }
}