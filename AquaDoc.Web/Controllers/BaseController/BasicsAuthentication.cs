using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using AquaDoc.DataEntities;
using System;


namespace Mins.QuarkDoc.Web.Controllers
{
    public class BasicsAuthentication : Controller
    {
        public User Os_User { get; set; }
        public bool IsAdmin { get; set; } = false;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            try
            {
                bool userObj = User.Identity.IsAuthenticated;
                if (userObj == true)
                {
                    this.Os_User = null;
                    this.IsAdmin = Os_User.IsAdmin;
                    ViewData["OS_ISADMIN"] = Os_User.IsAdmin;
                    ViewData["OS_USERNAME"] = Os_User.IsAdmin;
                }
                else
                {
                    filterContext.Result = new RedirectResult("/Login");
                }
            }
            catch (Exception)
            {
                filterContext.Result = new RedirectResult("/Login");
            }

        }
    }
}