using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using TelerikExample.Models;

namespace TelerikExample.Controllers
{
    public class GridController : Controller
    {
        public ActionResult GridPrincipal()
        {
            return PartialView("GridPrincipal");
        }

        public ActionResult GridPrincipalList([DataSourceRequest]DataSourceRequest request)
        {
            var x = GetCustomers();
            var y = x.ToDataSourceResult(request);
            return Json(y);
        }

        private static IEnumerable<GridModel> GetCustomers()
        {
            List<GridModel> list = new List<GridModel>();
            GridModel model;
            for (int i = 0; i< 100; i++)
            {
                model = new GridModel();
                model.name = Convert.ToBase64String(Encoding.UTF8.GetBytes("name" + i));
                model.alias = Convert.ToBase64String(Encoding.UTF8.GetBytes("alias" + i));
                model.email = Convert.ToBase64String(Encoding.UTF8.GetBytes("email" + i));
                model.dir = Convert.ToBase64String(Encoding.UTF8.GetBytes("dir" + i));

                list.Add(model);
            }

            return list;
        }
    }
}