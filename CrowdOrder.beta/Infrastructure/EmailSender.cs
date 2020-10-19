using MailKit.Security;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using MimeKit;
using Newtonsoft.Json;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using System.IO;
using CrowdOrder.beta.Data;
using System.Reflection.Metadata.Ecma335;

namespace CrowdOrder.beta.Infrastructure
{
    public class EmailSender : IEmailSender
    {
        public enum EmailTemplate
        {
            Generic = 0,
            Welcome = 1,
            PartnerPlain = 2,
            ConnectionEmail = 3

        }
        public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor)
        {
            Options = optionsAccessor.Value;
        }

        public AuthMessageSenderOptions Options { get; } //set only via Secret Manager

        public Task SendEmailAsync(string email, string subject, string message)
        {
            var data = new EmailTemplateData()
            {
                Subject = subject,
                MainText = message
            };
            return Send(data, new List<string>() { email});
        }

        public Task SendEmailAsync(string email, string subject, string message, string ctaButtonText = "", string ctaButtonUrl = "", string greeting = "", EmailTemplate template = EmailTemplate.Generic)
        {
            var data = new EmailTemplateData()
            {
                Subject = subject,
                MainText = message,
                ButtonText = ctaButtonText,
                ButtonUrl = ctaButtonUrl,
                Greeting = greeting
            };
            return Send(data, new List<string>() { email }, template);
        }

        public Task SendEmailAsync(List<string> recipients, EmailTemplateData data, EmailTemplate template = EmailTemplate.Generic)
        {
            return Send(data, recipients, template);
        }
       
        public Task Send(EmailTemplateData templateData, List<string> recipients, EmailTemplate template = EmailTemplate.Generic)
        {           
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(Options.EmailUser);
            foreach (var recipient in recipients)
            {
                email.To.Add(MailboxAddress.Parse(recipient));
            }

            email.Subject = templateData.Subject;
            var builder = new BodyBuilder();
            string filePath = Directory.GetCurrentDirectory();
            switch (template)
            {
                case EmailTemplate.Generic:
                    filePath += @"\wwwroot\emails\Generic.html";
                    break;
                case EmailTemplate.Welcome:
                    filePath += @"\wwwroot\emails\Welcome.html";
                    break;
                case EmailTemplate.PartnerPlain:
                    filePath += @"\wwwroot\emails\Plain.html";
                    break;
                case EmailTemplate.ConnectionEmail:
                    filePath += @"\wwwroot\emails\PlainConnect.html";
                    break;
                default:
                    filePath += @"\wwwroot\emails\generic.html";
                    break;
            }
            StreamReader str = new StreamReader(filePath);
            string mailText = str.ReadToEnd();
            str.Close();
            mailText = mailText
                .Replace("{{h1}}", templateData.H1)
                .Replace("{{maintext}}", templateData.MainText)
                .Replace("{{buttontext}}", templateData.ButtonText)
                .Replace("{{buttonurl}}", templateData.ButtonUrl)
                .Replace("{{body}}", templateData.Body)
                .Replace("{{body2}}", templateData.Body2)
                .Replace("{{greeting}}", templateData.Greeting)
                .Replace("{{greeting2}}", templateData.Greeting2);

            builder.TextBody = mailText;
            builder.HtmlBody = mailText;

            email.Body = builder.ToMessageBody();
            using (var smtp = new MailKit.Net.Smtp.SmtpClient())
            {
                smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate(Options.EmailUser, Options.EmailUserPassword);
                smtp.Send(email);
                smtp.Disconnect(true);
            }

            return Task.FromResult(true);

        }
    }   
}
