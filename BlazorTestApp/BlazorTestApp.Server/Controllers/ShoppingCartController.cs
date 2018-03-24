using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorTestApp.Server.Controllers
{
    [Route("api/[controller]")]
    public class ShoppingCartController : Controller
    {
        public IEnumerable<ShoppingCartItem> Get()
        {
            return new[]
            {
                new ShoppingCartItem()
                {
                     Id = 1,
                     Title = "Crayons",
                     UnitPrice = 10.50,
                     Units = 1,
                },
                new ShoppingCartItem()
                {
                     Id = 2,
                     Title = "Samsung Galaxy J7 Pro",
                     UnitPrice = 299.00,
                     Units = 1,
                },
                new ShoppingCartItem()
                {
                     Id = 3,
                     Title = "SanDisk USB 2.0 Drive",
                     UnitPrice = 30.00,
                     Units = 1,
                },
                new ShoppingCartItem()
                {
                     Id = 4,
                     Title = "Phone charger",
                     UnitPrice = 10.00,
                     Units = 2,
                },
            };
        }
    }
}
