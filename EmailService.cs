Task 01 : Email Service
using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Threading.Tasks;

namespace SendGridEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            SendEmail().Wait();
        }

        static async Task SendEmail()
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("nasrinyoosuf772@gmail.com", "NasrinYoosuf");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("thowfeeksahna559@gmail.com", "SahnaThowfeek");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}

