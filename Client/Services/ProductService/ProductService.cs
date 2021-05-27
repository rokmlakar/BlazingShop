using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProducts()
        {
            Products = new List<Product>
           {
               new Product
               {
                    Id = 1,
                    CategoryId = 1,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "The hitchhikers guide to the galaxy lorem ipsum dolor sit amet loremus ipsumussus direkturus defoutufs ",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
               },
               new Product
                {
                    Id = 2,
                    CategoryId = 3,
                    Title = "Half life 2",
                    Description = "2004 FPS shooter published by valve",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
                },
               new Product
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "Half life 3",
                    Description = "2004 FPS shooter published by valve",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
               },
               new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "Lahf hife",
                    Description = "2004 FPS shooter published by valve",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
               },
               new Product
                {
                    Id = 5,
                    CategoryId = 1,
                    Title = "Pola života",
                    Description = "2004 FPS shooter published by valve",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
               },
               new Product
                 {
                    Id = 6,
                    CategoryId = 3,
                    Title = "Half of a life 5",
                    Description = "2004 FPS shooter published by valve",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
               },
               new Product
                  {
                    Id = 7,
                    CategoryId = 2,
                    Title = "Life Half ",
                    Description = "2004 FPS shooter published by valve",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
               },
               new Product
                   {
                    Id = 8,
                    CategoryId = 1,
                    Title = "H4LF L1F3",
                    Description = "2004 FPS shooter published by valve",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
               },
               new Product
                    {
                    Id = 9,
                    CategoryId = 1,
                    Title = "Big BOuk",
                    Description = "2004 FPS shooter published by valve",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
               },
           };
        }
    }
}
