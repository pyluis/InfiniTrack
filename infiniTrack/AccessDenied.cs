/*Author: Team infiniTrack, Group 7
 *Description: Form is displayed when access is denied when user enters forms above their access level
 *Date: 12/4/2018
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace infiniTrack
{
    public partial class frmAccessDenied : Form
    {
        public frmAccessDenied()
        {
            InitializeComponent();
        }

        private void frmAccessDenied_Load(object sender, EventArgs e)
        {
            //hide the sliding menu description panel and set its width
            pnlMenuDescription.Hide();
            pnlMenuDescription.Width = 204;
            //get the file path for all the icons and pictures involved on the form
            string iconsDirectory = Directory.GetCurrentDirectory() + "\\icons\\";
            //load all the icons and images on form load
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            btnClose.Image = Image.FromFile(iconsDirectory + "close.png");
            btnMax.Image = Image.FromFile(iconsDirectory + "max.png");
            btnMin.Image = Image.FromFile(iconsDirectory + "min.png");
            picLogo.ImageLocation = iconsDirectory + "logo.png";
            btnHome.Image = Image.FromFile(iconsDirectory + "home.png");
            btnReport.Image = Image.FromFile(iconsDirectory + "report.png");
            picHorizontalLine.ImageLocation = iconsDirectory + "horizontalline.png";
            picVerticalLine.Image = Image.FromFile(iconsDirectory + "verticalline.png");
            btnProject.Image = Image.FromFile(iconsDirectory + "project.png");
            btnClock.Image = Image.FromFile(iconsDirectory + "clock.png");
            btnLogout.Image = Image.FromFile(iconsDirectory + "logout.png");
            //set tooltip
            toolTipDashboard.SetToolTip(btnClose, "Close");
            toolTipDashboard.SetToolTip(btnMax, "Maximize/Restore");
            toolTipDashboard.SetToolTip(btnMin, "Minimize");
            toolTipDashboard.SetToolTip(btnHome, "Home");
            toolTipDashboard.SetToolTip(btnReport, "Report");
            toolTipDashboard.SetToolTip(btnProject, "Project");
            toolTipDashboard.SetToolTip(btnLogout, "Logout");
            toolTipDashboard.SetToolTip(btnClock, "Clock in/out");
            //remove the initial selection of dataGridview
            picDenied.ImageLocation = iconsDirectory + "denied.png";
        }
        //provides the title bar controls
        private void titleBar_Controls(object sender, EventArgs e)
        {
            //closes the application
            if(sender == btnClose)
            {
                TitleBar.Close();
            }
            //maximize and restore the application 
            else if(sender == btnMax)
            {
                TitleBar.Maximize(this);
            }
            //minimize the application
            else if(sender == btnMin)
            {
                TitleBar.Minimize(this);
            }
        }
        //provides navigation controls from this form to another or shows the sliding menu for further
        private void pnlMenu_Click(object sender, EventArgs e)
        {
            if (sender == btnLogout)
            {
                //navigate to the login form
                Navigation.Navigate(this, Navigation.Login());
            }
            else if(sender == btnClock)
            {
                //navigate to employee clock

                Navigation.Navigate(this, Navigation.Clock());
            }
            else if(sender == btnHome)
            {

                Navigation.Navigate(this, Navigation.UserDashboard());
            }
            else
            {
                //if sliding menu is hidden , then show the sliding menu and load menu
                if (pnlMenuDescription.Visible == false)
                {
                    Load_MenuDescription(sender);
                    pnlMenuDescription.Show();
                }
                else if (pnlMenuDescription.Visible == true)
                {
                    pnlMenuDescription.Hide();
                    lstMenuDescription.Items.Clear();
                }
            }
        }

        private void Load_MenuDescription(object sender)
        {
            string[] menuDescription;
            if(sender == btnReport)
            {
                menuDescription = Navigation.MenuDescription(Navigation.Report());
            }
            else if(sender == btnProject)
            {
                menuDescription = Navigation.MenuDescription(Navigation.Project());
            }
            else
            {
                menuDescription = Navigation.MenuDescription("");
            }

            foreach(string menu in menuDescription)
            {
                lstMenuDescription.Items.Add(menu);
            }
        }

        private void lstMenuDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMenuDescription.SelectedItem != null)
            {
                Navigation.Navigate(this, lstMenuDescription.SelectedItem.ToString());
            }
            pnlMenuDescription.Hide();
            lstMenuDescription.Items.Clear();
        }

        private void frmAccessDenied_Click(object sender, EventArgs e)
        {
            pnlMenuDescription.Hide();
            lstMenuDescription.Items.Clear();
        }
    }
}
