﻿using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using WebPolyclinic.Models;

namespace WebPolyclinic.Infrastructure
{
    public class AppIdentityDbContext : IdentityDbContext<User>
    {
        public AppIdentityDbContext() : base("name=ConnectionModel") { }

        static AppIdentityDbContext()
        {
            Database.SetInitializer<AppIdentityDbContext>(new IdentityDbInit());
        }

        public static AppIdentityDbContext Create()
        {
            return new AppIdentityDbContext();
        }
    }

    public class IdentityDbInit : DropCreateDatabaseIfModelChanges<AppIdentityDbContext>
    {
        protected override void Seed(AppIdentityDbContext context)
        {
            PerformInitialSetup(context);
            base.Seed(context);
        }
        public void PerformInitialSetup(AppIdentityDbContext context)
        {
            // настройки конфигурации контекста будут указываться здесь
        }
    }
}