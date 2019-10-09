using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace control_structres
{
    public partial class Raffle_Bundle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    //now make ticket purchase
                    //firstly create a single bundle under 50
                    int Tickets_Number = Convert.ToInt32(number_of_tickets.Text);
                    decimal Base_Cost = 0.25M;
                    string a3Tickets = "";
                    if (Tickets_Number <= 50)
                    {

                        for (int i = 1; i <= Tickets_Number; i++)
                        {
                            a3Tickets += "You received a bundle of 1! " + "That's " + i.ToString() + " ticket(s)!" + "<br>";
                        }
                        a3.InnerHtml += a3Tickets;
                        Base_Cost = Base_Cost * Tickets_Number;
                        a3.InnerHtml += "Your  total ticket(s) " + Tickets_Number + " and your cost is $" + Base_Cost.ToString() + "Cad!";


                    }
                    else if (Tickets_Number >= 51 && Tickets_Number <= 150)
                    {
                        for (int i = 2; i <= Tickets_Number; i = i + 2)
                        {
                            a3Tickets += "You received a bundle of 2! " + "That's " + i.ToString() + " ticket(s)!" + "<br>";
                        }
                        //this condition is for remainder
                        if (Tickets_Number % 2 == 1)
                        {
                            a3Tickets += "Your leftover 1 ticket " + "That's " + Tickets_Number + " ticket(s)" + "<br>";
                        }
                        a3.InnerHtml += a3Tickets;
                        Base_Cost = Base_Cost * Tickets_Number;
                        a3.InnerHtml += "Your  total ticket(s) " + Tickets_Number + " and your cost is $" + Base_Cost.ToString() + "Cad!";
                        //how to put condition for leftover so bascially leftover is remainder

                    }
                    else if (Tickets_Number >= 151 && Tickets_Number <= 300)
                    {
                        for (int i = 3; i <= Tickets_Number; i = i + 3)
                        {
                            a3Tickets += "You received a bundle of 3! " + "That's " + i.ToString() + " ticket(s)!" + "<br>";
                        }
                        if (Tickets_Number % 3 == 2)
                        {
                            a3Tickets += "Your leftover 2 ticket(s) " + "That's " + Tickets_Number + " ticket(s)" + "<br>";
                        }
                        a3.InnerHtml += a3Tickets;
                        Base_Cost = Base_Cost * Tickets_Number;
                        a3.InnerHtml += "Your  total ticket(s) " + Tickets_Number + " and your cost is $" + Base_Cost.ToString() + "Cad!";

                    }
                    else if (Tickets_Number >= 301)
                    {
                        for (int i = 5; i <= Tickets_Number; i = i + 5)
                        {
                            a3Tickets += "You received a bundle of 5! " + "That's " + i.ToString() + " ticket(s)!" + "<br>";
                        }
                        if (Tickets_Number % 5 == 4)
                        {
                            a3Tickets += "Your leftover 4 ticket " + "That's " + Tickets_Number + " ticket(s)" + "<br>";
                        }
                        a3.InnerHtml += a3Tickets;
                        Base_Cost = Base_Cost * Tickets_Number;
                        a3.InnerHtml += "Your  total ticket(s) " + Tickets_Number + " and your cost is $" + Base_Cost.ToString() + "Cad!";
                    }




                }
            }

        }
    }
}