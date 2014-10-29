namespace Rigel.Samples.DesignPatterns.Behavioral.Strategy
{
    public interface IPageBehaviorStrategyFactory
    {
        IPageBehaviorStrategy Create(PageState state);
    }
}