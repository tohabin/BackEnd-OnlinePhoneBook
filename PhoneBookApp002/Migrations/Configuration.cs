namespace PhoneBookApp002.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PhoneBookApp002.Models.PhoneBookDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PhoneBookApp002.Models.PhoneBookDBContext context)
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

            context.People.AddOrUpdate(
              p => p.Id,
                new Person() { Id = 1, Name = "Toha", PhoneNo = "01913595121", Email = "bin.toha@yahoo.com", Address = "Mehedibag, Chittagong, Bangladesh", FbProfile = "https://www.facebook.com/tohabinislam", LinkdinProfile = "https://www.linkedin.com" },
                new Person() { Id = 2, Name = "Asif", PhoneNo = "01800000111", Email = "Asif.Example@yahoo.com", Address = "Chowkbazar, Chittagong, Bangladesh", FbProfile = "https://www.facebook.com", LinkdinProfile = "https://www.linkedin.com" },
                new Person() { Id = 3, Name = "Ruma", PhoneNo = "01944440111", Email = "Ruma.Example@yahoo.com", Address = "Chowkbazar, Chittagong, Bangladesh", FbProfile = "https://www.facebook.com", LinkdinProfile = "https://www.linkedin.com" },
                new Person() { Id = 4, Name = "Habib", PhoneNo = "01833300111", Email = "Habib.Example@yahoo.com", Address = "Chowkbazar, Chittagong, Bangladesh", FbProfile = "https://www.facebook.com", LinkdinProfile = "https://www.linkedin.com" },
                new Person() { Id = 5, Name = "Jahnara", PhoneNo = "01702220111", Email = "Jahanara.Example@yahoo.com", Address = "Chowkbazar, Chittagong, Bangladesh", FbProfile = "https://www.facebook.com", LinkdinProfile = "https://www.linkedin.com" }

);
        }
    }
}
