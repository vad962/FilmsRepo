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
              new  Film { Name = "Фильм 1", Description = "Описание 1", Year = "2018", Producer = "Иванов", Owner = "Сидоров" },
              new Film { Name = "Фильм 2", Description = "Описание 2", Year = "2019", Producer = "Петров", Owner = "Федоров" },
              new Film { Name = "Фильм 3", Description = "Описание 3", Year = "2018", Producer = "Иванов", Owner = "Сидоров" },
              new Film { Name = "Фильм 4", Description = "Описание 4", Year = "2019", Producer = "Петров", Owner = "Федоров" },
              new Film { Name = "Фильм 5", Description = "Описание 5", Year = "2012", Producer = "Сидоров", Owner = "Федоров" },
              new Film { Name = "Фильм 6", Description = "Описание 6", Year = "2010", Producer = "Петров", Owner = "Федоров" },
              new Film { Name = "Фильм 7", Description = "Описание 7", Year = "2020", Producer = "Федоров", Owner = "Федоров" }
            );

        }
    }
}
