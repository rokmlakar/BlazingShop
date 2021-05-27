using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>();

        public void LoadCategories()
        {
            Categories = new List<Category>
            {
                new Category { Id = 1, Name = "Books", Url = "books", Icon = "book"},
                new Category { Id = 2, Name = "Electronics", Url = "electronics", Icon = "camera-slr"},
                new Category { Id = 3, Name = "Games", Url = "games", Icon = "aperture"}
            };
        }
    }
}
