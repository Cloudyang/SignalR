﻿using System;
using System.Web.Routing;

namespace Microsoft.AspNet.SignalR.LoadTestHarness
{
    public class Global : System.Web.HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            GlobalHost.Configuration.KeepAlive = 3;

            RouteTable.Routes.MapConnection<TestConnection>("TestConnection", "TestConnection");
            RouteTable.Routes.MapHubs();

            Dashboard.Init();
        }
    }
}
