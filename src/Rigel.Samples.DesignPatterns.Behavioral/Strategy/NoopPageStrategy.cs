namespace Rigel.Samples.DesignPatterns.Behavioral.Strategy
{
    public class NoopPageStrategy : IPageBehaviorStrategy
    {
        public void Init()
        {
            // Display message invalid page state pleaser reload 
        }

        public void Save()
        {
            // Display message invalid page state pleaser reload 
        }

        public void Cancel()
        {
            // Display message invalid page state pleaser reload 
        }

        public void Delete()
        {
            // Display message invalid page state pleaser reload 
        }

        public void Calculate()
        {
            // Display message invalid page state pleaser reload 
        }
    }
}