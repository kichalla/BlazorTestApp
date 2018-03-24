using BlazorTestApp.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorTestApp.Client.Services
{
    public interface IShoppingCartService
    {
        Task<IEnumerable<ShoppingCartItem>> GetItemsAsync();
    }
}