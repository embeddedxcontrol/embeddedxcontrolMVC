namespace embeddedxcontrol.Migrations
{
    using embeddedxcontrol.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<embeddedxcontrol.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(embeddedxcontrol.Models.ApplicationDbContext context)
        //public void Seed2(embeddedxcontrol.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            if(!context.Roles.Any())
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var adminRole = new IdentityRole
                {
                    Name = "Administrator"
                };
                var userRole = new IdentityRole
                {
                    Name = "User"
                };
                roleManager.Create(adminRole);
                roleManager.Create(userRole);
            }

            if(!context.Users.Any())
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new ApplicationUserManager(userStore);

                var user = new ApplicationUser
                {
                    Email = "jjkindseth@gmail.com",
                    UserName = "jjkindseth@gmail.com"
                };

                userManager.Create(user,"password");
                userManager.AddToRole(user.Id, "Administrator");
            }

            context.SaveChanges();
            base.Seed(context);

        }
    }
}
