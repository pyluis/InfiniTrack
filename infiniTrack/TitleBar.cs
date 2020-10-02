/*Author: Team infiniTrack, Group 7
 *Description: This class provides methods involved with the title bar like close, minimize and maximize
 *Date: 12/4/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infiniTrack
{
    class TitleBar
    {
        //close the application
        internal static void Close()
        {
            Application.Exit();
        }

        //maximize or restore the application
        internal static void Maximize(Form form)
        {
            //if window state is in normal state then maximize
            if (form.WindowState == FormWindowState.Normal)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            //if window state is maximized then restore.
            else
            {
                form.WindowState = FormWindowState.Normal;
            }
        }
        //minimize the application
        internal static void Minimize(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }
    }
}
