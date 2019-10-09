using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace control_structres
{
    public partial class Weekly_Calender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    //now time to make a weekly calender
                    //so it will need a loop create for october:
                    //try to put if condition in for loop didnt work
                    //lets try to make a list
                   
                    string day = "";
                    string a2calender = "";
                    a2.InnerHtml = "So your working days is as follows" + "<br>";
                    foreach (ListItem working_days in working_days.Items)
                    {
                        if (working_days.Selected == true)
                        {
                            //its created a claender of  month 
                            //doesn't related with user input
                            //and if i try to relate it with user input 
                            //it give me mutiple calender according to input
                            for (int i = 1; i <= 31; i++)
                            {
                                if (i % 7 == 0)
                                {
                                    day = "monday";
                                }
                                else if (i % 7 == 1)
                                {
                                    day = "tuesday";
                                }
                                else if (i % 7 == 2)
                                {
                                    day = "wednesday";
                                }
                                else if (i % 7 == 3)
                                {
                                    day = "thursday";
                                }
                                else if (i % 7 == 4)
                                {
                                    day = "friday";
                                }
                                else if (i % 7 == 5)
                                {
                                    day = "saturday";
                                }
                                else if (i % 7 == 6)
                                {
                                    day = "sunday";
                                }
                                a2.InnerHtml += "Oct "+ i.ToString() + day + "<br>";

                            }
                            if(working_days.Value == "Monday" && day =="monday")
                            {
                                a2.InnerHtml += "oct" + a2calender + day +"!time to work" + "<br>"; 


                            }
                            

                        }
                    }

                }    
                
            }    
        }
    }
}