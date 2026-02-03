using Domain.Helpers;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MimeKit;

namespace Domain.Service
{
    public class EmailService : IEMailService
    {
        private readonly MailSettings _mailSettings;
        private readonly IConfiguration _config;
        public EmailService(IOptions<MailSettings> mailSettings, IConfiguration config)
        {
            _mailSettings = mailSettings.Value;
            _config = config;
        }
        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            try
            {
                var fromMail = _config["MailSettings:FromMail"];
                var displayName = _config["MailSettings:DisplayName"];

                var email = new MimeMessage();
                email.From.Add(new MailboxAddress(displayName, fromMail));
                email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
                email.Subject = mailRequest.Subject;

                var builder = new BodyBuilder() ;//{ HtmlBody = mailRequest.Body };
                builder.HtmlBody = mailRequest.Body;
                email.Body = builder.ToMessageBody();

                using var smtp = new SmtpClient();
                await smtp.ConnectAsync(_mailSettings.Host, _mailSettings.Port, _mailSettings.UseSSL);
                await smtp.AuthenticateAsync(_mailSettings.UserMail, _mailSettings.Password);
                await smtp.SendAsync(email);
                await smtp.DisconnectAsync(true);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
