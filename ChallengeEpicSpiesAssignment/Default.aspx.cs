using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                previousCalendar.SelectedDate = DateTime.Now.Date;
                newCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                endCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);

            }
        }
        protected void AssignButton_Click(object sender, EventArgs e)
        {
            TimeSpan totalDurationOfAssignment = endCalendar.SelectedDate.Subtract(newCalendar.SelectedDate);
           
            double totalCost = totalDurationOfAssignment.TotalDays * 500.0;
            if (totalDurationOfAssignment.TotalDays > 21)
            {
                    totalCost += 1000.0;

            }
            
            resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Total budget: {2:C}",
                codeNameTextBox.Text,
                newAssignmentTextBox.Text,
                totalCost);

            TimeSpan timeBetweenAssignments = newCalendar.SelectedDate.Subtract(previousCalendar.SelectedDate);

            if (timeBetweenAssignments.TotalDays < 14)
            {
                resultLabel.Text = "Error: Must allow 14 days between" + "last assignment and new assignment";
                DateTime earliestNewAssignmentDate = previousCalendar.SelectedDate.AddDays(14);
                newCalendar.SelectedDate = earliestNewAssignmentDate;
                newCalendar.VisibleDate = earliestNewAssignmentDate;
            }
        }  
                         

                    
    }
}