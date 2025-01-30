using System.IO;
using System.Threading.Tasks;
using Behnammby.Common.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Hosting;
using MimeKit;
using System;
using System.Text.RegularExpressions;
using System.Linq;
using MimeKit.Utils;
using MailKit.Security;

namespace Behnammby.Common.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailSettings _emailSettings;

        public EmailService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task SendEmailAsync(string email, string subject, MimeEntity messageBody)
        {
            try
            {
                var mimeMessage = new MimeMessage();

                mimeMessage.From.Add(new MailboxAddress(_emailSettings.SenderName, _emailSettings.Sender));

                mimeMessage.To.Add(new MailboxAddress(email));

                mimeMessage.Subject = subject;

                mimeMessage.Body = messageBody;

                using (var client = new SmtpClient())
                {
                    // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                    await client.ConnectAsync(_emailSettings.MailServer, _emailSettings.MailPort, SecureSocketOptions.Auto);

                    // Note: only needed if the SMTP server requires authentication
                    await client.AuthenticateAsync(_emailSettings.Sender, _emailSettings.Password);

                    await client.SendAsync(mimeMessage);

                    await client.DisconnectAsync(true);
                }

            }
            catch (Exception ex)
            {
                // TODO: handle exception
                throw new InvalidOperationException(ex.Message);
            }
        }
    
        public static string EmbedImages(string message, string imagesPath, BodyBuilder builder)
        {
            var imgs = Regex.Matches(message, "<img.+?src=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase);
            foreach (var img in imgs.Select(x => x.Groups[1].Value))
            {
                var fileName = img.Split("/").LastOrDefault();
                var path = Path.Combine(imagesPath, fileName);
                var image = builder.LinkedResources.Add(path);
                image.ContentId = MimeUtils.GenerateMessageId();
                message = message.Replace(img, string.Format("cid:{0}", image.ContentId));
            }

            return message;
        }
    }
}