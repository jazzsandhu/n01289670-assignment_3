using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace control_structres
{
    public partial class control : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    int X = Convert.ToInt32(quadrpole_x.Text);
                    int Y = Convert.ToInt32(quadrpole_y.Text); 
                    //convert x value in integer
                    //how to make a condition for x varies in + and -
                    //its create a redundancy 
                    if (X>=0 && Y>=0)
                    {
                        a1.InnerHtml += "(" + quadrpole_x.Text +","+ quadrpole_y.Text + ")" + " falls in quadrant Q1" + "<br>";
                    }
                    else if (X<=0 && Y>=0)
                    {
                        a1.InnerHtml += "(" + quadrpole_x.Text + "," + quadrpole_y.Text + ")" + " falls in quadrant Q2" + "<br>";
                    }
                    else if (X<=0 && Y <= 0)
                    {
                        a1.InnerHtml += "(" + quadrpole_x.Text + "," + quadrpole_y.Text + ")" + " falls in quadrant Q3" + "<br>";
                    }
                    else if(X>=0 && Y <= 0)
                    {
                        a1.InnerHtml += "(" + quadrpole_x.Text + "," + quadrpole_y.Text + ")" + " falls in quadrant Q4" + "<br>";
                    }
                    else if(X==0 && Y == 0)
                    {
                        a1.InnerHtml += "(" + quadrpole_x.Text + "," + quadrpole_y.Text + ")" + " falls at origin" + "<br>";
                    }
                    else
                    {
                        a1.InnerHtml += "make a non-zero input" + "<br>";
                    }


                } 
            }

        }
    }
}