namespace Rigel.Samples.DesignPatterns.Behavioral.TemplateMethod
{
    public class GoldClientOrder : ProductOrder
    {
        private IInventoryService _priorityInventory;

        public override void Pick()
        {
            
        }

        public override void Pack()
        {
            base.Pack();
        }

        public override void Invoice()
        {
            base.Invoice();
        }
    }
}