namespace Rigel.Samples.DesignPatterns.Behavioral.Strategy
{
    public class EditPageStrategy : IPageBehaviorStrategy
    {
        public void Init()
        {
            // Nothing to init 
        }

        public void Save()
        {
            // Save all data
        }

        public void Cancel()
        {
            // Reload the all data 
        }

        public void Delete()
        {
            // Can't delete while in edit more 
        }

        public void Calculate()
        {
            // Recalculate using screen values 
        }
    }
}