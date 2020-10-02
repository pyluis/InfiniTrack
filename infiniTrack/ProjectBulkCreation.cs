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
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;

namespace infiniTrack
{
    public partial class frmProjectBulkCreation : Form
    {
        public frmProjectBulkCreation()
        {
            InitializeComponent();
        }
        //initialize private variable access
        private string access;

        private void frmProjectBulkCreation_Load(object sender, EventArgs e)
        {
            //get the employee access level
            access = Employee.GetAccess();
            if (access == Employee.User())
            {
                //if access level is user then navigate to access denied.
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
                toolTipProjectBulk.SetToolTip(btnClose, "Close");
                toolTipProjectBulk.SetToolTip(btnMax, "Maximize/Restore");
                toolTipProjectBulk.SetToolTip(btnMin, "Minimize");
                toolTipProjectBulk.SetToolTip(btnHome, "Home");
                toolTipProjectBulk.SetToolTip(btnReport, "Report");
                toolTipProjectBulk.SetToolTip(btnProject, "Project");
                toolTipProjectBulk.SetToolTip(btnLogout, "Logout");
                toolTipProjectBulk.SetToolTip(btnClock, "Clock in/out");
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
                //navigate to employee clock
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
                //if the selection is not the current form, navigate to the required form
                if (lstMenuDescription.SelectedItem.ToString().ToUpper() != Navigation.ProjectBulkCreation())
                {
                    Navigation.Navigate(this, lstMenuDescription.SelectedItem.ToString());
                }
            }
            //hide the sliding menu
            pnlMenuDescription.Hide();
            //clear the sliding menu items.
            lstMenuDescription.Items.Clear();
        }

        private void frmProjectBulkCreation_Click(object sender, EventArgs e)
        {
            //on a click on the form area, hide the sliding menu and clear the sliding menu items.
            pnlMenuDescription.Hide();
            lstMenuDescription.Items.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear the filename
            lblFileName.Text = "";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //check if the user pressed the cancel key on open file dialog box
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
                //do nothing
            }
            else
            {
                //store the full path in a variable
                string pathName = openFileDialog.FileName;
                //store the filename in a variable
                string fileName = pathName.Substring(pathName.LastIndexOf('\\') + 1);
                //display the filename
                lblFileName.Text = fileName;
            }
        }

        private void llblTemplate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //check if the user pressed the cancel key on save file dialog box
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
                //do nothing
            }
            else
            {
                //check if the user has selected a file
                if (saveFileDialog.FileName == "")
                {
                    MessageBox.Show("Please provide the filename", "infiniTrack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //store the path in a variable
                    string pathName = saveFileDialog.FileName;
                    //initaite a stream writer object, providing the filepath, if the file not not exist then create one.
                    using (StreamWriter outFile = new StreamWriter(new FileStream(pathName, FileMode.Create), Encoding.UTF8))
                    {
                        //initiate a string builder
                        var sb = new StringBuilder();
                        //store the column headers in an array
                        string[] headers = { "Project_Name", "Customer_ID", "Category", "Project_Street", "Project_City",
                            "Project_ZIP", "Start_Date", "Expected_Delivery_Date", "Hour_Budget", "Cost_Budget", "team_id"};
                        //append the columns to the string builder with comma seperated values
                        sb.AppendLine(string.Join(",", headers));
                        //write the string builder to the file
                        outFile.Write(sb.ToString());
                        //close the file
                        outFile.Close();
                    }
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //check if a file is selected
            if(lblFileName.Text != "")
            {
                DataTable dt = new DataTable();
                //create a stream reader object
                StreamReader inFile = new StreamReader(openFileDialog.FileName);
                //initialize i as a count
                int i = 0;
                //set the total number of fields required in the template
                const int FIELD_COUNT = 11;
                while (!inFile.EndOfStream)
                {
                    //read the first line
                    string line = inFile.ReadLine();
                    //split the line into an array on '\t'
                    string[] lineArray = line.Split('\t').ToArray();
                    //check if all the columns are present in the template
                    if (lineArray.Length == FIELD_COUNT)
                    {
                        //if this is the column line
                        if (i == 0)
                        {
                            //add fields to datatable
                            for (int j = 0; j < lineArray.Length; j++)
                            {
                                dt.Columns.Add(lineArray[j]);
                                i++;
                            }
                        }
                        else
                        {
                            //set check for empty fields
                            bool empty = false;
                            for(int l = 0; l< lineArray.Length; l++)
                            {
                                //if some field is empty, then break and set empty check to true.
                                if(lineArray[l] == "")
                                {
                                    empty = true;
                                    dt.Rows.Clear();
                                    break;
                                }
                            }
                            if (empty)
                            {
                                //if any field is empty then display message
                                MessageBox.Show("Please enter all the fields as given in the template.", "infiniTrack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                            //check if the delivery date is more then start date, else display message
                            if(DateTime.Parse(lineArray[7]) <= DateTime.Parse(lineArray[6]))
                            {
                                MessageBox.Show("Delivery date cannot be less than the Start date", "infiniTrack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dt.Rows.Clear();
                                break;
                            }
                            else
                            { 
                                //add the new rows to the datatable.
                                DataRow dr = dt.NewRow();
                                for (int k = 0; k < lineArray.Length; k++)
                                {
                                    dr[k] = lineArray[k].ToString();
                                }
                                dt.Rows.Add(dr);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter all the fields as given in the template.", "infiniTrack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dt.Rows.Clear();
                    }
                }
                //close the file
                inFile.Close();
                //check if the datatable has rows
                if(dt.Rows.Count > 0)
                {
                    for(int rowCount = 0; rowCount < dt.Rows.Count; rowCount++)
                    {
                        //loop theough the datatable and  inseert
                        projectTableAdapter.InsertNewProject(dt.Rows[rowCount]["Project_Name"].ToString(),
                            int.Parse(dt.Rows[rowCount]["Customer_ID"].ToString()),
                            dt.Rows[rowCount]["Category"].ToString(),
                            dt.Rows[rowCount]["Project_Street"].ToString(),
                            dt.Rows[rowCount]["Project_City"].ToString(),
                            int.Parse(dt.Rows[rowCount]["Project_Zip"].ToString()),
                            dt.Rows[rowCount]["Start_Date"].ToString(),
                            dt.Rows[rowCount]["Expected_Delivery_Date"].ToString(),
                            int.Parse(dt.Rows[rowCount]["Hour_Budget"].ToString()),
                            decimal.Parse(dt.Rows[rowCount]["Cost_Budget"].ToString()),
                            int.Parse(dt.Rows[rowCount]["team_id"].ToString()));
                    }
                    //display suucess message
                    MessageBox.Show("New project(s) created successfully.", "infiniTrack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //reload the datagridview
                    projectTableAdapter.Fill(infinitrackDataSet.project);
                }
            }
            else
            {
                MessageBox.Show("Please select a file to upload.", "infiniTrack", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void projectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infinitrackDataSet);

        }
    }
}
