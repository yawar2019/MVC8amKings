using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC8amKings.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        [Route("Superman/shopping")]
        [Route("batman/cricket")]
        public string  helloworld() {

            return "Hello to All";
        }

        public int helloworld2()
        {

            return 1211;
        }

        public ActionResult getView()
        {

            return View("Contact");
        }
        public ActionResult getViewofDefault()
        {

            return View("~/Views/Default/index.cshtml");
        }
        public string helloworld12(string id)
        {

            return "Hello to All "+ id;
        }

    }
}