using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epic_SpyChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                prevAssignCalendar.SelectedDate = DateTime.Now.Date;
                startAssgnCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                projectCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
            }

        }

        protected void AssignButton_Click(object sender, EventArgs e)
        {
            // spies cost $500 a day
            TimeSpan totalDurationofAssignment = projectCalendar.SelectedDate.Subtract(startAssgnCalendar.SelectedDate);
            double totalCost = totalDurationofAssignment.TotalDays * 500.0;

            //if > 21 then add $1000
            if (totalDurationofAssignment.TotalDays > 21)
            {
                totalCost += 1000.0;
            }

            resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}", 
            codeNameTextBox.Text, 
            assignTextBox.Text, 
            totalCost.ToString());

            TimeSpan timeBetweenAssignments = startAssgnCalendar.SelectedDate.Subtract(prevAssignCalendar.SelectedDate);
            if (timeBetweenAssignments.TotalDays < 14)
            {
                resultLabel.Text  = "Error: Must allow at least two weeks between " +  
                "previous assignment and new assignment.";

                DateTime earliestNewAssignmentDate = prevAssignCalendar.SelectedDate.AddDays(14);
                projectCalendar.SelectedDate = earliestNewAssignmentDate;
                projectCalendar.VisibleDate = earliestNewAssignmentDate;

            }

        }
    }
}