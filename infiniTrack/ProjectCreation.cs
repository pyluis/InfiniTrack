/*Author: Team infiniTrack, Group 7
 *Description: This form lets the user create new project and update an existing project.
 * This form is limited to manager level access.
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
    public partial class frmProjectCreation : Form
    {
       
        public frmProjectCreation()
        {
            InitializeComponent();
        }
        //declare private variable access
        private string access;
        private int projectId;

        private void frmProjectCreation_Load(object sender, EventArgs e)
        {
            //get the employee access level
            access = Employee.GetAccess();
            if (access.ToUpper() == Employee.User())
            {
                //if access level is user, then navigate to access denied
                Navigation.Navigate(this, Navigation.AccessDenied());
            }
            else
            {
                projectTableAdapter.Fill(infinitrackDataSet.project);
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
                toolTipProject.SetToolTip(btnClose, "Close");
                toolTipProject.SetToolTip(btnMax, "Maximize/Restore");
                toolTipProject.SetToolTip(btnMin, "Minimize");
                toolTipProject.SetToolTip(btnHome, "Home");
                toolTipProject.SetToolTip(btnReport, "Report");
                toolTipProject.SetToolTip(btnProject, "Project");
                toolTipProject.SetToolTip(btnLogout, "Logout");
                toolTipProject.SetToolTip(btnClock, "Clock in/out");
                //declare and initialize the category values in an array
                string[] category = { "Tropical", "Modern", "Mixed", "Desert", "Commercial" };
                for(int i=0; i< category.Length; i++)
                {
                    cmbCategory.Items.Add(category[i]);
                }
                cmbCategory.SelectedIndex = 0;
                //load cutomer and team dropdowns using the methods.
                Load_Customer();
                Load_Team();
                //remove the initial selection of datagridview.
                projectDataGridView.Rows[0].Cells[0].Selected = false;
            }
        }

        //Load customer dropdown
        private void Load_Customer()
        {
            DataTable dt = new DataTable();
            //get customer id's from database and store in datatable
            dt = customerTableAdapter.GetDataByCustomerId();
            //loop through the datatable and add values to the customer combobox.
            for(int i=0; i< dt.Rows.Count; i++)
            {
                cmbCustomer.Items.Add(dt.Rows[i]["Customer_ID"].ToString());
            }
            //select the item at the zero index
            cmbCustomer.SelectedIndex = 0;
        }
        //Load team dropdown
        private void Load_Team()
        {
            DataTable dt = new DataTable();
            //get team id's from database and store in datatable
            dt = project_teamTableAdapter.GetDataByTeamID();
            //loop through the datatable and add values to the team combobox.
            for (int i=0; i< dt.Rows.Count; i++)
            {
                cmbTeam.Items.Add(dt.Rows[i]["Team_ID"].ToString());
            }
            //select the item at the zero index
            cmbTeam.SelectedIndex = 0;
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
            else if (sender == btnClock)
            {
                //navigate to employee clock
                Navigation.Navigate(this, Navigation.Clock());
            }
            else if (sender == btnHome)
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
                if (lstMenuDescription.SelectedItem.ToString().ToUpper() != Navigation.ProjectCreation())
                {
                    Navigation.Navigate(this, lstMenuDescription.SelectedItem.ToString());
                }
            }
            //hide the sliding menu
            pnlMenuDescription.Hide();
            //clear the sliding menu items.
            lstMenuDescription.Items.Clear();
        }

        private void frmProjectCreation_Click(object sender, EventArgs e)
        {
            //on a click on the form area, hide the sliding menu and clear the sliding menu items.
            pnlMenuDescription.Hide();
            lstMenuDescription.Items.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //check if the user has provided all input values, if not then display message.
            if (txtProjectname.Text.Trim().Length == 0 ||
                txtCity.Text.Trim().Length == 0 ||
                txtStreet.Text.Trim().Length == 0 ||
                txtZip.Text.Trim().Length == 0 ||
                txtCost.Text.Trim().Length == 0 ||
                txtHours.Text.Trim().Length == 0)
                MessageBox.Show("Please fill out all fields", "infiniTrack", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                //check if the delivery date is greater than start date, if not display error message
                if (dtpDeliverydate.Value <= dtpStartdate.Value)
                    MessageBox.Show("Delivery date cannot be before the Start date", "infiniTrack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    //store all the input fields in variables
                    string projectName = txtProjectname.Text;
                    string customerID = cmbCustomer.SelectedItem.ToString();
                    int team = int.Parse(cmbTeam.SelectedItem.ToString());
                    string category = cmbCategory.SelectedItem.ToString();
                    string street = txtStreet.Text;
                    string city = txtCity.Text;
                    int zip = int.Parse(txtZip.Text);
                    string startDate = dtpStartdate.Value.ToShortDateString();
                    string deliveryDate = dtpDeliverydate.Value.ToShortDateString();
                    int hour = int.Parse(txtHours.Text);
                    int cost = int.Parse(txtCost.Text);
                    //if this is a create operation, then btnsubmit text is Submit
                    if (btnSubmit.Text == "&Submit")
                    {
                        //insert values in the database
                        projectTableAdapter.InsertNewProject(projectName, int.Parse(customerID), category, street, city, zip, startDate, deliveryDate, hour, cost, team);
                        //display success message
                        MessageBox.Show("Project created successfully", "infiniTrack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //if btnSubmit text is Update then update operation has to take place.
                    else if(btnSubmit.Text == "Update")
                    {
                        int project_ID = 
                        //update values in database
                        projectTableAdapter.UpdateFromProjectCreation(startDate, deliveryDate, hour, cost, projectId);
                        //display success message
                        MessageBox.Show("Project updated successfully", "infiniTrack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //enable and show all the controls which were disabled and hidden for update and change btnSubmit text to Submit
                        txtProjectname.Enabled = true;
                        cmbCategory.Enabled = true;
                        cmbCustomer.Enabled = true;
                        cmbTeam.Enabled = true;
                        txtStreet.Enabled = true;
                        txtZip.Enabled = true;
                        txtCity.Enabled = true;
                        btnSubmit.Text = "&Submit";
                        btnUpdate.Show();
                        
                    }
                    //refill the new data in the datatable after insertion or updation
                    projectTableAdapter.Fill(infinitrackDataSet.project);
                    //remove the initial selection of the datagridview
                    projectDataGridView.Rows[0].Selected = false;
                    //clear all the input fields
                    txtProjectname.Text = "";
                    txtStreet.Text = "";
                    txtCity.Text = "";
                    txtZip.Text = "";
                    cmbCustomer.SelectedIndex = 0;
                    cmbTeam.SelectedIndex = 0;
                    cmbCategory.SelectedIndex = 0;
                    txtHours.Text = "";
                    txtCost.Text = "";
                    txtProjectname.Focus();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear the input fields and enable all controls to default view
            txtProjectname.Text = "";
            cmbCustomer.SelectedIndex = 0;
            cmbTeam.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            txtStreet.Text = "";
            txtCity.Text = "";
            txtZip.Text = "";
            dtpStartdate.Value = DateTime.Today;
            dtpDeliverydate.Value = DateTime.Today;
            txtProjectname.Focus();
            txtCost.Text = "";
            txtHours.Text = "";
            txtProjectname.Enabled = true;
            cmbCategory.Enabled = true;
            cmbCustomer.Enabled = true;
            cmbTeam.Enabled = true;
            txtStreet.Enabled = true;
            txtZip.Enabled = true;
            txtCity.Enabled = true;
            btnSubmit.Text = "&Submit";
            btnUpdate.Show();
            projectDataGridView.Rows[0].Selected = false;
        }

        private void CancelKeys(object sender, KeyPressEventArgs e)
        {// allow the text box to accept only number and control.
            if (!(char.IsNumber(e.KeyChar)) & !(char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void CancelKeysCity(object sender, KeyPressEventArgs e)
        {
            //allow only letters, space and controlkeys.
            if(!char.IsControl(e.KeyChar) & !char.IsLetter(e.KeyChar) & e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void projectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infinitrackDataSet);

        }
 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //check if any cell or row is selected in the data gridview, if not display error message
            if (!projectDataGridView.CurrentCell.Selected)
            {
                MessageBox.Show("Please select a project id from the grid to update.", "infiniTrack", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                //get the rowindex of the current selected cell
                int rowIndex = projectDataGridView.CurrentCell.RowIndex;
                //set the selection for the entire row with the same rowindex
                projectDataGridView.Rows[rowIndex].Selected = true;
                //store all the values of the selected row into the visual controls
                projectId = int.Parse(projectDataGridView.Rows[rowIndex].Cells[0].Value.ToString());
                txtProjectname.Text = projectDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                cmbCustomer.SelectedItem = projectDataGridView.Rows[rowIndex].Cells[2].Value;
                cmbCategory.SelectedItem = projectDataGridView.Rows[rowIndex].Cells[3].Value;
                txtStreet.Text = projectDataGridView.Rows[rowIndex].Cells[4].Value.ToString();
                txtCity.Text = projectDataGridView.Rows[rowIndex].Cells[5].Value.ToString();
                txtZip.Text = projectDataGridView.Rows[rowIndex].Cells[6].Value.ToString();
                dtpStartdate.Value = DateTime.Parse(projectDataGridView.Rows[rowIndex].Cells[7].Value.ToString());
                dtpDeliverydate.Value = DateTime.Parse(projectDataGridView.Rows[rowIndex].Cells[8].Value.ToString());
                txtHours.Text = projectDataGridView.Rows[rowIndex].Cells[9].Value.ToString();
                txtCost.Text = projectDataGridView.Rows[rowIndex].Cells[10].Value.ToString();
                //initialize a string to write the SQL query
                string selectQuery = "select team_id from project where Project_ID = " + projectId;
                //get the connectionString to the database using the configuration manager
                string connectionString = ConfigurationManager.ConnectionStrings["infiniTrack.Properties.Settings.infinitrackConnectionString"].ConnectionString;
                //create a SQLdataadapter object and provide the SQL query and connectionString as parameters
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connectionString);
                //create a SQLcommandbuilder object and provide the dataadapter as a parameter.
                SqlCommandBuilder sqlCommand = new SqlCommandBuilder(dataAdapter);
                DataTable dt = new DataTable();
                //use the fill method of SQLdataadapter class to fill data into the datatable.
                dataAdapter.Fill(dt);
                //disable visual componenets that are not to updated or edited
                cmbTeam.SelectedItem = dt.Rows[0]["team_id"];
                txtProjectname.Enabled = false;
                cmbCategory.Enabled = false;
                cmbCustomer.Enabled = false;
                cmbTeam.Enabled = false;
                txtStreet.Enabled = false;
                txtZip.Enabled = false;
                txtCity.Enabled = false;
                btnSubmit.Text = "Update";
                btnUpdate.Hide();
            }
        }
    }
}


