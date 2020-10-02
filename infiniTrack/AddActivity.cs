/*Author: Team infiniTrack, Group 7
 *Description: The form lets the user add activity to a project.
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
using System.Data.SqlClient;

namespace infiniTrack
{
    public partial class frmAddActivity : Form
    {
        public frmAddActivity()
        {
            InitializeComponent();
        }

        private void frmAddActivity_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'infinitrackDataSet.project_phase' table. You can move, or remove it, as needed.
            this.project_phaseTableAdapter.Fill(this.infinitrackDataSet.project_phase);
            // TODO: This line of code loads data into the 'infinitrackDataSet.material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.infinitrackDataSet.material);
            // TODO: This line of code loads data into the 'infinitrackDataSet.project_activity' table. You can move, or remove it, as needed.
            this.project_activityTableAdapter.Fill(this.infinitrackDataSet.project_activity);
            // TODO: This line of code loads data into the 'infinitrackDataSet.project' table. You can move, or remove it, as needed.
            this.projectTableAdapter.Fill(this.infinitrackDataSet.project);
            //Add first value to projectName comboBox
            cmbProjectName.Items.Add("--Select Project--");
            //set cmbProject.SelectedIndex to zero upon form load
            cmbProjectName.SelectedIndex = 0;
            //instantiate a new dataTable object with the variable dt
            DataTable dt = new DataTable();
            //add data to this new data table by calling GetDataByProjectPhaseCount query
            dt = projectTableAdapter.GetDataByProjectPhaseCount();
            //add dt values to cmbProjectName, by running a loop that get the project name in each row
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbProjectName.Items.Add(dt.Rows[i]["Project_Name"].ToString());
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //event handler to insert records to the database
            //first check for null values or incorrect values
            if((cmbProjectName.SelectedIndex== 0)|| //this is if the user left cmbProjectName in the "select project" option
                (cmbPhase.SelectedIndex == 0) || //this is if the user left cmbPhase in the "select phase" option
                (txtBudgetCost.Text.Trim() == "") ||
                (txtBudgetHour.Text.Trim() == ""))
            {
                //if true display an error message telling the user to revise their input
                MessageBox.Show("Invalid values entered. Please revised entered values!",
                    "InfiniTrack",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }            
            else           
            {
                //set variables for the dateTimePicker values
                DateTime startDateValue = dtpStartDate.Value;
                DateTime endDateValue = dtpEndDate.Value;
                //check if start date is later than end date
                if(endDateValue<startDateValue)
                {
                    //if true display and error message telling the user the error
                    MessageBox.Show("End Date cannot be earlier than the Start Date of the activity!",
                        "InfiniTrack",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                { 
                   //create new variable to store reponse to a check if the user really wants to add a new record
                DialogResult dialogResult = MessageBox.Show("Are you Sure you want to add new activity to Project " + cmbProjectName.SelectedItem.ToString() + //line continues
                 " Phase " + cmbPhase.SelectedItem.ToString() + "?",
                 "InfiniTrack",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
                //if the user says no do not insert the query
                if (dialogResult == DialogResult.No)
                {

                }
                //if yes the begin inserting a new record into the database
                else if (dialogResult == DialogResult.Yes)
                {
                    // set variables for the inputs
                    int phaseID = int.Parse(cmbPhase.SelectedItem.ToString());
                    int budgetCost = int.Parse(txtBudgetCost.Text);
                    int budgetHours = int.Parse(txtBudgetHour.Text);
                    string startDate = dtpStartDate.Value.ToShortDateString();
                    string endDate = dtpStartDate.Value.ToShortDateString();
                    int activityID = GetActivityID(phaseID);
                    //insert record into the db by calling the InsertQuery in the Project_activity table adapter
                    project_activityTableAdapter.InsertQuery(activityID, phaseID, budgetHours, budgetCost, startDate, endDate);
                        //ask user whether they will like to enter another record
                        dialogResult = MessageBox.Show("Would you like to add another record?",
                            "InfiniTrack",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                        if(dialogResult==DialogResult.Yes)
                        {
                            //reset free entry values to their original values
                            txtBudgetCost.Text = "";
                            txtBudgetHour.Text = "";
                            dtpStartDate.Value = DateTime.Now;
                            dtpEndDate.Value = DateTime.Now;                               
                        }
                        //if user says no than close this form
                        else if (dialogResult == DialogResult.No)
                        {
                            this.Close();
                            
                        }
                }
                }
            }


        }

        private void cmbProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear the existing items in cmbPhase
            cmbPhase.Items.Clear();
            //method to add phase_Id to combobox once user picks a value
            if (cmbProjectName.SelectedIndex == 0)
            {
                //if comboBox selected index equals zero do not add phases to the cmb
            }
            else
            {
                //set variable for projectName
                string selectProject = cmbProjectName.SelectedItem.ToString();
                //instantiate a new datatable object with the name dt
                DataTable dt = new DataTable();
                //set dt to the data pulled by calling the GetDataByProjectName quer
                dt = project_phaseTableAdapter.GetDataByProjectName(selectProject);
                //set first item in the cmbPhase to a generic value
                cmbPhase.Items.Add("--Select Phase--");
                //set cmbPhaseSelectedIndex to zero
                cmbPhase.SelectedIndex = 0;
                //loop through dt and add a phase for every row in the query
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cmbPhase.Items.Add(dt.Rows[i]["Phase_ID"].ToString());
                    }
                
            }

           
        }
        private int GetActivityID(int phaseID)
        {
            string lastActivity = project_activityTableAdapter.LastPhaseActvityQuery(phaseID).ToString();
            //get new activityID based on lastActivity in the the database associated with the selected phase,
            if ( lastActivity== "" )
            {
                int noActivity = int.Parse(phaseID.ToString() + "1");
                return noActivity;
            }
            else
            {//return new activity id by adding 1 to the last activity
                int newActivity= (int)project_activityTableAdapter.LastPhaseActvityQuery(phaseID)+1;
                return newActivity;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            //if key is not a number or number
            if (!(char.IsNumber(e.KeyChar))&
                !(char.IsControl(e.KeyChar)))
                //cancel the key
                e.Handled = true;
        }
    }
}
