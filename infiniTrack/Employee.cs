/*Author: Team infiniTrack, Group 7
 *Description: The page corresponds to the start of the application. It displays the app logo from about 3 seconds.
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
    class Employee
    {
        private static string access;
        private const string ACCESS_MANAGER = "MANAGER";
        private const string ACCESS_USER = "USER";
        private static string employeeID;

        internal static string GetAccess()
        {
            return access;
        }

        internal static string GetEmployeeID()
        {
            return employeeID;
        }

        internal static void SetAccess(string accessName)
        {
            access = accessName;
        }

        internal static void SetEmployeeID(string employeeId)
        {
            employeeID = employeeId;
        }

        internal static string Manager()
        {
            return ACCESS_MANAGER;
        }

        internal static string User()
        {
            return ACCESS_USER;
        }
    }
}
