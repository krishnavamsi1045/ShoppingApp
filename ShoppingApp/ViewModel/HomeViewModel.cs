using CommunityToolkit.Mvvm.ComponentModel;
using ShoppingApp.Models;
using ShoppingApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.ViewModel
{
    public partial class HomeViewModel:ObservableObject

    {
        private readonly CategoryServices _categoryService;
        public HomeViewModel(CategoryServices categoryServices)
        {
            _categoryService = categoryServices;
            Categories = new ObservableCollection<Category>();

        }
        public ObservableCollection<Category> Categories { get; set; }

        public async Task IntializeAsync()
        {
            foreach(var category in await _categoryService.GetMainCategoriesAsync())
            {
                Categories.Add(category);
            }
        }
    }
}
