using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication
{
    class ProductTest
    {
         static ProductMock getProductDetails()
         {
            Console.WriteLine("Enter the Product Details");
            Console.WriteLine("Enter Product Id");
            int productID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Product Price");
            double price = Convert.ToInt32(Console.ReadLine());

            ProductMock productMock = new ProductMock(productID,name,price);
            return productMock;
         }

        static void display(ProductMock product)
        {
            Console.WriteLine("Products Detail: \n --------------------------------------------");

            Console.WriteLine("Product ID: " + product.productID);
            Console.WriteLine("Product Name: " + product.productName);
            Console.WriteLine("Product Price: " + product.price);
        }
        static void Main(string[] args)
        {
            try
            {
                ProductMock product1 = getProductDetails();
                display(product1);
            }
            catch(DataEntryException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

    }
}
