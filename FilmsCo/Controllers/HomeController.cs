using FilmsCo.Models;
using PagedList;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FilmsCo.Controllers
{
    public class HomeController : Controller
    {
        List<Film> Films;

        public HomeController()
        {
            Films = new List<Film>();
            Films.Add(new Film { Name = "Samsung Galaxi" });
            Films.Add(new Film { Name = "Samsung Galaxi II" });
            Films.Add(new Film { Name = "Samsung Galaxi II" });
            Films.Add(new Film { Name = "Samsung ACE" });
            Films.Add(new Film { Name = "Samsung ACE II" });
            Films.Add(new Film { Name = "HTC One S" });
            Films.Add(new Film { Name = "HTC One X" });
            Films.Add(new Film { Name = "Nokia N9" });
        }

        public ActionResult Index(int? page)
        {
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(Films.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Каталог фильмов.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Страница контактов.";

            return View();
        }
    }
}