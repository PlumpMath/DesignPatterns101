namespace Rigel.Samples.DesignPatterns.Creational.Factory
{
    public class EmailNotification : Notification
    {
        public static EmailNotification Create(string emailAddress, string subject, string body)
        {
            return new EmailNotification() { UserId = emailAddress, Title = subject, Content = body };
        }
    }
}