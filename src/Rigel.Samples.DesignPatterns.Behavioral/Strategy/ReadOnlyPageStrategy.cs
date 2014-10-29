namespace Rigel.Samples.DesignPatterns.Behavioral.Strategy
{
    public class ReadOnlyPageStrategy : IPageBehaviorStrategy
    {
        public void Init()
        {
            // Load all data 
        }

        public void Save()
        {
            // Nothing to save 
        }

        public void Cancel()
        {
            // Nothing to cancel 
        }

        public void Delete()
        {
            // Delete this record 
        }

        public void Calculate()
        {
            // Just reload the screen 
        }
    }
}