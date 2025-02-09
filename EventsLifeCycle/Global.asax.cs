using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace EventsLifeCycle
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // create application state variables
            Application["TotalApplications"] = 0;
            Application["TotalUserSessions"] = 0;
            // increment TotalApplications by 1
            Application["TotalApplications"] = (int)Application["TotalApplications"] + 1;
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            // Increment TotalUserSessions by 1
            Application["TotalUserSessions"] = (int)Application["TotalUserSessions"] + 1;
        }
        void Session_End(object sender, EventArgs e)
        {
            // Decrement TotalUserSessions by 1
            Application["TotalUserSessions"] = (int)Application["TotalUserSessions"] - 1;
        }
    }
}