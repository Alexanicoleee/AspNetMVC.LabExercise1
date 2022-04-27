using AspNetMVC.LabExercise1.Models;
using System.Collections.Generic;

namespace AspNetMVC.LabExercise1.Services
{
    public class ProductService
    {
        private List<Product> products;

        public ProductService()
        {
            products = new List<Product>();

            products.Add(new Product()
            {
                Id = 1,
                Name = "Air Jordan 1",
                Description = "The Air Jordan 1 High debuted in 1985 as the first signature sneaker developed by Nike for Michael Jordan",
                Quantity = 5,
                Price = 7_800M
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Air Jordan 2",
                Description = "AIR JORDAN 2 Michael Jordan's second signature model, the Air Jordan 2 first debuted in November 1986, and was designed by Bruce Killgore/Peter Moore.",
                Quantity = 9,
                Price = 10_900M
            });
            products.Add(new Product()
            {
                Id = 3,
                Name = "Air Jordan 3",
                Description = "The Air Jordan 3 is Michael Jordan's third signature basketball shoe and remains as one of the most sought after sneakers to-date",
                Quantity = 10,
                Price = 13_800M
            });
            products.Add(new Product()
            {
                Id = 4,
                Name = "Air Jordan 4",
                Description = "It features lightweight netting and plastic wings on the upper as well as visible Max Air.",
                Quantity = 12,
                Price = 15_800M
            });
            products.Add(new Product()
            {
                Id = 5,
                Name = "Air Jordan 5",
                Description = "The Air Jordan 5 was designed by Tinker Hatfield and made its debut in 1990.",
                Quantity = 15,
                Price = 20_800M
            });
        }

        public decimal GetGrandTotal()
        {
            decimal grandTotal = 0;
            foreach (Product product in products)
            {
                grandTotal += product.TotalAmount;
            }
            return grandTotal;
        }

        public List<Product> GetCatalog()
        {
            return products;
        }
    }
}
