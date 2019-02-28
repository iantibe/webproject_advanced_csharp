using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using websitecsharp.shared.viewmodels;
using websitecsharp.shared.orchestrators;
using websitecsharp.domain.entities;

namespace websitecsharp.web.Controllers
{
    
    public class HomeController : Controller
    {
       

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

       public ActionResult Update()
        {
            return View();
        }
        
       
        

    }
}