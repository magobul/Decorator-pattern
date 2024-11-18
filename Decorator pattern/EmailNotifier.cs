using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    public class EmailNotifier:Notifier
    {
        private readonly List<string> _adminEmails;

        public EmailNotifier(List<string> adminEmails)
        {
            _adminEmails = adminEmails;
        }

        public void Send(string message)
        {
            foreach (var email in _adminEmails)
            {
                Console.WriteLine($"Отправка Email на {email}: {message}");
            }
        }
    }
}
