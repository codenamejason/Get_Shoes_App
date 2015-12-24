using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace NiceShoesWebApplicationMaster.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What Nice Shoes Can Do For You";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Nice Shoes.";

            return View();
        }

        //public enum ManageMessageId
        //{
        //    HomeViewMessage,
        //    AboutViewMessage,
        //    ContactViewMessage
        //}

        //public async Task<ActionResult> Index(HomeController.ManageMessageId? message)
        //{
        //    ViewBag.StatusMessage =
        //        message == ManageMessageId.HomeViewMessage ? "Nice Shoes"
        //        : message == ManageMessageId.AboutViewMessage ? "What Nice Shoes Can Do For You?"
        //        : message == ManageMessageId.ContactViewMessage ? "Contact Nice Shoes."
        //        : "";

        //    //var userId = User.Identity.GetUserId();
        //    //var model = new IndexViewModel
        //    //{
        //    //    HasPassword = HasPassword(),
        //    //    PhoneNumber = await UserManager.GetPhoneNumberAsync(userId),
        //    //    TwoFactor = await UserManager.GetTwoFactorEnabledAsync(userId),
        //    //    Logins = await UserManager.GetLoginsAsync(userId),
        //    //    BrowserRemembered = await AuthenticationManager.TwoFactorBrowserRememberedAsync(userId)
        //    //};
        //    return View();
        //}

    }
}