using BlazorTestApp.Client.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorTestApp.Client.Models
{
    public class ShoppingCartViewModel
    {
        private readonly Dictionary<string, SortOrder> _columnsSortOrder;
        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingCartViewModel(IShoppingCartService shoppingCartService)
        {
            // default sort order
            _columnsSortOrder = new Dictionary<string, SortOrder>()
            {
                { "Title", SortOrder.None },
                { "Units", SortOrder.None },
                { "UnitPrice", SortOrder.None },
                { "Total", SortOrder.None },
            };

            _shoppingCartService = shoppingCartService;
        }

        public async Task<IEnumerable<ShoppingCartItemViewModel>> GetShoppingCartItems()
        {
            var originalItems = await _shoppingCartService.GetItemsAsync();
        }

        public SortOrder GetSortOrder(string columnName)
        {
            if (_columnsSortOrder[columnName] == SortOrder.None ||
                _columnsSortOrder[columnName] == SortOrder.Descending)
            {
                _columnsSortOrder[columnName] = SortOrder.Ascending;
            }
            else
            {
                _columnsSortOrder[columnName] = SortOrder.Descending;
            }
            return _columnsSortOrder[columnName];
        }
    }
}
