﻿using BooksAPI;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace BooksAPI
{
    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureOAuth(app);
        }
    }
}