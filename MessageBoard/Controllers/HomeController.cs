using System;
using System.Web.Mvc;
using MessageBoard.Serivces;

namespace MessageBoard.Controllers
{
    public class HomeController : Controller
    {

        public HomeController(IMailService mail)
        {
            _mail = mail;
        }

        IMailService _mail { get; set; }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactModel model)
        {
            var msg = string.Format("Comment From: {1}{0}Email:{2}{0}Website: {3}{0}Comment{4}{0}",
                Environment.NewLine,
                model.Name,
                model.Email,
                model.Website,
                model.Comment);

            if (_mail.SendMail("noreply@beep2bleep.com", "web@beep2bleep.com", "Website Contact", msg))
            {
                ViewBag.MailSent = true;
            }
            return View();

        }

        [Authorize]
        public ActionResult MyMessages()
        {
            return View();
        }

    }
}