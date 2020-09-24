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
            return Execute(Options.SendGridKey, subject, message, email);
        }

        public Task SendEmailAsync(string email, string subject, string message, string ctaButtonText = "", string ctaButtonUrl = "", string greeting = "", EmailTemplate template = EmailTemplate.Generic)
        {
            return Execute(Options.SendGridKey, subject, message, email, ctaButtonText, ctaButtonUrl, greeting, template);
        }

        public Task SendEmailAsync(List<string> recipients, ExampleTemplateData data, EmailTemplate template = EmailTemplate.Generic)
        {
            return Execute(Options.SendGridKey, data, recipients, template);
        }

        public Task Execute(string apiKey, ExampleTemplateData dynamicTemplateData, List<string> recipients, EmailTemplate template = EmailTemplate.Generic)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage();

          
            //msg.PlainTextContent = "email stuff";
            msg.SetFrom(new EmailAddress(Options.SendGridUserMike, "Mike Patrick"));
            foreach(var person in recipients)
            {
                msg.AddTo(new EmailAddress(person));
            }
            
            switch (template)
            {
                case EmailTemplate.Generic:
                    msg.SetTemplateId("d-b83a7f10c48c491f8026d5d1149bb502");
                    break;
                case EmailTemplate.Welcome:
                    msg.SetTemplateId("d-e432d3abc3214fbea849d1ea2fbf64fc");
                    break;
                case EmailTemplate.PartnerPlain:
                    msg.SetTemplateId("d-ef6ac52e63a24b8f9ca5c660da9fd267");
                    break;
                case EmailTemplate.ConnectionEmail:
                    msg.SetTemplateId("d-c8f648d493ef43f49c27692542bd3923");
                    break;
                default:
                    msg.SetTemplateId("d-b83a7f10c48c491f8026d5d1149bb502");
                    break;
            }
            msg.SetTemplateData(dynamicTemplateData);

            // Disable click tracking.
            // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
            msg.SetClickTracking(false, false);

            return client.SendEmailAsync(msg);
        }

        public Task Execute(string apiKey, string subject, string message, string email, string ctaButtonText = "", string ctaButtonUrl = "", string greeting = "", EmailTemplate template = EmailTemplate.Generic)
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
            switch (template)
            {
                case EmailTemplate.Generic:
                    msg.SetTemplateId("d-b83a7f10c48c491f8026d5d1149bb502");
                    break;
                case EmailTemplate.Welcome:
                    msg.SetTemplateId("d-e432d3abc3214fbea849d1ea2fbf64fc");
                    break;
                case EmailTemplate.PartnerPlain:
                    msg.SetTemplateId("d-ef6ac52e63a24b8f9ca5c660da9fd267");                    
                    break;
                default:
                    msg.SetTemplateId("d-b83a7f10c48c491f8026d5d1149bb502");
                    break;
            }
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
        
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("body2")]
        public string Body2 { get; set; }
        [JsonProperty("greeting2")]
        public string Greeting2 { get; set; }
    }
}
