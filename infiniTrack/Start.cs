/*Author: Team infiniTrack, Group 7
 *Description: The form corresponds to the start of the application. It displays the app logo from about 3 seconds.
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
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
            //set the opacity of the form to 0.
            this.Opacity = 0;
            //Increase the opacity giving a fade in effect.
            Navigation.FadeIn(this, 50);
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            //get the file path for all the icons and pictures involved on the form
            string iconsDirectory = Directory.GetCurrentDirectory() + "\\icons\\";
            //load all the icons and images on form load
            picLogo.ImageLocation = iconsDirectory + "start.png";
            //set the icon file for the application
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            //start the timer
            tmrStart.Enabled = true;
        }

        private void tmrStart_Tick(object sender, EventArgs e)
        {
            //when timer time completed show the login form
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
            //disable the timer
            tmrStart.Enabled = false;
        }
    }
}
