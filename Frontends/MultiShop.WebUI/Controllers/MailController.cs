using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MultiShop.WebUI.Models;

namespace MultiShop.WebUI.Controllers
{
    public class MailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SendMail(MailRequest mailRequest)
        {
            MimeMessage mimeMessage=new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("MultiShop Katalog", "mail adresiniz");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReveiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder= new BodyBuilder();
            bodyBuilder.TextBody = mailRequest.MessageContent;
            mimeMessage.Body=bodyBuilder.ToMessageBody();

            mimeMessage.Subject=mailRequest.Subject;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("mail adresi", "mail şifresi");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);
            
            return View();
        }
    }
}
