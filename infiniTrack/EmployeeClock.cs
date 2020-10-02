/*Author: Team infiniTrack, Group 7
 *Description: The page corresponds to the start of the application. It displays the app logo from about 3 seconds.
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
using System.Data.SqlClient;

namespace infiniTrack
{
    public partial class frmEmployeeClock : Form
    {
        public frmEmployeeClock()
        {
            InitializeComponent();
        }

        // define variable employee ID
        string employeeId;

        // code for form load event
        private void frmEmployeeClock_Load(object sender, EventArgs e)
        {
            activity_laborTableAdapter.Fill(infinitrackDataSet.activity_labor);
            //get the employee ID
            employeeId = Employee.GetEmployeeID();
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
            toolTipClock.SetToolTip(btnClose, "Close");
            toolTipClock.SetToolTip(btnMax, "Maximize/Restore");
            toolTipClock.SetToolTip(btnMin, "Minimize");
            toolTipClock.SetToolTip(btnHome, "Home");
            toolTipClock.SetToolTip(btnReport, "Report");
            toolTipClock.SetToolTip(btnProject, "Project");
            toolTipClock.SetToolTip(btnLogout, "Logout");
            toolTipClock.SetToolTip(btnClock, "Clock in/out");
            DataTable dt = new DataTable();
            dt = projectTableAdapter.GetDataByProjectName();
            // insert project names to project combobox using for loop
            for(int i=0; i< dt.Rows.Count; i++)
            {
                cmbProject.Items.Add(dt.Rows[i]["Project_Name"].ToString());
            }
            //select the item at first index
            cmbProject.SelectedIndex = 0;
            //remove the default selection of data gridview
            activity_laborDataGridView.Rows[0].Cells[0].Selected = false;
        }

        // //provides the title bar controls
        private void titleBar_Controls(object sender, EventArgs e)
        {
            //closes the application
            if (sender == btnClose)
            {
                TitleBar.Close();
            }
            //maximize and rerstore the application
            else if (sender == btnMax)
            {
                TitleBar.Maximize(this);
            }
            //minimize the application
            else if (sender == btnMin)
            {
                TitleBar.Minimize(this);
            }
        }

        //provides navigation controls from this form to another or shows the sliding menu for further selection
        private void pnlMenu_Click(object sender, EventArgs e)
        {
            if (sender == btnLogout)
            {
                //navigate to login
                Navigation.Navigate(this, Navigation.Login());
            }
            else if(sender == btnHome)
            {
                //navigate to user dashboard
                Navigation.Navigate(this, Navigation.UserDashboard());
            }
            else if(sender == btnClock)
            {
                //do nothing
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
            if (sender == btnReport)
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
            foreach (string menu in menuDescription)
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
                //if the selection is not the current form, then naviagate to required form.
                if (lstMenuDescription.SelectedItem.ToString().ToUpper() != Navigation.Clock())
                {
                    Navigation.Navigate(this, lstMenuDescription.SelectedItem.ToString());
                }
            }
            //hide the sliding menu
            pnlMenuDescription.Hide();
            //clear the sliding menu items.
            lstMenuDescription.Items.Clear();
        }


        private void frmEmployeeClock_Click(object sender, EventArgs e)
        {
            //on a click on the form area, hide the sliding menu and clear the sliding menu items.
            pnlMenuDescription.Hide();
            lstMenuDescription.Items.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear inputs
            cmbProject.SelectedIndex = 0;
            cmbPhase.Items.Clear();
            cmbActivity.Items.Clear();
        }

        private void btnSaveTime_Click(object sender, EventArgs e)
        {
            // check for null values
            if ((cmbPhase.SelectedItem == null) ||
                (cmbProject.SelectedItem == null) ||
                (cmbActivity.SelectedItem == null))
            {
                // show error message
                MessageBox.Show("Please select project name and activity and phase.", "Employee Clock",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                if (dtpClockedIn.Value < dtpClockedOut.Value)
                {
                    // get user input & define variable
                    string Project = cmbProject.Text;
                    string Phase = cmbPhase.Text;
                    DateTime clockIn = dtpClockedIn.Value;
                    DateTime clockOut = dtpClockedOut.Value;

                    // export the data to database
                    activity_laborTableAdapter.InsertClockQuery(int.Parse(cmbActivity.SelectedItem.ToString()), int.Parse(employeeId), dtpDate.Value.ToShortDateString(), clockIn, clockOut);
                    MessageBox.Show("Inserted Correctly", "infinitrack", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // fill the data gridview
                    activity_laborTableAdapter.Fill(infinitrackDataSet.activity_labor);
                    
                
                }
                else
                {
                    // show message box clock out time is earlier than clock in
                    MessageBox.Show("Clocked in time cannot be less than clocked out time", "Employee Clock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void cmbPhase_SelectedIndexChanged(object sender, EventArgs e)
        {
            // run sql query to find corresponding Activity ID to selected phase
            cmbActivity.Items.Clear();
            DataTable dt = new DataTable();
            string selectQuery = "SELECT pa.Activity_ID FROM project_activity AS pa INNER JOIN project_phase AS pp ON pa.Phase_ID = pp.Phase_ID WHERE(pp.Phase_ID = '" + cmbPhase.SelectedItem.ToString() + "')";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\infinitrack.mdf;Integrated Security=True;Connect Timeout=30";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connectionString);
            SqlCommandBuilder sqlCommand = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Fill(dt);

            // use for loop to insert data into activity combobox with activity ID
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbActivity.Items.Add(dt.Rows[i]["Activity_ID"].ToString());
                }
                cmbActivity.SelectedIndex = 0;
            }
        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            // run sql query to find corresponding phase ID to selected project
            cmbPhase.Items.Clear();
            cmbActivity.Items.Clear();
            DataTable dt = new DataTable();
            string selectQuery = "SELECT pp.Phase_ID FROM project_phase AS pp INNER JOIN project AS p ON pp.Project_ID = p.Project_ID WHERE(p.Project_Name = '" + cmbProject.SelectedItem.ToString() + "')";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\infinitrack.mdf;Integrated Security=True;Connect Timeout=30";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connectionString);
            SqlCommandBuilder sqlCommand = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Fill(dt);

            // use for loop to insert data into phase combobox with phase ID
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbPhase.Items.Add(dt.Rows[i]["Phase_ID"].ToString());
                }
                cmbPhase.SelectedIndex = 0;
            }
        }

        private void activity_laborBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.activity_laborBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infinitrackDataSet);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //check if any cell or row is selected, else display message
            if (!activity_laborDataGridView.CurrentCell.Selected)
            {
                MessageBox.Show("Please select a tran_id from the grid to delete.", "infiniTrack", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ///get the rowindex of the current selected cell
                int rowIndex = activity_laborDataGridView.CurrentCell.RowIndex;
                //set the selection for the entire row with the same rowindex
                activity_laborDataGridView.Rows[rowIndex].Selected = true;
                //get the tran_id of the selected row
                int trans_id = int.Parse(activity_laborDataGridView.Rows[rowIndex].Cells[0].Value.ToString());
                //delete the value from database
                activity_laborTableAdapter.DeleteClock(trans_id);
                //show success messgae
                MessageBox.Show("Deleted record successfully", "infiniTrack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //reload the datagrid
                activity_laborTableAdapter.Fill(infinitrackDataSet.activity_labor);
                //remove the default selection of data gridview
                activity_laborDataGridView.Rows[0].Cells[0].Selected = false;
            }
        }
    }
}
