using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorTestApp.Shared;
using Microsoft.AspNetCore.Blazor;

namespace BlazorTestApp.Client.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly HttpClient _httpClient;

        public ShoppingCartService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<IEnumerable<ShoppingCartItem>> GetItemsAsync()
        {
            return _httpClient.GetJsonAsync<IEnumerable<ShoppingCartItem>>("/api/shoppingcart");
        }
    }
}
