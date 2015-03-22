using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaMVC.Models;

namespace TiendaMVC.Controllers
{
    public class PaymentController : Controller
    {
        //
        // GET: /Payment/
        [Authorize()]
        public ActionResult Index()
        {
            var session = System.Web.HttpContext.Current.Session;
            using (StoreModel model = new StoreModel())
            {
                if (session["cart"] != null)
                {
                    var cartProducts = (List<int>)session["cart"];
                    return View(model.Products.Join(cartProducts, p => p.Id, cp => cp, (p, cp) => p).ToList());
                }
                else
                    return View();
            }

        }

    }
}
