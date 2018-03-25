using BlazorTestApp.Shared;

namespace BlazorTestApp.Client.Models
{
    public class ShoppingCartItemViewModel
    {
        private readonly ShoppingCartItem _shoppingCartItem;

        public ShoppingCartItemViewModel(ShoppingCartItem shoppingCartItem)
        {
            _shoppingCartItem = shoppingCartItem;
        }

        public int Id
        {
            get
            {
                return _shoppingCartItem.Id;
            }
        }

        public string Title
        {
            get
            {
                return _shoppingCartItem.Title;
            }
        }

        public string Description
        {
            get
            {
                return _shoppingCartItem.Description;
            }
        }

        public double UnitPrice
        {
            get
            {
                return _shoppingCartItem.UnitPrice;
            }
        }

        private int _units;
        public int Units
        {
            get
            {
                return _units;
            }
            set
            {
                _units = value;
            }
        }

        public bool HasChanged
        {
            get
            {
                return Units != _shoppingCartItem.Units;
            }
        }
    }
}
