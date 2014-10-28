using System;
using System.Dynamic;

namespace Rigel.Samples.DesignPatterns.Creational.Factory
{
    public enum NotificationType
    {
        Sms,
        Email,
        Mail,
        Push,
        EMessage
    }

    public interface INotification
    {
        string UserId { get; }
        string Title { get;  }
        string Content { get; }
    }

    public class Notification : INotification
    {
        public string UserId { get; protected set; }
        public string Title { get; protected set; }
        public string Content { get; protected set; }

        public static TNotification Create<TNotification>() where TNotification : INotification
        {
            var notification = Activator.CreateInstance<TNotification>();
            return notification;
        }

        public static INotification Create(NotificationType type) 
        {
            Type dotNetType = null;

            if (type == NotificationType.Sms)
            {
                dotNetType = typeof(TextMessageNotification);
            }

            if (type == NotificationType.Email)
            {
                dotNetType = typeof(EmailNotification);
            }

            if (type == NotificationType.Push)
            {
                dotNetType = typeof(PushNotification);
            }

            var notification = Activator.CreateInstance<TNotification>();
            return notification;
        }
    }

    public class TextMessageNotification : Notification
    {
        public static TextMessageNotification Create(string phoneNumber, string content)
        {
            return new TextMessageNotification() { UserId = phoneNumber, Title = "SMS", Content = content};
        }
    }

    public class EmailNotification : Notification
    {
        public static EmailNotification Create(string emailAddress, string subject, string body)
        {
            return new EmailNotification() { UserId = emailAddress, Title = subject, Content = body };
        }
    }

    public class MailNotification : Notification
    {
    }

    public class EMessageNotification : Notification
    {
    }

    public class PushNotification : Notification
    {
    }
}