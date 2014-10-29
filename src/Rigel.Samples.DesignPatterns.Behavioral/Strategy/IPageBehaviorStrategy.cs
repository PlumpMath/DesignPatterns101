namespace Rigel.Samples.DesignPatterns.Behavioral.Strategy
{
    public interface IPageBehaviorStrategy
    {
        void Init();
        void Save();
        void Cancel();
        void Delete();
        void Calculate();
    }
}