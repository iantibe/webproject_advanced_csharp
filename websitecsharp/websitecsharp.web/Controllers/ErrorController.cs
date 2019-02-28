using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using websitecsharp.shared.orchestrators;

namespace websitecsharp.web.Controllers
{
    public class ErrorController : Controller
    {
        private ErrorOrchestrator _errororchestrator = new ErrorOrchestrator();

        // GET: Error
        public ActionResult Error()
        {
            return View();
        }

        public async Task<ActionResult> GenerateErrorAction()
        {
            
          await _errororchestrator.GenerateError();

            return View("Error");
        }

        public ActionResult ErrorGenerator()
        {
            
            return View();
        }

        public ActionResult NotFound()
        {
            Response.StatusCode = 404;
            return View("NotFound");
        }
    }
}