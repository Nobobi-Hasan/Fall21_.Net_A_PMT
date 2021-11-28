using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Security;

namespace ApiApp.Controllers
{
    [EnableCors("*", "*", "*")]
    public class LoginController : ApiController
    {

        [Route("api/Login/UserLogin")]
        [HttpPost]
        public void GetLogin(string username, string password)
        {

            var supervisor = SupervisorService.GetLogin(username, password);

            var member = MemberService.GetLogin(username, password);


            if (supervisor != null)
            {
                FormsAuthentication.SetAuthCookie(Convert.ToString(supervisor.Id), true);
                //Session["role"] = "Customer";
                //return RedirectToAction("Index", "Customer");
            }

            else if (member != null)
            {
                FormsAuthentication.SetAuthCookie(member.Username, true);
                //Session["role"] = "Shop";
                //return RedirectToAction("Index", "Shop");
            }
            //return View();
        }
    }
}
