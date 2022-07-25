using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager =  new CustomerManager();
            //customerManager.Add();


            //ProductManager productManager = new ProductManager();

            //productManager.City  = "van";
            //productManager.Id = 65;
            //productManager.Name = "yusuf";
            //productManager.SurName = "ebinc";

            //Console.WriteLine(productManager.Name);


            //string a= "bir", b="iki";

            //var result = a ==b ? "bunların ikisi aynı " : "aynı degil";

            //Console.WriteLine(result);
            //Console.WriteLine("deneme");

            Product product1 = new Product();
            Product product2 = new Product();
            Product product3 = new Product();

            product1.ProductName = "Book";
            product1.ProductPrice = 8963;
            product1.ProductStock = true;
            product1.ProductDetail = "action";

            product2.ProductName = "Book";
            product2.ProductPrice = 5420;
            product2.ProductStock = false;
            product2.ProductDetail = "science fiction";


            product3.ProductName = "Book";
            product3.ProductPrice = 3543;
            product3.ProductStock = true;
            product3.ProductDetail = "adventure";
           


            Product[] products = new Product[] {product1,product2,product3 };

            foreach (var values in products)
            {
                Console.WriteLine(values.ProductName+ " " + values.ProductDetail + " "+ values.ProductPrice.ToString(), 
                    values.ProductStock.ToString());
            }
            Console.WriteLine("---------------------------------------------------------------------");
           
            
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName +  products[i].ProductDetail + 
                  products[i].ProductPrice+products[i].ProductStock);
            }


            Console.WriteLine("---------------------------------------------------------------------");
            int j = 0;
            while (j < products.Length) 
            {
                Console.WriteLine(products[j].ProductName + products[j].ProductDetail +
                 products[j].ProductPrice + products[j].ProductStock);
                j++;
            
            }


            BasketManager basketManager = new  BasketManager();

            basketManager.add(product1);

            Console.ReadLine();
            
        }
    }


    
}
