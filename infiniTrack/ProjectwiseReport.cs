/*Author: Team infiniTrack, Group 7
 *Description: The form allows the user to display reports about project. To access the form the user needs a manager level access.
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
    public partial class frmProjectwiseReport : Form
    {
        private string access;

        public frmProjectwiseReport()
        {
            InitializeComponent();
        }

        private void frmProjectwiseReport_Load(object sender, EventArgs e)
        {
            //get the employee access level
            access = Employee.GetAccess();
            if(access.ToUpper() == Employee.User())
            {
                //if user level access then navigate to access denied page.
                Navigation.Navigate(this, Navigation.AccessDenied());
            }
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
            toolTipProjectwiseReport.SetToolTip(btnClose, "Close");
            toolTipProjectwiseReport.SetToolTip(btnMax, "Maximize/Restore");
            toolTipProjectwiseReport.SetToolTip(btnMin, "Minimize");
            toolTipProjectwiseReport.SetToolTip(btnHome, "Home");
            toolTipProjectwiseReport.SetToolTip(btnReport, "Report");
            toolTipProjectwiseReport.SetToolTip(btnProject, "Project");
            toolTipProjectwiseReport.SetToolTip(btnLogout, "Logout");
            toolTipProjectwiseReport.SetToolTip(btnClock, "Clock in/out");
            //hide the data gridview and export button
            btnExport.Hide();
            projectDataGridView.Hide();
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
                //if the selection is not the current form, then naviagate to required form.
                if (lstMenuDescription.SelectedItem.ToString().ToUpper() != Navigation.ProjectwiseReport())
                {
                    Navigation.Navigate(this, lstMenuDescription.SelectedItem.ToString());
                }
            }
            //hide the sliding menu
            pnlMenuDescription.Hide();
            //clear the sliding menu items.
            lstMenuDescription.Items.Clear();
        }

        private void frmProjectwiseReport_Click(object sender, EventArgs e)
        {
            //on a click on the form area, hide the sliding menu and clear the sliding menu items.
            pnlMenuDescription.Hide();
            lstMenuDescription.Items.Clear();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //check if the end date is not less than the start date, if not display messgae
            if (dtpStart.Value > dtpEnd.Value)
            {
                MessageBox.Show("Startdate cannot be greater than Enddate", "infiniTrack", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //show the datagrid view and export button
                projectDataGridView.Show();
                btnExport.Show();
                //set autogenerate column property of datagridview to true.
                projectDataGridView.AutoGenerateColumns = true;
                DataTable dt = new DataTable();
                //initialize a string to write the SQL query
                string selectQuery = "SELECT  Project_Name, Customer_Name, Category,p.Start_date, Expected_Delivery_Date, Completion_Ind, Completion_Date , COUNT(Employee_ID) as Resources_Allocated"+
                                     " FROM project p"+
                                     " inner join customer c on p.Customer_ID = c.Customer_ID"+
                                     " inner join team_employee te on te.Team_ID = p.Team_ID"+
                                     " WHERE p.Start_Date BETWEEN CAST('" + dtpStart.Value.ToString()+"' AS DATE) AND CAST('"+dtpEnd.Value.ToString() +"' AS DATE)"+
                                     " group by te.Team_ID, c.Customer_Name, p.Project_Name, p.Category, p.Expected_Delivery_Date, p.Completion_Ind, p.Completion_Date, p.Start_Date";
                //get the connectionString to the database using the configuration manager
                string connectionString = ConfigurationManager.ConnectionStrings["infiniTrack.Properties.Settings.infinitrackConnectionString"].ConnectionString;
                //create a SQLdataadapter object and provide the SQL query and connectionString as parameters
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connectionString);
                //create a SQLcommandbuilder object and provide the dataadapter as a parameter.
                SqlCommandBuilder sqlCommand = new SqlCommandBuilder(dataAdapter);
                //use the fill method of SQLdataadapter class to fill data into the datatable.
                dataAdapter.Fill(dt);
                //set the datasource for the datagridview to datatable.
                projectDataGridView.DataSource = dt;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //set the datetime picker to today's date and hide the datagridview and export button
            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Today;
            projectDataGridView.Hide();
            btnExport.Hide();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //check if the user pressed the cancel key on save dialog box
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                //Do nothing
                return;
            }
            else
            {
                //if no file is selected, display error message
                if (saveFileDialog.FileName == "")
                {
                    MessageBox.Show("Please provide the filename", "infiniTrack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //store the filepath in a variable
                    string pathName = saveFileDialog.FileName;
                    //initaite a stream writer object, providing the filepath, if the file not not exist then create one.
                    using (StreamWriter outFile = new StreamWriter(new FileStream(pathName, FileMode.Create), Encoding.UTF8))
                    {
                        //initiate a string builder
                        var sb = new StringBuilder();
                        //casting the datagrid column values to type datagridviewcolumn
                        var headers = projectDataGridView.Columns.Cast<DataGridViewColumn>();
                        //append the columns to the string builder with comma seperated values
                        sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

                        foreach (DataGridViewRow row in projectDataGridView.Rows)
                        {
                            //casting the datagrid cell values to type datagridviewcell
                            var cells = row.Cells.Cast<DataGridViewCell>();
                            //append the cell values to the string builder with comma seperated values
                            sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
                        }
                        //write the string builder to the file
                        outFile.Write(sb.ToString());
                        //close the file
                        outFile.Close();
                    }
                }
            }
        }
    }
}
