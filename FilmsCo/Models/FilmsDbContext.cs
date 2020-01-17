using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FilmsCo.Models
{
    public class FilmsDbContext : DbContext
    {
        // Имя будущей базы данных можно указать через
        // вызов конструктора базового класса
        public FilmsDbContext() : base("DefaultConnection")
        { }

        // Отражение таблиц базы данных на свойства с типом DbSet
        public DbSet<Film> Films { get; set; }
    }
}
