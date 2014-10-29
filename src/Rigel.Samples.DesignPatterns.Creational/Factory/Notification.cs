using System;
using System.Dynamic;

namespace Rigel.Samples.DesignPatterns.Creational.Factory
{
    public class Notification : INotification
    {
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public static INotification Create(NotificationType type) 
        {
            Type dotNetType = typeof(InternalNotification);

            switch (type)
            {
                case NotificationType.Sms:
                    dotNetType = typeof (TextMessageNotification);
                    break;
                case NotificationType.Email:
                    dotNetType = typeof(EmailNotification);
                    break;
                case NotificationType.Internal:
                    dotNetType = typeof(InternalNotification);
                    break;
            }

            
            var notification = Activator.CreateInstance(dotNetType);

            return notification as INotification;
        }
    }
}