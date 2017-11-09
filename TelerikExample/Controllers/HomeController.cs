using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TelerikExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OptionsMenu()
        {
            ViewBag.inlineDefault = GetDefaultInlineData();
            return View();
        }

        private IEnumerable<PanelBarItemModel> GetDefaultInlineData()
        {
            var dictPrinc = new Dictionary<string, string>();
            dictPrinc.Add("onclick", "gridPrincipal()");
            var dictForm = new Dictionary<string, string>();
            dictForm.Add("onclick", "formularioBasico()");

            List<PanelBarItemModel> inlineDefault = new List<PanelBarItemModel>
                {
                    new PanelBarItemModel
                    {
                        Text = "Grid principal",
                        HtmlAttributes = dictPrinc
                    },
                    new PanelBarItemModel
                    {
                        Text = "Formulario",
                        Items = new List<PanelBarItemModel>
                        {
                            new PanelBarItemModel()
                            {
                                Text = "Formulario Basico",
                                HtmlAttributes = dictForm
                            }
                        }
                    }
                };

            return inlineDefault;
        }
    }
}