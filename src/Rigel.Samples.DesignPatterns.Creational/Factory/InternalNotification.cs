namespace Rigel.Samples.DesignPatterns.Creational.Factory
{
    public class InternalNotification : Notification
    {
        public static InternalNotification Create(int userId, string title, string content)
        {
            return new InternalNotification() { UserId = userId.ToString(), Title = title, Content = content };
        }
    }
}