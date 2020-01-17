using FilmsCo.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FilmsCo.Controllers
{
    public class HomeController : Controller
    {
        private Film mModel;
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

        public ActionResult AddFilm()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SaveFilm()
        {
            string str = "";
            mModel = (Film)Session["FilmModel"];
            if (mModel == null)
            {
                mModel = new Film();
            }
            // Извлечь отправленные данные из Request.Form 
            System.Collections.Specialized.NameValueCollection coll = Request.Form;
            if (ModelState.IsValid)
            {

                //Name
                mModel.Name = coll["Name"];
                //Description
                mModel.Description = coll["Description"];
                //Year
                mModel.Year = coll["Year"];
                //Producer
                mModel.Producer = coll["Producer"];
                //Owner
                mModel.Owner = coll["Owner"];
                // Загрузить Poster с помощью средств .NET
                var poster = Request.Files["File"];
                // now you can get and validate the file type:
                //var isFileSupported = IsFileSupported(postedFile);
                //var poster = Request.Files["Poster"];
                if (poster != null)
                {
                    BinaryReader b = new BinaryReader(poster.InputStream);
                    mModel.Poster = b.ReadBytes((int)poster.InputStream.Length);
                }
            }
            //Сохранить информацию о фильме
            try
            {
                DoSaveFilm(mModel);
            }
            catch (Exception ex)
            {
                Session["ErrString"] = ex.Message;
            }

            Session["FilmModel"] = mModel;

            return View("AddFilm", mModel);
        }


        [NonAction]
        private static void DoSaveFilm(Film film)
        {
            if (film == null) return;
            // Создать объект контекста
            FilmsDbContext context = new FilmsDbContext();

            // Вставить данные в таблицу Films с помощью LINQ
            context.Films.Add(film);

            // Сохранить изменения в БД
            context.SaveChanges();
        }

    }
}