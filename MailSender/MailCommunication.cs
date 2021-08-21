using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace MailSender
{
    public class MailCommunication : IMailCommunication
    {
        private SmtpClient smtpClient;

        public MailCommunication(Configuration cfg)
        {
            smtpClient = new SmtpClient();
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = false;
            smtpClient.Port = cfg.Port;
            smtpClient.Host = cfg.Smtp;
            smtpClient.Credentials = new System.Net.NetworkCredential(cfg.Hostmail, cfg.Password);
            smtpClient.Timeout = 1000;
        }

        public string SendMail(MailMessageBuilder builder)
        {
            try
            {
                smtpClient.Send(builder);
                return "OK";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
