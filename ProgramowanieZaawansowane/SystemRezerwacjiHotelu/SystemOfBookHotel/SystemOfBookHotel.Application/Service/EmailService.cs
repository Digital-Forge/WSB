using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using SystemOfBookHotel.Application.Extension;
using SystemOfBookHotel.Application.Interface;
using SystemOfBookHotel.Domain.Interface;

namespace SystemOfBookHotel.Application.Service
{
    public class EmailService : IEmailService
    {
        private readonly IProgramSettingRepository _programSettingRepo;
        private MailMessage mailMessage;
        private SmtpClient smtp;

        public EmailService(IProgramSettingRepository programSettingRepository)
        {
            _programSettingRepo = programSettingRepository;
        }

        public void SendMail(string to, string title, string text)
        {
            var conf = _programSettingRepo.GetEmailConfig();

            mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(conf.SenderEmail, conf.SenderName);
            mailMessage.To.Add(new MailAddress(to));
            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = title;
            mailMessage.BodyEncoding = Encoding.UTF8;
            mailMessage.SubjectEncoding = Encoding.UTF8;

            mailMessage.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(text.StripHTML(), null, MediaTypeNames.Text.Plain));
            mailMessage.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(htmlContent(text), null, MediaTypeNames.Text.Html));

            smtp = new SmtpClient
            {
                Host = conf.HostSmtp,
                EnableSsl = conf.EnableSSL,
                Port = conf.Port,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(conf.SenderEmail, conf.SenderEmailPassword)
            };

            smtp.SendCompleted += OnSendCompleted;
            smtp.SendMailAsync(mailMessage).Wait();

        }

        private void OnSendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            smtp.Dispose();
            mailMessage.Dispose();
        }

        private string htmlContent(string text)
        {
            return $@"
            <html>
                <head>
                </head>
                <body>
                    <div style='font-size: 16px; padding: 10px; font-family: Arial; line-height: 1.4;'>
                        {text}
                    </div>
                </body>
            </html>";
        }
    }
}
