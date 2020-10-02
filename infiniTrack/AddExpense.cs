/*Author: Team infiniTrack, Group 7
 *Description: The form lets the user add expense to a project.
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
using System.Configuration;

namespace infiniTrack
{
    public partial class frmAddExpense : Form
    {
        //constants
        const string INFINITRACK = "Infinitrack";
        public frmAddExpense()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("Please enter a quantity for materials!", INFINITRACK, MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                //set variables
                int activityID = int.Parse(cmbActivityID.SelectedItem.ToString());
                int quantity = int.Parse(txtQuantity.Text.ToString());
                DateTime date = dtpDate.Value;
                int materialID = (int)materialTableAdapter.MaterialIDQuery(cmbMaterial.SelectedItem.ToString());
                //ask whether the user is sure they want to insert record
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Are you sure you would like to add a new expense to Activity " + activityID.ToString() + "?",
                     INFINITRACK,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    //call insert query
                    activity_materialTableAdapter.Insert(activityID, materialID, quantity, date);
                    //ask user if they would like to add another record
                    dialogResult = MessageBox.Show("Would you like to add another record?",
                         INFINITRACK,
                         MessageBoxButtons.YesNo);
                    //if user says yes reset cmbProjectName back to index 0 else close this form 
                    if(dialogResult == DialogResult.Yes)
                    {
                        cmbProjectName.SelectedIndex = 0;
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
           
        }

        private void frmAddExpense_Load(object sender, EventArgs e)
        {
            //hide inputs
            txtQuantity.Hide();
            cmbActivityID.Hide();
            cmbMaterial.Hide();
            dtpDate.Hide();
            btnAdd.Hide();
            // TODO: This line of code loads data into the 'infinitrackDataSet.material' table. You can move, or remove it, as needed.
            this.materialTableAdapter.Fill(this.infinitrackDataSet.material);
            // TODO: This line of code loads data into the 'infinitrackDataSet.activity_material' table. You can move, or remove it, as needed.
            this.activity_materialTableAdapter.Fill(this.infinitrackDataSet.activity_material);
            //fill comboBoxes
            cmbProjectName.Items.Add("--Select Project--");
            cmbProjectName.SelectedIndex = 0;
            //instantiate a new data table object
            DataTable dt = new DataTable();
            //set data source for dt Table 
            dt = projectTableAdapter1.GetDataByProjectsGreaterThanOneActvity();
            //Loop through dt and assign values to items in the projectName combo box
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbProjectName.Items.Add(dt.Rows[i]["Project_Name"].ToString());
            }
            //add generic item to material comboBox
            cmbMaterial.Items.Add("--Select Material--");
            cmbMaterial.SelectedItem = 0;
            //create new instance of a data set with variable name ds
            DataSet ds = new DataSet();
            //set a connection string variable
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\infinitrack.mdf;Integrated Security=True;Connect Timeout=30";
            //create a new sql connection
            using (SqlConnection connection = new SqlConnection(connectionString))
                //create new sqlcommand
            using (SqlCommand cmd = connection.CreateCommand())
            {
                //open the connection
                connection.Open();
                //add query to commmand prompt
                cmd.CommandText = "Select name from material";
                //create new instance for as sqlDataAdapter
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
               //fill data set with adap
                adap.Fill(ds);                
            }
            //loop through data set and then add values to  cmbMaterial
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbMaterial.Items.Add(ds.Tables[0].Rows[i]["Name"].ToString());
            }


        }

        private void activity_materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.activity_materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infinitrackDataSet);

        }

        private void SelectedProjectChanged(object sender, EventArgs e)
        {
            //clear and hide all inputs
            cmbActivityID.Items.Clear();
            cmbActivityID.Hide();
            cmbMaterial.Hide();
            txtQuantity.Text = string.Empty;
            txtQuantity.Hide();
            //add Activities based on selected project
            if (cmbProjectName.SelectedIndex !=0 )
            {
                //show cmbActivity
                cmbActivityID.Show();
                //set variable for projectName
                string projectName = cmbProjectName.SelectedItem.ToString();
                //add a generic item to the activity comboBox
                cmbActivityID.Items.Add("--Select Activity--");
                cmbActivityID.SelectedIndex = 0;
                //instantiate a new data table object
                DataTable dt = new DataTable();
                //set data source for dt by calling GetDataByProjectName
                dt = project_activityTableAdapter1.GetDataByProjectName(projectName);
                for(int i = 0; i <dt.Rows.Count; i++)
                {
                    cmbActivityID.Items.Add(dt.Rows[i]["Activity_ID"].ToString());
                }
            }
        }

        private void cmbActivityID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reset quantity
            txtQuantity.Text = string.Empty;
            if(cmbActivityID.SelectedIndex != 0)
            {
                //if cmbActivity index not equal to zero show cmbMaterialText
                cmbMaterial.Show();
            }
            else
            {
                //hide cmbMaterial input
                cmbMaterial.Hide();
            }
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reset text in quantity to null
            txtQuantity.Text = string.Empty;
            //if cmbMaterial index not equal zero display text box for quantity
            if(cmbMaterial.SelectedIndex !=0)
            {
                //show txtQuantity text box
                txtQuantity.Show();
            }
            else
            {
                //hide txtQuantity text box
                txtQuantity.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if(txtQuantity.Text.Trim() != "" )
            {
                //if txtQuantity text is not equal to empty string show the dtpDate and the btnAdd button
                dtpDate.Show();
                btnAdd.Show();
            }
            else
            {
                //if empty continue to hide the dtpDate and btnAdd
                dtpDate.Hide();
                btnAdd.Hide();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if key is not a number or number
            if (!(char.IsNumber(e.KeyChar)) &
                !(char.IsControl(e.KeyChar)))
                //cancel the key
                e.Handled = true;
        }
    }
}
