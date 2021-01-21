using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ProductAppp
{
    class Program
    {
        static ArrayList productList = new ArrayList();

        static void addNewProduct(Product product)
        {
            productList.Add(product);
        }

        static Product search(int productNo)
        {
            foreach(Object o in productList)
            {
                Product product = o as Product;
                if(product!=null && product.ProductNo == productNo)
                {
                    Console.WriteLine("showing the details: \n-----------------------------------------");
                    Console.WriteLine("Product Id: " + product.ProductNo);
                    Console.WriteLine("Product Name: " + product.ProductName);
                    Console.WriteLine("rate: " + product.Rate);
                    Console.WriteLine("stock: " + product.Stock);
                    return product;
                }
            }
            Console.WriteLine("Product doesnot exits");
            return null;
        }

        static void delete(int productNo)
        {
            Product product = search(productNo);
            if (product == null)
            {
                Console.WriteLine("The product doesn't exist");
                return;
            }

            productList.Remove(product);
        }

        static void saveProduct()
        {
            productList.Sort(new ProductComparer());
        }

        static void displayList()
        {
            foreach(Object o in productList)
            {
                Product product = o as Product;
                if (product != null)
                {
                    Console.WriteLine("Details are \n--------------------------------------");
                    Console.WriteLine("Product Id: " + product.ProductNo);
                    Console.WriteLine("Product Name: " + product.ProductName);
                    Console.WriteLine("rate: " + product.Rate);
                    Console.WriteLine("stock: " + product.Stock);
                }
            }
        }
        static void Main(string[] args)
        {
            int choice;
            char cont;
            do
            {
                Console.WriteLine("Choose 1) Add new product 2) Delete product 3) Search the prodcut 4) Save the product 5)display list 0)Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0: return;
                    case 1:
                        Console.WriteLine("Enter Product Details: ");
                        Console.WriteLine("Enter product no");
                        int productNo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter product Name");
                        string productName = Console.ReadLine();

                        Console.WriteLine("Enter the product rate");
                        double rate = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter the stock");
                        int stock = Convert.ToInt32(Console.ReadLine());

                        addNewProduct(new Product(productNo,productName,rate,stock));
                        break;
                    case 2:
                        Console.WriteLine("Enter the product no which you want to delete");
                        int productNum = Convert.ToInt32(Console.ReadLine());
                        delete(productNum);
                        break;
                    case 3:
                        Console.WriteLine("Enter the product no");
                        int productNo1 = Convert.ToInt32(Console.ReadLine());
                        search(productNo1);
                        break;
                    case 4:
                        saveProduct();
                        break;
                    case 5:
                        displayList();
                        break;

                }
                Console.WriteLine("Wanna Continue? y/n");
                cont = Convert.ToChar(Console.ReadLine());
            } while (cont=='y');
            
        }
    }
}
