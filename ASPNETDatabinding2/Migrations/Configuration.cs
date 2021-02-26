namespace ASPNETDatabinding2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ASPNETDatabinding2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Models.ApplicationDbContext context)
        {
            context.Products.AddOrUpdate(
                new Models.Product() { Name = "Paper", Description = "A4" },
                new Models.Product() { Name = "Notebook", Description = "" },
                new Models.Product() { Name = "Pencil", Description = "Package of 12 pencils" }
                );
            context.SaveChanges();
        }
    }
}
