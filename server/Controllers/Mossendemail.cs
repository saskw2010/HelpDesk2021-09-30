using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testauth.Models;

namespace Testauth.Server.Controllers
{
    public class Mossendemail
    {
        

        public async Task SendEmail(ApplicationUser user, string userEmail, string callbackUrl, string subject, string text)
        {
            var client = new System.Net.Mail.SmtpClient("mail.wytsky.com");
            client.UseDefaultCredentials = false;


            client.Credentials = new System.Net.NetworkCredential("info@wytsky.com", "#########");

            var mailMessage = new System.Net.Mail.MailMessage();
            mailMessage.From = new System.Net.Mail.MailAddress("info@wytsky.com");
            mailMessage.To.Add(userEmail);
            if (callbackUrl != null)
            {
                mailMessage.Body = string.Format(@"<a href=""{0}"">{1}</a>", callbackUrl, text);
            }
            else
            {
                mailMessage.Body = text;
            }

            mailMessage.Subject = subject;
            mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
            mailMessage.IsBodyHtml = true;

            OnSendEmail(mailMessage);

            await client.SendMailAsync(mailMessage);
        }

        private void OnSendEmail(System.Net.Mail.MailMessage mailMessage)
        {
            throw new NotImplementedException();
        }
    }
}
