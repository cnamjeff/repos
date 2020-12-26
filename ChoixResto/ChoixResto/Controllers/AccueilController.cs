using ChoixResto.Models;
using ChoixResto.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChoixResto.Controllers
{
    public class AccueilController : Controller
    {
        // GET: Accueil
        public ActionResult Index()
        {

            //ViewData["message"] = "Bonjour depuis le contrôleur";
            //ViewData["date"] = DateTime.Now;
            //ViewData["resto"] = new Resto { Nom = "Choucroute party", Telephone = "1234" };
            //return View();


            //Resto r = new Resto { Nom = "La bonne fourchette", Telephone = "1234" };
            //return View(r);

            //    AccueilViewModel vm = new AccueilViewModel
            //    {
            //        Message = "Bonjour depuis le <span style=\"color:red\">contrôleur</span>",
            //        Date = DateTime.Now,
            //        ListeDesRestos = new List<Resto>
            //{
            //    new Resto { Nom = "Resto pinambour", Telephone = "1234" },
            //    new Resto { Nom = "Resto tologie", Telephone = "1234" },
            //    new Resto { Nom = "Resto ride", Telephone = "5678" },
            //    new Resto { Nom = "Resto toro", Telephone = "555" },
            //}
            //    };
            //    return View(vm);

            List<Models.Resto> listeDesRestos = new List<Resto>
            {
                new Resto { Id = 1, Nom = "Resto pinambour", Telephone = "1234" },
                new Resto { Id = 2, Nom = "Resto tologie", Telephone = "1234" },
                new Resto { Id = 5, Nom = "Resto ride", Telephone = "5678" },
                new Resto { Id = 9, Nom = "Resto toro", Telephone = "555" },
            };

            ViewBag.ListeDesRestos = new SelectList(listeDesRestos, "Id", "Nom",5);
            return View("Index");

            using (IDal dal = new Dal())
            {
                List<Resto> listeDesRestaurants = dal.ObtientTousLesRestaurants();
                return View(listeDesRestaurants);
            }
        }

        //attribut imposant d'appeler cette méthode à partir de la vue mère!
       // [ChildActionOnly]
        public ActionResult AfficheListeRestaurant()
        {
            List<Models.Resto> listeDesRestos = new List<Resto>
        {
            new Resto { Id = 1, Nom = "Resto pinambour", Telephone = "1234" },
            new Resto { Id = 2, Nom = "Resto tologie", Telephone = "1234" },
            new Resto { Id = 5, Nom = "Resto ride", Telephone = "5678" },
            new Resto { Id = 9, Nom = "Resto toro", Telephone = "555" },
        };
            return PartialView("AfficheListeRestaurant", listeDesRestos);
        }

        public ActionResult ModifierRestaurant(int? id)
        {

            //string idStr = Request.QueryString["id"];
            //int id;
            //if (int.TryParse(idStr, out id))
            //{
            //    ViewBag.Id = id;
            //    return View();
            //}
            //else
            //    return View("Error");
            //--------------------------------------------------//

            //permet d'accéder à l'url et de récupérer le parametre
            /*string id = Request.Url.AbsolutePath.Split('/').Last();*/

            //-----------------------------------------//
            ViewBag.Id = id;
            if (id.HasValue)
            {
                ViewBag.Id = id;
                return View("restaurant");
            }
            else
                return View("Error");

            //---------------------------------------------------------//

            if (id.HasValue)
            {
                using (IDal dal = new Dal())
                {
                    Resto restaurant = dal.ObtientTousLesRestaurants().FirstOrDefault(r => r.Id == id.Value);
                    if (restaurant == null)
                        return View("Error");
                    return View(restaurant);
                }
            }
            else
                return View("Error");
        }

        //[HttpPost]
        //public ActionResult ModifierRestaurant(int? id, string nom, string telephone)
        //{
        //    if (id.HasValue)
        //    {
        //        using (IDal dal = new Dal())
        //        {
        //            dal.ModifierRestaurant(id.Value, nom, telephone);
        //            return RedirectToAction("Index");
        //        }
        //    }
        //    else
        //        return View("Error");
        //}

            [HttpPost]
        public ActionResult ModifierRestaurant(Resto resto)
        {
            if (!ModelState.IsValid)
                return View(resto);
            using (IDal dal = new Dal())
            {
                //dal.ModifierRestaurant(resto.Id, resto.Nom, resto.Telephone);
                return RedirectToAction("Index");
            }
        }
        public ActionResult CreerRestaurant()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreerRestaurant(Resto resto)
        {
            using (IDal dal = new Dal())
            {
                if (dal.RestaurantExiste(resto.Nom))
                {
                    ModelState.AddModelError("Nom", "Ce nom de restaurant existe déjà");
                    return View(resto);
                }
                if (!ModelState.IsValid)
                    return View(resto);
                dal.CreerRestaurant(resto.Nom, resto.Telephone);
                return RedirectToAction("Index");
            }
        }

        public ActionResult ObtientFichier()
        {
            string fichier = Server.MapPath("~/App_Data/MonFichier.txt");
            return File(fichier, "application/octet-stream", "MonFichier.txt");
        }


    }

   
}