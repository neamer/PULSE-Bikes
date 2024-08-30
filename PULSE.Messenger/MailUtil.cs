using System.Net.Mail;
using System.Net;
using PULSE.Model;

namespace PULSE.Messenger
{
    public class MailUtil
    {
        public static void sendEmail(Email email)
        {
            string serverAddress = Environment.GetEnvironmentVariable("SERVER_ADDRESS") ?? "smtp.gmail.com";
            string mailSender = Environment.GetEnvironmentVariable("MAIL_SENDER") ?? "noreply.pulsebikes@gmail.com";
            string mailPass = Environment.GetEnvironmentVariable("MAIL_PASS") ?? "xdjshsnocmbhxfjd";
            int port = int.Parse(Environment.GetEnvironmentVariable("MAIL_PORT") ?? "587");

            string content = $"<p>{email.Message}</p>";
            string subject = email.Subject;

            var message = new MailMessage()
            {
                From = new MailAddress(mailSender),
                To = { new MailAddress(email.Recipient) },
                Subject = subject,
                Body = content,
                IsBodyHtml = true
            };

            var smtpClient = new SmtpClient(serverAddress, port)
            {
                Credentials = new NetworkCredential(mailSender, mailPass),
                EnableSsl = true
            };

            try
            {
                Console.WriteLine("Processing email");
                smtpClient.Send(message);
                Console.WriteLine("Mail sent");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while sending email: " + ex?.Message);
            }
        }
    }
}
