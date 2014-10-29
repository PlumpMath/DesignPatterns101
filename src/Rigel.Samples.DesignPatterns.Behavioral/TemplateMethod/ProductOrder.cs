
namespace Rigel.Samples.DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class ProductOrder
    {
        protected IInventoryService _inventory;
        protected IShippingService _shipping;
        protected IAccoutingService _accounting;

        protected bool _isPicked;
        protected bool _isPacked;
        protected bool _isShiped;
        protected bool _isInvoiced;
        protected bool _isClosed;

        public virtual void Create()
        {
        }

        public virtual void Pick()
        {
            if (_inventory.InStock())
            {
                _isPicked = true;
            }
        }

        public virtual void Pack()
        {
        }

        public virtual void Ship()
        {
        }

        public virtual void Invoice()
        {
        }

        public virtual void Close()
        {
        }
    }
}