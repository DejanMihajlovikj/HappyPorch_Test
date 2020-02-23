using System.Web.Mvc;
using Umbraco.Web.Mvc;
using UmbracoTestProject.Core.ViewModels;
using System.Net.Mail;

namespace UmbracoTestProject.Core.Controllers.Surface
{
    public class ContactFormController : SurfaceController
    {
        public ActionResult Render()
        {
            return PartialView("Forms/ContactForm");
        }

        [HttpPost, ValidateInput(true)]
        [ValidateAntiForgeryToken]
        public ActionResult Submit(ContactFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            SmtpClient smtpClient = new SmtpClient("mail.happyporch.com", 25);
            smtpClient.Credentials = new System.Net.NetworkCredential("info@happyporch.com", "myIDPassword");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(viewModel.Email);
            mail.To.Add(new MailAddress("info@happyporch.com"));

            smtpClient.Send(mail);

            return RedirectToCurrentUmbracoPage();
        }
    }
}
