using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace FilmsCo.Models
{
    public class FilmsDbContext : ApplicationDbContext
    {
        static FilmsDbContext() //: base("FilmsDbContext")
        {
            Database.SetInitializer<FilmsDbContext>(new FilmsDbContextInitializer());  //CreateDatabaseIfNotExists<FilmsDbContext>());
            //DbMigrationsConfiguration.AutomaticMigrationsEnabled = true;
        }
        //// Имя будущей базы данных можно указать через
        //// вызов конструктора базового класса
        //public FilmsDbContext() : base("FilmsDbContext")
        //{ }

        // Отражение таблиц базы данных на свойства с типом DbSet
        public DbSet<Film> Films { get; set; }

        //public DbSet<ImgFile> ImgFiles { get; set; }
    }

    class FilmsDbContextInitializer : DropCreateDatabaseIfModelChanges<FilmsDbContext>
    {
        protected override void Seed(FilmsDbContext db)
        {
            Film p1 = new Film { Name = "Фильм 1", Description = "Описание 1", Year = "2018", Producer="Иванов", Owner = "Сидоров" };
            Film p2 = new Film { Name = "Фильм 2", Description = "Описание 2", Year = "2019", Producer = "Петров", Owner = "Федоров" };
            Film p3 = new Film { Name = "Фильм 3", Description = "Описание 3", Year = "2018", Producer = "Иванов", Owner = "Сидоров" };
            Film p4 = new Film { Name = "Фильм 4", Description = "Описание 4", Year = "2019", Producer = "Петров", Owner = "Федоров" };

            db.Films.Add(p1);
            db.Films.Add(p2);
            db.Films.Add(p3);
            db.Films.Add(p4);
            db.SaveChanges();
        }
    }
}
