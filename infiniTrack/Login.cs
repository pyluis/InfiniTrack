/*Author: Team infiniTrack, Group 7
 *Description: This is the login form which authenticates the users of the application.
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //get the file path for all the icons and pictures involved on the form
            string iconsDirectory = Directory.GetCurrentDirectory() + "\\icons\\";
            //load all the icons and images on form load
            picLogo.ImageLocation = iconsDirectory + "start.png";
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            picLine.ImageLocation = iconsDirectory + "line.png";
            btnClose.Image = Image.FromFile(iconsDirectory + "close.png");
            tooltipLogin.SetToolTip(btnClose, "Close");
            picError.ImageLocation = iconsDirectory + "error.png";
            //keep the error panel hidden
            pnlError.Hide();
        }

        //closes the application
        private void btnClose_Click(object sender, EventArgs e)
        {
            TitleBar.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //check if the user has provided all the input fields, if not set error.
            if (txtUserName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                if (txtUserName.Text.Trim() == "")
                {
                    errLogin.SetError(txtUserName, "Cannot be empty");
                }
                if (txtPassword.Text.Trim() == "")
                {
                    errLogin.SetError(txtPassword, "Cannot be empty");
                }
            }
            else
            {
                //if user has provided both fields
                DataTable dt = new DataTable();

                //Check from the database if the username and passeord exist
                dt = infinitrack_userTableAdapter.GetUser(txtUserName.Text.Trim(), txtPassword.Text.Trim());

                //if exists get the access level and employee number and show user dashboard
                if (dt.Rows.Count == 1)
                {
                    Employee.SetAccess(dt.Rows[0]["Access_Level"].ToString().ToUpper());
                    Employee.SetEmployeeID(dt.Rows[0]["Employee_ID"].ToString().ToUpper());
                    this.Close();
                    frmUserDashboard userDashboard = new frmUserDashboard();
                    userDashboard.Show();
                }
                else
                {
                    //show error panel
                    pnlError.Show();
                }
            }
        }

        //Corresponds to the txtchange event of the txtPassword
        private void Clear_Error(object sender, EventArgs e)
        {
            //hide the error panel
            pnlError.Hide(); 
            //clear the error provider
            errLogin.Clear();           
        }
    }
}
