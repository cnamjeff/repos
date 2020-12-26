
using System;
using System.Linq;
using System.Web.Mvc;
using TestJeffDataConnexion.Models;

namespace TestJeffDataConnexion.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login
        public virtual ActionResult Login()

        { 
            return View();
        }

        // GET: Login/Details/5

        /// <summary>Rapatriement des données</summary>
        /// <param name="param">jQueryDataTableParamModel</param>
        /// <returns>Json</returns>
        [HttpPost]
        public JsonResult ListingHandler(jQueryDataTableParamModel param)
        {

            var result =
                                 DaoGetLogin.GetLogin(param.search.value, param.MinDate, param.MaxDate, param.Etat).Select(
                                     item => new[] { item.login, item.addresse, item.webservice, item.date.ToString("yyyy-MM-dd HH:mm:ss.fff"), item.state, "" })
                                     .ToList();

            //fait le total de ce qui est retourné
            var totalCount = result.Count();

            result = result.Skip(param.start).ToList();

            if (param.length > 0)
                result = result.Take(param.length).ToList();

            return Json(new
            {
                param.draw,
                recordsTotal = totalCount,
                recordsFiltered = totalCount,
                data = result
            });


        }

    }
}
