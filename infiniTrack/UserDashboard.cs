/*Author: Team infiniTrack, Group 7
 *Description: The form shows the user a list of projects, gives filter options for projects and and also provides
 *the option of clicking on a project in datagrid view and redirect to project dashboard if the user has appropriate access level
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
    public partial class frmUserDashboard : Form
    {
        public frmUserDashboard()
        {
            InitializeComponent();
        }
        // declare private string access
        private string access;

        private void frmUserDashboard_Load(object sender, EventArgs e)
        {
            //get the employee access level
            access = Employee.GetAccess();
            // TODO: This line of code loads data into the 'infinitrackDataSet.project' table. You can move, or remove it, as needed.
            this.projectTableAdapter.Fill(this.infinitrackDataSet.project);
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
            toolTipUserDashboard.SetToolTip(btnClose, "Close");
            toolTipUserDashboard.SetToolTip(btnMax, "Maximize/Restore");
            toolTipUserDashboard.SetToolTip(btnMin, "Minimize");
            toolTipUserDashboard.SetToolTip(btnHome, "Home");
            toolTipUserDashboard.SetToolTip(btnReport, "Report");
            toolTipUserDashboard.SetToolTip(btnProject, "Project");
            toolTipUserDashboard.SetToolTip(btnLogout, "Logout");
            toolTipUserDashboard.SetToolTip(btnClock, "Clock in/out");
            //remove the initial selection of datagridview
            projectDataGridView.Rows[0].Cells[0].Selected = false;
        }

        //provides the title bar controls
        private void titleBar_Controls(object sender, EventArgs e)
        {
            //closes the application
            if(sender == btnClose)
            {
                TitleBar.Close();
            }
            //maximize and rerstore the application
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
        //provides navigation controls from this form to another or shows the sliding menu for further selection
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
            else
            {
                //if sliding menu is hidden , then show the sliding menu and load menu
                if (pnlMenuDescription.Visible == false)
                {
                    Load_MenuDescription(sender);
                    pnlMenuDescription.Show();
                }
                //else clear the menu and hide the sliding menu
                else if (pnlMenuDescription.Visible == true)
                {
                    pnlMenuDescription.Hide();
                    lstMenuDescription.Items.Clear();
                }
            }
        }
        // this method loads the menu description of the sliding panel
        private void Load_MenuDescription(object sender)
        {
            //declare an array to contain the menu description
            string[] menuDescription;
            //if button report is clicked then load report menu
            if(sender == btnReport)
            {
                menuDescription = Navigation.MenuDescription(Navigation.Report());
            }
            //if button project is clicked then load project menu
            else if (sender == btnProject)
            {
                menuDescription = Navigation.MenuDescription(Navigation.Project());
            }
            //else dont load any menu desciption
            else
            {
                menuDescription = Navigation.MenuDescription("");
            }
            //add the menu description from the array to listbox.
            foreach(string menu in menuDescription)
            {
                lstMenuDescription.Items.Add(menu);
            }
        }
        //on click of an item from the listbox in sliding menu
        private void lstMenuDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if the selection is not null, navigate to the required form
            if (lstMenuDescription.SelectedItem != null)
            {
                Navigation.Navigate(this, lstMenuDescription.SelectedItem.ToString());
            }
            //hide the sliding menu
            pnlMenuDescription.Hide();
            //clear the sliding menu items.
            lstMenuDescription.Items.Clear();
        }

        private void frmUserDashboard_Click(object sender, EventArgs e)
        {
            //on a click on the form area, hide the sliding menu and clear the sliding menu items.
            pnlMenuDescription.Hide();
            lstMenuDescription.Items.Clear();
        }

        private void projectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infinitrackDataSet);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //clear the search text box
            txtProjectSearch.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //display error message if no keyword is entered
            if (txtProjectSearch.Text == "")
                MessageBox.Show("Please enter a keyword to search", "Search by keyword",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

            //dispay error message if no button is selected
            if (!rdbCategory.Checked && !rdbProjectName.Checked)
                MessageBox.Show("Please choose which column to search by selecting a button",
                    "Search by keyword", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

            if (rdbCategory.Checked)
            {
                //search the data by category and show in the datagridview
                projectTableAdapter.FillByCategory(infinitrackDataSet.project, txtProjectSearch.Text.Trim());
            }

            if(rdbProjectName.Checked)
            {
                //search the data by project_name and show in the datagridview
                projectTableAdapter.FillByProject_Name(infinitrackDataSet.project, txtProjectSearch.Text.Trim());
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            //Show all records
            projectTableAdapter.FillByAll(infinitrackDataSet.project);
        }

        private void btnOnGoing_Click(object sender, EventArgs e)
        {
            //show on-going projects
            projectTableAdapter.FillByCompletion_Ind(infinitrackDataSet.project);
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            //show completed projects
            projectTableAdapter.FillByFinished(infinitrackDataSet.project);
        }

        private void txtProjectSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allows control keys and letters
            if (!(char.IsLetter(e.KeyChar)) &
                !(char.IsControl(e.KeyChar))
                & (e.KeyChar != '.'))
                //cancel the key
                e.Handled = true;
        }

        //this method provides the navigation to project dashboard by selecting a project from the datagrid view
        private void projectDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if employee has a manager access level only then allow to navigate to project dashboard
            if(access.ToUpper() == Employee.Manager())
            {
                //get the rowindex of the current selected cell
                int rowIndex = projectDataGridView.CurrentCell.RowIndex;
                //set the selection for the entire row with the same rowindex
                projectDataGridView.Rows[rowIndex].Selected = true;
                //get the project name from the row with the same rowindex 
                string projectName = projectDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                //navigate to the project dashboard by supplying the project name.
                frmProjectDashboard projectDashboard = new frmProjectDashboard(projectName);
                //close the form with a fade out effect.
                Navigation.FadeOut(this, 50);
                projectDashboard.Show();
            }
        }
    }
}
