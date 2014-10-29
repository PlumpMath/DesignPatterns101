namespace Rigel.Samples.DesignPatterns.Behavioral.Strategy
{
    public class PageBehaviorStrategyFactory : IPageBehaviorStrategyFactory
    {
        public IPageBehaviorStrategy Create(PageState state)
        {
            switch (state)
            {
                case PageState.ReadOnly:
                    return new ReadOnlyPageStrategy();
                   
                case PageState.Edit:
                    return new EditPageStrategy();

                case PageState.Disable:
                    return new DisablePageStrategy();
            }

            return new NoopPageStrategy();
        }
    }
}