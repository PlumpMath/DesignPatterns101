
namespace Rigel.Samples.DesignPatterns.Behavioral.Strategy
{
    public class WebFormPage 
    {
        private PageState _state;
        private IPageBehaviorStrategy _strategy;
        private IPageBehaviorStrategyFactory _factory;

        public WebFormPage()
        {
            _state = PageState.ReadOnly;
            _factory = new PageBehaviorStrategyFactory();
            ChangePageState(_state);
        }

        public void OnLoad()
        {
            if (IsSystemOffline())
            {
                ChangePageState(PageState.Disable);
            }
            else
            {
                ChangePageState(PageState.ReadOnly);
            }
            
            _strategy.Init();
        }

        public void OnEdit()
        {
            ChangePageState(PageState.Edit); 
        }

        public void OnCancel()
        {
            _strategy.Cancel();
            ChangePageState(PageState.ReadOnly);
        }
        
        public void OnSave()
        {
            _strategy.Save();
        }
        
        public void Delete()
        {
            _strategy.Delete();
        }

        public void Calculate()
        {
            _strategy.Calculate();
        }

        public void ChangePageState(PageState state)
        {
            _state = state;
            _strategy = _factory.Create(_state);
        }

        public bool IsSystemOffline()
        {
            return false;
        }
    }
}

