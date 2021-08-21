using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    public class Configuration
    {
        public string Hostmail { get; set; } = "";
        public string Password { get; set; } = "";
        public string Smtp { get; set; } = "";
        public string Username { get; set; } = "";
        public int Port { get; set; } = 0;
    }
}
