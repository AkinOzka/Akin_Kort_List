using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vraag_List.Models;

namespace Vraag_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { Merk = "Fanta", Naam=  "Lemon", Volume=  "250 ml", Price=  1.25m };
            Product product2 = new Product() { Merk = "Coca-Cola", Naam = "Zero", Volume = "1000ml", Price = 3.30m };
            Product product3 = new Product() { Merk = "Sprite", Naam = "Standart", Volume = "250 ml", Price = 1.25m };
            Product product4 = new Product() { Merk = "Ice-Tea", Naam = "Lipton", Volume = "250 ml", Price = 1.25m };
            Product product5 = new Product() { Merk = "Coca-Cola", Naam = "Light", Volume = "1000ml", Price = 1.25m };
            Product product6 = new Product() { Merk = "Fanta", Naam = "Zero", Volume = "250 ml", Price = 3.30m };
            Product product7 = new Product() { Merk = "Sprite", Naam = "Zero", Volume = "1000ml", Price = 3.30m };
            Product product8 = new Product() { Merk = "Coca-cola", Naam = "Original", Volume = "1000ml", Price = 3.30m };
            Product product9 = new Product() { Merk = "Fanta", Naam = "Lemon", Volume = "250 ml", Price = 1.25m };
            Product product10 =new Product() { Merk = "Coca-Cola", Naam = "Zero", Volume = "1000ml", Price = 3.30m };

            var productList=new List<Product>();
            productList.Add(product1);
            productList.Add(product2);
            productList.Add(product3);
            productList.Add(product4);
            productList.Add(product5);
            productList.Add(product6);
            productList.Add(product7);
            productList.Add(product8);
            productList.Add(product9);
            productList.Add(product10);

            foreach (var item in productList)
            {
                Console.WriteLine(item);
            }

            Product product = new Product();
            product.GetCode();
            productList.Sort();
            productList.Reverse();

            // Product FindTopExpensiveProduct()
            //{
            //    return product.GetCode().OrderByDescending(x => x.Price).FirstOrDefault();
            //}
           
        }
        
    }
}
