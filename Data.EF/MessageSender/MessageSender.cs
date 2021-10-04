using Domain.Contracts;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Data.EF
{
    public class MessageSender : IMessageSender
    {
        public Task SendEmailAsync(string toEmail, string subject, string message, bool isMessageHtml = false)
        {
            using (var Client = new SmtpClient())
            {
                var Credential = new NetworkCredential
                {
                    //UserName Example : If your email is test@gmail.com yourUserName is test
                    UserName = "adsfluencermail",
                    Password = "Adsfluencer_1400"

                };
                Client.Credentials = Credential;
                Client.Host = "smtp.gmail.com";
                Client.Port = 587; // or 25  -- 587 -- 465 For Send Email
                Client.EnableSsl = true;
                using (var emailMessage = new MailMessage())
                {
                    emailMessage.To.Add(new MailAddress(toEmail));
                    emailMessage.From = new MailAddress("adsfluencermail@gmail.com", subject);
                    emailMessage.Subject = subject;
                    emailMessage.IsBodyHtml = true; //contains html tag
                    emailMessage.Body = message;

                    Client.Send(emailMessage);
                };
                //await Task.CompletedTask;
            }
            return Task.CompletedTask;
        }
    }
}
