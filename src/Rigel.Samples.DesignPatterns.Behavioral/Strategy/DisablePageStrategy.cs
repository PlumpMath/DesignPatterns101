namespace Rigel.Samples.DesignPatterns.Behavioral.Strategy
{
    public class DisablePageStrategy : IPageBehaviorStrategy
    {
        public void Init()
        {
            // Load all data 
        }

        public void Save()
        {
            // Display message that save is not allow 
        }

        public void Cancel()
        {
            // does nothing 
        }

        public void Delete()
        {
            // Display message that delete is not allow 
        }

        public void Calculate()
        {
            // Display message that calculate is not allow 
        }
    }
}