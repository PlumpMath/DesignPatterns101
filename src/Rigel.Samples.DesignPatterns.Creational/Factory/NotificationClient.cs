namespace Rigel.Samples.DesignPatterns.Creational.Factory
{
    public class NotificationClient
    {
        public void CreatingNotificationsUsingFactoryMethodPattern()
        {
            var email = EmailNotification.Create("me@thatcompany.com", "Some cool notification", "Trying out the factory method pattern");
            var sms = TextMessageNotification.Create("780-444-3025", "Trying out the factory method pattern");
            var notification = InternalNotification.Create(8252, "Some cool notificatio", "Trying out the factory method pattern");
        }

        public INotification CreatingNotificationsUsingFactoryPattern()
        {
            var nType = NotificationType.Email;

            var n = Notification.Create(nType);

            return n;
        }
    }
}