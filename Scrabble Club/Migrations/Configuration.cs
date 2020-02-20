namespace Scrabble_Club.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Scrabble_Club.Models.Model>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Scrabble_Club.Models.Model";
        }

        protected override void Seed(Scrabble_Club.Models.Model context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
