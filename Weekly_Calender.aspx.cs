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
                    //foreach (ListItem working_day in working_days.Items)
                    //{
                    //    if (working_day.Selected == true)
                    //    {
                    //its created a claender of  month 
                    //doesn't related with user input
                    //and if i try to relate it with user input 
                    //it give me mutiple calender according to input
                    // this is a loop with output of oct calender
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
                        a2calender = "Oct " + i.ToString() + day;
                        //try to connected calender with checkbox
                        //if the above condition and user inout is matcehs run this statement
                        foreach (ListItem working_day in working_days.Items)
                        {
                            Boolean flag = false;
                            switch (working_day.Value)
                            {
                                case "Monday":
                                    //its working fine but give me related output 
                                    //only the issue is that it multiple the output 
                                    if (day == "monday")
                                    {
                                        a2.InnerHtml += a2calender + "!time to work 1" + "<br>";
                                        flag = true;
                                    }
                                    break;
                                case "Tuesday":
                                    if (day == "tuesday")
                                    {
                                        a2.InnerHtml += a2calender + "!time to work 2" + "<br>";
                                        flag = true;
                                    }
                                    break;
                                case "Wednesday":
                                    if (day == "wednesday")
                                    {
                                        a2.InnerHtml += a2calender + "!time to work 3" + "<br>";
                                        flag = true;
                                    }
                                    break;
                                case "Thursday":
                                    if (day == "thursday")
                                    {
                                        a2.InnerHtml += a2calender + "!time to work 4" + "<br>";
                                        flag = true;
                                    }
                                    break;
                                case "Friday":
                                    if (day == "friday")
                                    {
                                        a2.InnerHtml += a2calender + "!time to work 5" + "<br>";
                                        flag = true;
                                    }
                                    break;
                                case "Saturday":
                                    if (day == "saturday")
                                    {
                                        a2.InnerHtml += a2calender + "!time to work 6" + "<br>";
                                        flag = true;
                                    }
                                    break;
                                case "Sunday":
                                    if (day == "sunday")
                                    {
                                        a2.InnerHtml += a2calender + "!time to work 7" + "<br>";
                                        flag = true;
                                    }
                                    break;
                            }
                            if (!flag) { 
                                a2.InnerHtml += a2calender + "!time to have fun" + "<br>";
                            }



                        }


                    }

                }

            }
        }
    }
}
