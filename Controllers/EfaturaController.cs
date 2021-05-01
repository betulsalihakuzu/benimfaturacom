using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace BenimFaturaMVC.Controllers
{
    public class EfaturaController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Index(Models.Email model)
        {
            MailMessage mailim = new MailMessage();
            mailim.To.Add("bilgi@benimfatura.com");
            mailim.From = new MailAddress("bilgi@benimfatura.com");
            mailim.Subject = "Bize Ulaşın Sayfasından Mesajınız Var. ";
            mailim.Body = "Ad soyad:" + model.ad + " <br> Mail adresim:" +" " + model.email + " <br>Telefon Numaram:" + model.telefon + " <br>Konu:" + model.konu + " <br>Mesaj:" + model.mesaj;
            mailim.IsBodyHtml = true;

         

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("bilgi@benimfatura.com", "uyN_R:F3Wo2m24_:");
            smtp.Port = 587;
            smtp.Host = "smtp.benimfatura.com";
            smtp.EnableSsl = false;


            try
            {
                smtp.Send(mailim);

        
            }
            catch (Exception)
            {
                
            }


            return Json("asdasd");
        }

        public ActionResult Kampanyalar()
        {
            return View();
        }

        public ActionResult Iletisim_Destek()
        {
            return View();
        }

        public ActionResult Program_Iletisim()
        {
            return View();
        }

        public ActionResult KVKK()
        {
            return View();
        }
    }
}