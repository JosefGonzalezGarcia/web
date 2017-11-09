using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelerikExample.Models;

namespace TelerikExample.Controllers
{
    public class FormularioController : Controller
    {
        [HttpGet]
        public ActionResult FormularioBasico()
        {
            return PartialView(new FormularioBasicoModel());
        }

        [HttpPost]
        public ActionResult FormularioBasico(FormularioBasicoModel model)
        {
            ActionResult result;
            if (ModelState.IsValid)
            {
                result = new HttpStatusCodeResult(200);
            }
            else
            {
                IEnumerable errors = ModelState.ToDictionary(kvp => kvp.Key,
                                             kvp => kvp.Value.Errors
                                                             .Select(e => e.ErrorMessage).ToArray())
                                                             .Where(m => m.Value.Count() > 0);

                //Response.TrySkipIisCustomErrors = true;
                Response.StatusCode = 400;
                result = Json(new { success = false, errors = errors });
            }
            return result;
        }
    }
}