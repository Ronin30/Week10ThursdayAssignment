using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStore.Models;

namespace MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Disco"},
                new Genre {Name = "Jazz" },
                new Genre {Name = "Rock" }
            };

            return View(genres);
        }

        //GET: /Store/Browse?genre=Disco

        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { Name = genre };

            return View(genreModel);
        }

        //Get: /Store/Details/5

        public ActionResult Details(int id)
        {
            //string message = "Store.Details, ID = " + id;

            //return message;
            var album = new Album { Title = "Album" + id };

            return View(album);
        }
    }
}