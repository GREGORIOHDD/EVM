﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EVM.Backend.Startup))]
namespace EVM.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
