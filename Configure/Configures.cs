﻿using Microsoft.AspNetCore.Identity;
using UserLoginBE.Context;
using UserLoginBE.Entities.Models;

namespace UserLoginBE.Configures
{
    public static class Configures
    {
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<User, IdentityRole>(o =>
            {
                o.Password.RequireDigit = false;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequiredLength = 6;
                o.User.RequireUniqueEmail = false;
            })
            .AddEntityFrameworkStores<UserLoginContext>()
            .AddDefaultTokenProviders();
        }
    }
}
