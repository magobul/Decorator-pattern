using Decorator_pattern;

class Program
{
    static void Main(string[] args)
    {
        List<string> adminEmails = new List<string> { "admin@gmail.com", "admin1@gmail.com" };

        Notifier notifier = new EmailNotifier(adminEmails);

        notifier = new SmsNotifier(notifier);

        notifier = new FacebookNotifier(notifier);

        notifier.Send("Это важное уведомление!");
    }
}