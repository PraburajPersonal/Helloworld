﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HelloWorld.Startup))]

namespace HelloWorld
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            //This displays a welcome page. 
            app.UseWelcomePage();
        }
    }
}