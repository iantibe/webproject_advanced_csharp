namespace websitecsharp.domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<websitecsharp.domain.scorecontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(websitecsharp.domain.scorecontext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Person.AddOrUpdate(new entities.person
            {

                personID = Guid.Parse("3013d605-b417-41de-a848-5c0ac763b5ba"),
                firstName = "Benjamin",
                lastName = "Frederickson",
                dateCreated = new DateTime(2019, 2,11),
                email = "bfrederickson@dmacc.edu"

            });

            context.Person.AddOrUpdate(new entities.person
            {

                personID = Guid.Parse("8d75cf73-cb54-4c3b-9518-510a1a12a021"),
                firstName = "Jared",
                lastName = "Holliday",
                dateCreated = new DateTime(2019, 2, 11),
                email = "jrholliday@dmacc.edu"

            });

            context.Person.AddOrUpdate(new entities.person
            {

                personID = Guid.Parse("e4b62de3-d8ad-4439-b9da-b1e47956137a"),
                firstName = "Ian",
                lastName = "Tibe",
                dateCreated = new DateTime(2019, 2, 11),
                email = "imtibe@dmacc.edu"

            });

            context.HighScore.AddOrUpdate(new entities.scoredata
            {
                highScoreId = Guid.Parse("98e7a84f-1f5b-42d1-9edb-73eefb6b0b20"),
                personId = Guid.Parse("e4b62de3-d8ad-4439-b9da-b1e47956137a"),
                score = 5020,
                dateAttained = new DateTime(2019, 2, 11)


            });

            context.HighScore.AddOrUpdate(new entities.scoredata
            {
                highScoreId = Guid.Parse("21b799e0-cef5-448e-8b8a-5212998b29c9"),
                personId = Guid.Parse("e4b62de3-d8ad-4439-b9da-b1e47956137a"),
                score = 7852,
                dateAttained = new DateTime(2019, 2, 11)
                
            });

            context.HighScore.AddOrUpdate(new entities.scoredata
            {
                highScoreId = Guid.Parse("ea5c96d3-fd9d-46ab-8809-756a420623ce"),
                personId = Guid.Parse("e4b62de3-d8ad-4439-b9da-b1e47956137a"),
                score = 6845,
                dateAttained = new DateTime(2019, 2, 11)
                
            });

            context.HighScore.AddOrUpdate(new entities.scoredata
            {
                highScoreId = Guid.Parse("6447352c-ba62-4f6e-a6fd-d148cb9e5bdf"),
                personId = Guid.Parse("e4b62de3-d8ad-4439-b9da-b1e47956137a"),
                score = 2634,
                dateAttained = new DateTime(2019, 2, 11)
                
            });

            context.HighScore.AddOrUpdate(new entities.scoredata
            {
                highScoreId = Guid.Parse("418d64e7-41b2-4828-80d3-176d5978046a"),
                personId = Guid.Parse("e4b62de3-d8ad-4439-b9da-b1e47956137a"),
                score = 5000,
                dateAttained = new DateTime(2019, 2, 11)
                
            });

        }
    }
}
