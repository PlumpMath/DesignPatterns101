namespace Rigel.Samples.DesignPatterns.Creational.Factory
{
    public interface INotification
    {
        string UserId { get; }
        string Title { get;  }
        string Content { get; }
    }
}