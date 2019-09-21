using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace OnlineStore.DataProvider.Identity
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            var appEmail = WebConfigurationManager.AppSettings["applicationEmail"];
            var appEmailPassword = WebConfigurationManager.AppSettings["applicationEmailPassword"];
            SmtpClient client = new SmtpClient("smtp.yandex.ru", 25)
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential(appEmail, appEmailPassword),
                EnableSsl = true
            };

            var mail = new MailMessage(appEmail, message.Destination);
            mail.Subject = message.Subject;
            mail.Body = message.Body;
            mail.IsBodyHtml = true;

            return client.SendMailAsync(mail);
        }
    }
}
