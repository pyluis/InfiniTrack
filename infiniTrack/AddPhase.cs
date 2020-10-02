/*Author: Team infiniTrack, Group 7
 *Description: The form lets the user add phase to a project.
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

namespace infiniTrack
{
    public partial class frmAddPhase : Form
    {
        public frmAddPhase()
        {
            InitializeComponent();
        }
        //set variable and constant
        string selectedProject;
        const string INFINITRACK = "InfiniTrack";
        private void frmAddPhase_Load(object sender, EventArgs e)
        {
            //Fill combo box items for project select
            cmbProjectName.Items.Add("--Select a Project--");
            cmbProjectName.SelectedIndex = 0;
            //instantiate a new data table object
            DataTable dt = new DataTable();
            //set data source for dt DataTable
            dt = projectTableAdapter1.GetDataByProjectName();
            //loop through dt and add values to combo box
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbProjectName.Items.Add(dt.Rows[i]["Project_Name"].ToString());
            }
            //
            string[] phaseNameArray = new string[] { "Planning", "Implementation", "Closing" };
            //traverse through the array fill phase name 
            foreach(string i in phaseNameArray)
            {
                cmbPhaseName.Items.Add(i.ToString());
            }
            //hide this control until cmbProject is changed
            cmbPhaseName.Hide();
            btnAdd.Hide();
           
        }
        
        private void cmbProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPhaseName.SelectedIndex = -1;
           //if cmbProject index not equal to 0 show the cmbPhaseName combo box else continue to hide combo box
            if(cmbProjectName.SelectedIndex > 0)
            {
                cmbPhaseName.Show();
                //add project to variable
                selectedProject = cmbProjectName.SelectedItem.ToString();
            }
            else
            {
                //if cmbProject Name index less than or equal to 0 than continue to hid the cmbPhase Name
                cmbPhaseName.Hide();
            }
        }

        private void cmbPhaseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if cmbPhaseName index is not equal to or less than zero show the add button, else continue to hide the add button
            if(cmbPhaseName.SelectedIndex < 0)
            {
                //hide btnAdd from the user
                btnAdd.Hide();
               
            }
            else
            {//show the btnAdd 
                btnAdd.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get inputs and inser them into the variables below
            int projectID = GetProjectID(selectedProject);
            string phaseName = cmbPhaseName.SelectedItem.ToString();
            int phaseID = GetPhaseID(projectID, phaseName);
            //get the count of the phaseID in the database by cally CountByPhaseIDquerty
            int phaseCheckCount = (int)project_phaseTableAdapter1.CountByPhaseIDQuery(phaseID);
            //set phaseNumber variable to zero
            int phaseNumber = 0;
            //change phaseNumber based on the phaseName user changes
            if(phaseName == "Planning")
            {
                phaseNumber= 1;
            }
            if(phaseName=="Implementation")
            {
                phaseNumber = 2;
            }
            if(phaseName =="closing")
            {
                phaseNumber = 3;
            }

            //check if phase already exists in the database by calling the CountByPhaseID query that will return the count of the phaseID in the database
            if (phaseCheckCount > 0)
            {
                //if phaseCheckCount returns greater than 1 return an erros message
                MessageBox.Show("Phase already Exists", INFINITRACK, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //if count = 0 than ask the user whethery they would like to insert the record into the database
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Are you sure you would like to add a new phase to project " + selectedProject + "?",
                    INFINITRACK,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                //if user answers yes than continue to insert the phase into the database
                if(dialogResult==DialogResult.Yes)
                {
                    //insert phase by calling the Insert query and fill with input variables
                    project_phaseTableAdapter1.Insert(phaseID,projectID,phaseName,phaseNumber);
                    //ask the user whether they would like to add a new record
                    dialogResult = MessageBox.Show("Would you like to add another record?", INFINITRACK, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //if yes reset the cmbProjectName index to zero
                    if (dialogResult==DialogResult.Yes)
                    {
                        cmbProjectName.SelectedIndex = 0;
                        
                    }
                    else
                    {
                        //if no than close this form 
                        this.Close();
                    }
                }
            }
        }

        private int GetProjectID(string projectName)
        {
            //call this method to get the ProjectID based on the name of the project
            int projectID = (int)projectTableAdapter1.ProjectIDbyNameQuery(projectName);
            return projectID;
        }
        private int GetPhaseID(int project, string phaseName)
        {
            //call this method to get the phaseID based on the projectID, and phaseName
            int phaseID = 0;
            if (phaseName == "Planning")
                phaseID = int.Parse(project.ToString() + "1");
            if (phaseName == "Implementation")
                phaseID = int.Parse(project.ToString() + "2");
            if (phaseName == "Closing")
                phaseID = int.Parse(project.ToString() + "3");
            //return the phaseID
            return phaseID;
        }

        private void project_phaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.project_phaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infinitrackDataSet);

        }
    }
}
