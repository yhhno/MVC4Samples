﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5Samples.Startup))]
namespace Mvc5Samples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
