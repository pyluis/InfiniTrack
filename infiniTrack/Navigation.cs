/*Author: Team infiniTrack, Group 7
 *Description: The class deals with the navigation between forms.
 *Date: 12/4/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infiniTrack
{
    class Navigation
    {
        //declare const string varibles
        private const string USER_DASHBOARD = "USER DASHBOARD";
        private const string USERWISE_REPORT = "USER WISE REPORT";
        private const string PROJECTWISE_REPORT = "PROJECT WISE REPORT";
        private const string LOGIN = "LOGIN";
        private const string CLOCK = "CLOCK";
        private const string REPORT = "REPORT";
        private const string PROJECT = "PROJECT";
        private const string PROJECT_BULKCREATION = "PROJECT BULK CREATION";
        private const string PROJECT_CREATION = "ADD/UPDATE PROJECT";
        private const string ACCESS_DENIED = "ACCESS DENIED";
        private const string PROJECT_DASHBOARD = "PROJECT DASHBOARD";
        //return the login string
        internal static string Login()
        {
            return LOGIN;
        }
        //rerturn the clock string
        internal static string Clock()
        {
            return CLOCK;
        }
        //return the user dashboard string
        internal static string UserDashboard()
        {
            return USER_DASHBOARD;
        }
        //return the report string
        internal static string Report()
        {
            return REPORT;
        }
        //return the project string
        internal static string Project()
        {
            return PROJECT;
        }
        //return the user wise string
        internal static string UserwiseReport()
        {
            return USERWISE_REPORT;
        }
        //return the project wise string
        internal static string ProjectwiseReport()
        {
            return PROJECTWISE_REPORT;
        }
        //return the project bulk string
        internal static string ProjectBulkCreation()
        {
            return PROJECT_BULKCREATION;
        }
        //return the project crreation string
        internal static string ProjectCreation()
        {
            return PROJECT_CREATION;
        }
        //return the access denied string
        internal static string AccessDenied()
        {
            return ACCESS_DENIED;
        }
        //provides the fade in effect by using an asynchronous method providing a delay
        internal static async void FadeIn(Form form, int interval)
        {
            //Form is not fully invisible. Fade it in
            while (form.Opacity < 1.0)
            {
                //await task by the delay interval
                await Task.Delay(interval);
                form.Opacity += 0.05;
            }
            //Make form fully visible 
            form.Opacity = 1;
        }
        //provides the fade in effect by using an asynchronous method providing a delay
        internal static async void FadeOut(Form form, int interval)
        {
            //Form is fully visible. Fade it out
            while (form.Opacity > 0.0)
            {
                //await task by the delay interval
                await Task.Delay(interval);
                 form.Opacity -= 0.05;
            }
            //Make form fully invisible
            form.Opacity = 0;

            //Task ClosePrevious = ClosePreviousAsync(form);
            //await ClosePrevious;

            //close the previous form.
            form.Close();
        }

        //public async Task ClosePreviousAsync(Form form)
        //{
        //    await Task.Delay(1);
        //    form.Close();
        //} 
        //Navigate to other pages based in menuselection
        internal static void Navigate(Form source, string menuSelection)
        { 
            if (menuSelection.ToUpper() == USER_DASHBOARD.ToUpper())
            {
                FadeOut(source, 50);
                frmUserDashboard userDashboard = new frmUserDashboard();
                userDashboard.Show();
            }
            else if (menuSelection.ToUpper() == USERWISE_REPORT.ToUpper())
            {
                FadeOut(source, 50);
                frmUserwiseReport userwiseReport = new frmUserwiseReport();
                userwiseReport.Show();
            }
            else if(menuSelection.ToUpper() == PROJECTWISE_REPORT.ToUpper())
            {
                FadeOut(source, 50);
                frmProjectwiseReport projectwiseReport = new frmProjectwiseReport();
                projectwiseReport.Show();
            }
            else if(menuSelection.ToUpper() == LOGIN.ToUpper())
            {
                FadeOut(source, 50);
                frmLogin login = new frmLogin();
                login.Show();
            }
            else if(menuSelection.ToUpper() == CLOCK.ToUpper())
            {
                FadeOut(source, 50);
                frmEmployeeClock employeeClock = new frmEmployeeClock();
                employeeClock.Show();
            }
            else if(menuSelection.ToUpper() == PROJECT_BULKCREATION.ToUpper())
            {
                FadeOut(source, 50);
                frmProjectBulkCreation projectBulkCreation = new frmProjectBulkCreation();
                projectBulkCreation.Show();
            }
            else if(menuSelection.ToUpper() == PROJECT_CREATION.ToUpper())
            {
                FadeOut(source, 50);
                frmProjectCreation projectCreation = new frmProjectCreation();
                projectCreation.Show();
            }
            else if(menuSelection.ToUpper() == ACCESS_DENIED.ToUpper())
            {
                FadeOut(source, 50);
                frmAccessDenied accessDenied = new frmAccessDenied();
                accessDenied.Show();
            }
            else if(menuSelection.ToUpper() == PROJECT_DASHBOARD.ToUpper())
            {
                FadeOut(source, 50);
                frmProjectDashboard projectDashboard = new frmProjectDashboard();
                projectDashboard.Show();
            }
            else
            {
                //Do nothing
            }
        }
        //provide values for menu description
        internal static string[] MenuDescription(string menu)
        {
            string[] menuDescription;
            //if report then add the below menu
            if(menu.ToUpper() == REPORT)
            {
                menuDescription = new string[3];
                menuDescription[0] = "Project Wise Report";
                menuDescription[1] = "";
                menuDescription[2] = "User Wise Report";
            }
            //if project then add the below menu
            else if (menu.ToUpper() == PROJECT)
            {
                menuDescription = new string[5];
                menuDescription[0] = "Add/Update Project";
                menuDescription[1] = "";
                menuDescription[2] = "Project Bulk Creation";
                menuDescription[3] = "";
                menuDescription[4] = "Project Dashboard";
            }
            else
            {
                menuDescription = new string[1];
                menuDescription[0] = "";
            }

            return menuDescription;
        }
    }
}
