using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    public class SmsNotifier : NotifierDecorator
    {
        public SmsNotifier(Notifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message); // Отправляем через базовый notifier
            Console.WriteLine($"Отправка SMS: {message}");
        }
    }

    public class FacebookNotifier : NotifierDecorator
    {
        public FacebookNotifier(Notifier notifier) : base(notifier) { }

        public override void Send(string message)
        {
            base.Send(message); // Отправляем через базовый notifier
            Console.WriteLine($"Отправка Facebook сообщения: {message}");
        }
    }
}
