using ShoppingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Services
{
    public  class CategoryServices
    {
        private IEnumerable<Category>? _categories;
        public async ValueTask<IEnumerable<Category>> GetCategoriesAsync()
        {
            if(_categories is null)
            {
                var categories = new List<Category>();
                var fruits = new List<Category>
                {
                    new (1,"Fruits",0,"dotnet_bot.svg"),
                    new (2,"SesonedFruits",1,"download.jpeg"),
                    new(3,"ExoticFruits",1,"download.jpeg")
                };
                categories.AddRange(fruits);
                var vegetables = new List<Category>
                {
                     new (1,"Fruits",0,"download.jpeg"),
                    new (2,"SesonedFruits",1,"download.jpeg"),
                    new(3,"ExoticFruits",1,"download.jpeg")
                };
                categories.AddRange(vegetables);
                _categories= categories;
            }
            return _categories;
        }
        public async ValueTask<IEnumerable<Category>> GetMainCategoriesAsync() =>
            (await GetCategoriesAsync()).Where(c=> c.ParentId ==0)
            ;
    }
}
