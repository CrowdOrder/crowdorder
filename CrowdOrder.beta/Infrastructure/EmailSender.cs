﻿using MailKit.Security;
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
using Microsoft.Extensions.Configuration;

namespace CrowdOrder.beta.Infrastructure
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;
        public enum EmailTemplate
        {
            Generic = 0,
            Welcome = 1,
            PartnerPlain = 2,
            ConnectionEmail = 3

        }
        public EmailSender(IConfiguration configuration, IOptions<AuthMessageSenderOptions> optionsAccessor)
        {
            Options = optionsAccessor.Value;
            _configuration = configuration;
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
            email.Sender.Name = "Crowd Order Team";
            foreach (var recipient in recipients)
            {
                email.To.Add(MailboxAddress.Parse(recipient));
            }
            if (_configuration["Environment"].ToLower() != "dev")
            {
                email.Bcc.Add(MailboxAddress.Parse(Options.EmailUser));
            }
            

            email.Subject = templateData.Subject;
            var builder = new BodyBuilder();
            string tPath = Directory.GetCurrentDirectory();
            var hPath = Directory.GetCurrentDirectory();
            switch (template)
            {
                case EmailTemplate.Generic:
                    hPath += _configuration["EmailPaths:Generic.html"].ToLower();
                    tPath += _configuration["EmailPaths:Generic.txt"].ToLower();
                    break;
                case EmailTemplate.Welcome:
                    hPath += _configuration["EmailPaths:Welcome.html"].ToLower();
                    tPath += _configuration["EmailPaths:Welcome.txt"].ToLower();
                    break;
                case EmailTemplate.PartnerPlain:
                    hPath += _configuration["EmailPaths:Plain.html"].ToLower();
                    tPath += _configuration["EmailPaths:Plain.txt"].ToLower();
                    break;
                case EmailTemplate.ConnectionEmail:
                    hPath += _configuration["EmailPaths:PlainConnect.html"].ToLower();
                    tPath += _configuration["EmailPaths:PlainConnect.txt"].ToLower();
                    break;
                default:
                    hPath += @"\wwwroot\emails\generic.html";
                    tPath += @"\wwwroot\emails\Generic.txt";
                    break;
            }
            //HTML
            StreamReader str = new StreamReader(hPath);
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

            
            builder.HtmlBody = mailText;

            //text
            StreamReader str2 = new StreamReader(tPath);
            string mailText2 = str2.ReadToEnd();
            str2.Close();
            mailText2 = mailText2
                .Replace("{{h1}}", templateData.H1)
                .Replace("{{maintext}}", templateData.MainText)
                .Replace("{{buttontext}}", templateData.ButtonText)
                .Replace("{{buttonurl}}", templateData.ButtonUrl)
                .Replace("{{body}}", templateData.Body)
                .Replace("{{body2}}", templateData.Body2)
                .Replace("{{greeting}}", templateData.Greeting)
                .Replace("{{greeting2}}", templateData.Greeting2);



            builder.TextBody = mailText2;

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
