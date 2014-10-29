namespace Rigel.Samples.DesignPatterns.Creational.Factory
{
    public class TextMessageNotification : Notification
    {
        public static TextMessageNotification Create(string phoneNumber, string content)
        {
            return new TextMessageNotification() { UserId = phoneNumber, Title = "SMS", Content = content};
        }
    }
}