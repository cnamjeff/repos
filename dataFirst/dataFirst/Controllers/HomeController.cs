using dataFirst.Models;
using dataFirst.Views.ModelView;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System;

namespace dataFirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //Create data

            using (var context = new dataFirstEntities())
            {
                var userr = new user
                {
                    name = "himmer",
                    firstName = "elodie"

                };
                //var user2 = new user
                //{
                //    name = "himmer",
                //    firstName = "fred"

                    //};
                    //var user3 = new user
                    //{
                    //    name = "himmer",
                    //    firstName = "jeff"

                    //};
                    //var user4 = new user
                    //{
                    //    name = "himmer",
                    //    firstName = "gennevieve"

                    //};
                    context.user.Add(userr);
                //context.user.Add(user2);
                //context.user.Add(user3);
                //context.user.Add(user4);
                context.SaveChanges();
            }


            List<dataFirst.Models.user> user = new List<user>();

            //read data
            using (var context = new dataFirstEntities())
            {
                user = context.user.ToList();

            }

            //read update
            using (var context = new dataFirstEntities())
            {
               
                var updateUser = context.user.Find(2);

                var update = context.Entry<user>(updateUser);
                updateUser.firstName = "tritri";
                update = context.Entry<user>(updateUser);


                context.SaveChanges();

            }

            //delate data
            using (var context = new dataFirstEntities())
            {

              var id = context.user.Find(1);

             if (id!=null)
                {

                    context.user.Remove(id);
                    var dbentry = context.Entry<user>(id);
                }


                context.SaveChanges();

            }
      
            

                return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}