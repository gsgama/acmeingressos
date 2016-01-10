namespace BackendAcmeIngressos.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BackendAcmeIngressos.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BackendAcmeIngressos.Models.BackendAcmeIngressosContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BackendAcmeIngressos.Models.BackendAcmeIngressosContext context)
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
            context.Events.AddOrUpdate(x => x.Id,
                new Event() { Id = 1, Name = "Show 1", StartDate = DateTime.Today, EndDate = DateTime.Today.AddDays(1) },
                new Event() { Id = 2, Name = "Show 2", StartDate = DateTime.Today, EndDate = DateTime.Today.AddDays(1) }
                );
        }
    }
}
