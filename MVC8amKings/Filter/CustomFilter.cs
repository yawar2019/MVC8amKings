using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC8amKings.Filter
{
    
    public class CustomFilter :ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            (filterContext.Result as ViewResult).ViewBag.Player = "Suresh Raina";
        }
    }
}

//if you want to execute some logic before an action method executed or after and action method execute we are going to use
//filter

    //Authorize
    //Action
    //Result
    //HandleError