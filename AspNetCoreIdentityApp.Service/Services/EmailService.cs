using AspNetCoreIdentityApp.Core.OptionsModels;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

namespace AspNetCoreIdentityApp.Service.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailSettings _emailSettings;

        public EmailService(IOptions<EmailSettings> options)
        {
            _emailSettings = options.Value;
        }

        public async Task SendResetPasswordEmail(string resetEmailPasswordLink, string toEmail)
        {
            var smtpClient = new SmtpClient
            {
                Host = _emailSettings.Host!,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Port = 587,
                Credentials = new NetworkCredential(_emailSettings.Email, _emailSettings.Password),
                EnableSsl = true
            };


            var mailMessage = new MailMessage
            {
                From = new MailAddress(_emailSettings.Email!)
            };
            mailMessage.To.Add(toEmail);
            mailMessage.Subject = "Şifre sıfırlama linki";
            mailMessage.Body = @$"
                                <h4>Şifrenizi yenilemek için aşağıdaki linke tıklayınız.</h4>
                                <p><a href='{resetEmailPasswordLink}'>şifre yenileme link</a></p>";

            mailMessage.IsBodyHtml = true;

            await smtpClient.SendMailAsync(mailMessage);
        }
    }
}
