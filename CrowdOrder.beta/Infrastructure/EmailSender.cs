using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Infrastructure
{
    public class EmailSender : IEmailSender
    {
        public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor)
        {
            Options = optionsAccessor.Value;
        }

        public AuthMessageSenderOptions Options { get; } //set only via Secret Manager

        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Execute(Options.SendGridKey, subject, message, email);
        }

        public Task SendEmailAsync(string email, string subject, string message, string ctaButtonText = "", string ctaButtonUrl = "", string greeting = "")
        {
            return Execute(Options.SendGridKey, subject, message, email, ctaButtonText, ctaButtonUrl, greeting);
        }

        public Task Execute(string apiKey, string subject, string message, string email, string ctaButtonText = "", string ctaButtonUrl = "", string greeting = "")
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage();
            
            var dynamicTemplateData = new ExampleTemplateData
            {
                H1 = subject,
                ButtonText = ctaButtonText,
                ButtonUrl = ctaButtonUrl,
                MainText = message,
                Greeting = greeting,
                Subject = subject
            };
            //msg.PlainTextContent = "email stuff";
            msg.SetFrom(new EmailAddress(Options.SendGridUser, "Crowd Order Team"));
            msg.AddTo(new EmailAddress(email));
            msg.SetTemplateId("d-b83a7f10c48c491f8026d5d1149bb502");
            msg.SetTemplateData(dynamicTemplateData);

            // Disable click tracking.
            // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
            msg.SetClickTracking(false, false);

            return client.SendEmailAsync(msg);
        }
    }
    public class ExampleTemplateData
    {

        [JsonProperty("h1")]
        public string H1 { get; set; }

        [JsonProperty("maintext")]
        public string MainText { get; set; }

        [JsonProperty("buttontext")]
        public string ButtonText { get; set; }

        [JsonProperty("buttonurl")]
        public string ButtonUrl { get; set; }

        [JsonProperty("greeting")]
        public string Greeting { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }
}
