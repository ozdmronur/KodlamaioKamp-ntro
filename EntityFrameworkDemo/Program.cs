﻿namespace EntityFrameworkDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ADO.NET
            //Entity Framework --Bir ORM-Object relational mapping

            // GetAll();
            GetProductsByCategory(1);


        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();
            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);

            }
        }



        private static void GetProductsByCategory(int categoryId) 
        {
            NorthwindContext northwindContext = new NorthwindContext();
            var result = northwindContext.Products.Where(p=>p.CategoryId==categoryId);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}