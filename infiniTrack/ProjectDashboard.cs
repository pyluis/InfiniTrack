/*Author: Team infiniTrack, Group 7
 *Description: The form correspods to the managing the project and adding attributes to a project.
 * This form has access by only users have manager access
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
using System.Configuration;

namespace infiniTrack
{
    public partial class frmProjectDashboard : Form
    {
        //declare private variables projectName and access
        private string projectName;
        private string accees;
        //constructor 1
        public frmProjectDashboard()
        {
            InitializeComponent();
            projectName = "";
        }
        //cinstructor 2 with projectname as a parameter.
        public frmProjectDashboard(string projectName)
        {
            InitializeComponent();
            this.projectName = projectName;
        }

        private void frmProjectDashboard_Load(object sender, EventArgs e)
        {
            //get the employee access level
            accees = Employee.GetAccess();
            if (accees.ToUpper() == Employee.User())
            {
                //if access level is user, navigate to access denied.
                Navigation.Navigate(this, Navigation.AccessDenied());
            }
            else
            {
                // TODO: This line of code loads data into the 'infinitrackDataSet.project_activity' table. You can move, or remove it, as needed.
                this.project_activityTableAdapter.Fill(this.infinitrackDataSet.project_activity);
                // TODO: This line of code loads data into the 'infinitrackDataSet.project_phase' table. You can move, or remove it, as needed.
                this.project_phaseTableAdapter.Fill(this.infinitrackDataSet.project_phase);
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
                toolTipProjectDashboard.SetToolTip(btnClose, "Close");
                toolTipProjectDashboard.SetToolTip(btnMax, "Maximize/Restore");
                toolTipProjectDashboard.SetToolTip(btnMin, "Minimize");
                toolTipProjectDashboard.SetToolTip(btnHome, "Home");
                toolTipProjectDashboard.SetToolTip(btnReport, "Report");
                toolTipProjectDashboard.SetToolTip(btnProject, "Project");
                toolTipProjectDashboard.SetToolTip(btnLogout, "Logout");
                toolTipProjectDashboard.SetToolTip(btnClock, "Clock in/out");

                //hide panels                          
                pnlPhase1.Hide();          
                pnlPhase2.Hide();                
                pnlPhase3.Hide();
                //Fill combo box items for project select
                cmbProjectName.Items.Add("--Select a Project--");
                cmbProjectName.SelectedIndex = 0;
                //instantiate a new data table object
                DataTable dt = new DataTable();
                //set data source for dt DataTable
                dt = projectTableAdapter.GetDataByProjectName();
                
                //loop through dt and add values to combo box
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbProjectName.Items.Add(dt.Rows[i]["Project_Name"].ToString());
                } 
                //check for a passed on projectName to start the project with 
                if(projectName != "")
                {
                    cmbProjectName.SelectedItem = projectName;
                }
                
            }
        }
        //provides the title bar controls
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
                //navigate to user dashboard
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
                Navigation.Navigate(this, lstMenuDescription.SelectedItem.ToString());
            }
            //hide the sliding menu
            pnlMenuDescription.Hide();
            //clear the sliding menu items.
            lstMenuDescription.Items.Clear();
        }

        private void frmProjectDashboard_Click(object sender, EventArgs e)
        {
            pnlMenuDescription.Hide();
            lstMenuDescription.Items.Clear();
        }

        private void projectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infinitrackDataSet);

        }

        private void btnAddPhase_Click(object sender, EventArgs e)
        {
            //instantiate a new addPhase form
            frmAddPhase frmAddPhase = new frmAddPhase();
            //display new addPhase as a dialog
            frmAddPhase.ShowDialog();
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            //instantiate a new addActivity form
            frmAddActivity frmAddActivity = new frmAddActivity();
            //display new addActivity form as  dialog
            frmAddActivity.ShowDialog();
        }


        private void cmbProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if cmbProjectname selected item is not null perform the select change
            if (cmbProjectName.SelectedItem != null)
            {
                //if index equal to zero do not do anything else peform the index change event
                if (cmbProjectName.SelectedIndex == 0)
                {
                }
                else
                {
                    //set variable for the comboBox selected item
                    string selectedProjectName = cmbProjectName.SelectedItem.ToString();
                    //call the GetProjectID method to get the selected project's id
                    int selectedProjectID = GetProjectID(selectedProjectName);
                    //call the showPanels method to display appropriate panels based on the projectID of the selected project
                    ShowPanels(selectedProjectID);
                }
            }
          
        }

        private void ShowPanels(int selectedProject)
        {
            //Get a count of all the phases associated with the selectedProject
            int phaseCount = GetPhaseCount(selectedProject);
            //Depending on the phase count display the appropriate amounts of panels. i.e if one phase in the project display only panel one, if two display both one and two
            if(phaseCount == 1)
            {
                pnlPhase1.Show();
                pnlPhase2.Hide();
                pnlPhase3.Hide();
            }
            else if(phaseCount == 2)
            {
                pnlPhase1.Show();
                pnlPhase2.Show();
                pnlPhase3.Hide();
            }
            else if(phaseCount == 3)
            {
                pnlPhase1.Show();
                pnlPhase2.Show();
                pnlPhase3.Show();
            }
            else if(phaseCount == 0)
            {
                pnlPhase1.Hide();
                pnlPhase2.Hide();
                pnlPhase3.Hide();
            }
            //call the fillDataGrid method to populate the dataGridviews based on the phase count and selected project
            FillDataGrid(phaseCount, selectedProject);


        }

        private void btnAddExpense1_Click(object sender, EventArgs e)
        {
            //instantiate the material form 
            frmAddExpense frmAddExpense = new frmAddExpense();
            //show addExpense form 
            frmAddExpense.ShowDialog();
        }

       private void FillDataGrid(int phaseCount, int selectedProject)
        {
            //set variables for the three possible phaseID values
            int phaseID1 = int.Parse((selectedProject.ToString() + "1"));
            int phaseID2 = int.Parse((selectedProject.ToString() + "2"));
            int phaseID3 = int.Parse((selectedProject.ToString() + "3"));
            //call GetSQLDataSource methods to populate the dataGrids
            if(phaseCount == 3)
            {
                GetSQLDataSource(phaseID1, dtgPhase1);
                GetSQLDataSource(phaseID2, dtgPhase2);
                GetSQLDataSource(phaseID3, dtgPhase3);
                
            
            }
            if(phaseCount==2)
            {
                GetSQLDataSource(phaseID1, dtgPhase1);
                GetSQLDataSource(phaseID2, dtgPhase2);
            }
            if (phaseCount == 1)
            {
                GetSQLDataSource(phaseID1, dtgPhase1);
            }
        }

        private int GetPhaseCount(int selectedProject)
        {
            //use this method to get the count of phases in a specific project by calling get phase count query
            int phaseCount = (int)project_phaseTableAdapter.GetPhaseCount(selectedProject);
            return phaseCount;
        }

        private void GetSQLDataSource(int phaseID, DataGridView insertedDataGrid)
        {
            //sql connection to get data for the datagrids that display in the panels
            //connection to sql 
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\infinitrack.mdf;Integrated Security=True;Connect Timeout=30";
            //instantiate a new sql connection
            using (SqlConnection connection = new SqlConnection(connectionString))
                // using this sql connection create a new command to be executed
            using (SqlCommand cmd = connection.CreateCommand())
            {
                //this the code to be executed in the sqlCommand prompt
                connection.Open();
                cmd.CommandText = "select a.Activity_ID, Phase_ID,Budget_Hours, Budget_Cost, Start_Date, End_Date, Complete_Ind, material_cost.cost as Actual_Cost, labor_hours.actual_hours as Actual_Hours " +
                "From project_activity a " +
                "left join (" +
                "select activity_id, sum(cost) as cost " +
                "from(" +
                "select activity_id, activity_material.material_id,activity_material.quantity * material.price as cost " +
                "from activity_material " +
                "left join material " +
                "on activity_material.material_id = material.Material_ID) as a " +
                "group by activity_id) as material_cost " +
                "on a.activity_id = material_cost.activity_id " +
                "left join (select activity_id, sum(clocked_hours) as actual_hours " +
                "from " +
                "(" +
                "select *, DATEDIFF(HOUR, Clock_IN, Clock_Out) as clocked_hours " +
                "from activity_labor) as a " +
                "group by Activity_ID " +
                ") as labor_hours " +
                "on a.Activity_ID = labor_hours.Activity_ID " +
                "where phase_ID = " + phaseID;
                //instantiate a  new sqlAdapter
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                //instantiate a new data set
                DataSet ds = new DataSet();
                //fill data set with adapter data
                adap.Fill(ds);
                //set ds as the source of passed datagrid
                insertedDataGrid.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private int GetProjectID(string selectedProjectName)
        {
            //call this method to get the project ID of a project based on its Name
            int projectID = (int)projectTableAdapter.ProjectIDbyNameQuery(selectedProjectName);
            return projectID;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //this method refreshes the data grid
            //get name of selectedProject
            string selectedProjectName = cmbProjectName.SelectedItem.ToString();
            //get id by calling GetProjectID
            int selectedProjectID = GetProjectID(selectedProjectName);
            //refresh panels by calling the ShowPanels method once again 
            ShowPanels(selectedProjectID);
        }

     
    }
}
