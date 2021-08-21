using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    public class MailMessageBuilder
    {
        protected MailMessage _message;

        public MailMessageBuilder()
        {
            _message = new MailMessage();
            _message.IsBodyHtml = false;
        }

        public MailMessageBuilder IsBodyHtml(bool choice)
        {
            _message.IsBodyHtml=choice;
            return this;
        }

        public MailMessageBuilder Subject(string subject)
        {
            _message.Subject = subject;
            return this;
        }

        public MailMessageBuilder Body(string body)
        {
            _message.Body = body;
            return this;
        }

        public MailMessageBuilder AddCC(string cc)
        {
            _message.CC.Add(cc);
            return this;
        }

        public MailMessageBuilder From(string host, string name)
        {
            _message.From = new MailAddress(host,name);
            return this;
        }

        public MailMessageBuilder SendTo(string mail)
        {
            _message.To.Add(mail);
            return this;
        }

        public MailMessageBuilder Reset()
        {
            _message = new MailMessage();
            return this;
        }

        public MailMessageBuilder AddAttachment(string filePath)
        {
            Attachment att = new Attachment(filePath);
            _message.Attachments.Add(att);
            return this;
        }

        public MailMessageBuilder AddAttachments(string[] filePaths)
        {
            foreach(string path in filePaths)
            {
                Attachment att = new Attachment(path);
                _message.Attachments.Add(att);
            }
            return this;
        }

        public static implicit operator MailMessage(MailMessageBuilder builder)
        {
            return builder._message;
        }
    }
}
