using System;
using System.Collections.Generic;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace JoeGregory.Server.Services
{
    public class EmailService
    {
        private string apiKey;

        public EmailService(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public void SendEmail(string email, string name, string message)
        {
            string subject = $"Joe Gregory Portfolio contact from {name}";
            string content = $"<u>Contact from Porfolio Website Joseph Gregory.</u><br> <strong>Contact Person:</strong> {name}.<br>" + $"<strong>Contact email:</strong> {email}<br>" + "<strong>Message:</strong><br>"+ message;
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", this.apiKey);

            var apiInstance = new TransactionalEmailsApi();

            var sendSmtpEmail = new SendSmtpEmail(
                to: new List<SendSmtpEmailTo> { new SendSmtpEmailTo(email: email), new SendSmtpEmailTo(email:"joe@gummilabs.com") },
                subject: subject,
                htmlContent: content,
                sender: new SendSmtpEmailSender(name: "Joseph Porftolio Website", email: "joe@gummilabs.com")
            );

            try
            {
                var result = apiInstance.SendTransacEmail(sendSmtpEmail);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling TransactionalEmailsApi.SendTransacEmail: " + e.Message);
            }
        }
    }
}
