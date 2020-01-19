namespace FilmsCo.Migrations
{
    using FilmsCo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FilmsCo.Models.FilmsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FilmsCo.Models.FilmsDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Films.AddOrUpdate(
              p => p.Name,
              new  Film { Name = "����� 1", Description = "�������� 1", Year = "2018", Producer = "������", Owner = "�������" },
              new Film { Name = "����� 2", Description = "�������� 2", Year = "2019", Producer = "������", Owner = "�������" },
              new Film { Name = "����� 3", Description = "�������� 3", Year = "2018", Producer = "������", Owner = "�������" },
              new Film { Name = "����� 4", Description = "�������� 4", Year = "2019", Producer = "������", Owner = "�������" },
              new Film { Name = "����� 5", Description = "�������� 5", Year = "2012", Producer = "�������", Owner = "�������" },
              new Film { Name = "����� 6", Description = "�������� 6", Year = "2010", Producer = "������", Owner = "�������" },
              new Film { Name = "����� 7", Description = "�������� 7", Year = "2020", Producer = "�������", Owner = "�������" }
            );

        }
    }
}
