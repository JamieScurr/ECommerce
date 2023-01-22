using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public static class DbInitialiser //static does not require instance
    {
        public static void Initialise(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Bing Chilling",
                    Description =
                        "A lightweight cream t-shirt perfect for chilling out.",
                    Price = 25,
                    PictureUrl = "/images/products/bc.png",
                    Type = "T-Shirt",
                    QuantityInStock = 5
                },

                  new Product
                {
                    Name = "Best Knitting Mom Ever",
                    Description =
                        "Show some appreciation for you mom and her superb knitting skills!",
                    Price = 25,
                    PictureUrl = "/images/products/bkme.jpg",
                    Type = "T-Shirt",
                    QuantityInStock = 5
                },

            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();

        }
    }
}