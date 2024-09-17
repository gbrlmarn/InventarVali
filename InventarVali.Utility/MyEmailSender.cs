﻿using InventarVali.Models.ViewModel;
using InventarVali.Utility.Services;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace InventarVali.Utility
{
    public class MyEmailSender : IMyEmailSender
    {
        private readonly IConfiguration _config;
        public MyEmailSender(IConfiguration config)
        {
            _config = config;
        }

        public void SendEmail(string To, string subject, string htmlMessage)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_config.GetSection("EmailUsername").Value));
            email.To.Add(MailboxAddress.Parse(To));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = htmlMessage };

            using var smtp = new SmtpClient();
            smtp.Connect(_config.GetSection("EmailHost").Value, 465, SecureSocketOptions.SslOnConnect);
            smtp.Authenticate(_config.GetSection("EmailUsername").Value, _config.GetSection("EmailPassword").Value);
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
//var message = new MimeMessage();
//message.From.Add(new MailboxAddress("FromName", "fromAddress@gmail.com"));
//message.To.Add(new MailboxAddress("test", "mytestmail@test.it"));
//message.Subject = "test";
//message.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = $"<b>{body}</b>" };
//using var client = new SmtpClient();
//client.Connect("localhost", 3025, false);
//client.Authenticate("test", "test");
//await client.SendAsync(message);
//client.Disconnect(true);