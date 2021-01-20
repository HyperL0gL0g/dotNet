using System;
//priducts accept some details and print them(using boxing)
namespace Lab2_Ques4
{
    class Program
    {
        static void Main(string[] args)
        {

            String ProductID, ProductName, Price, Quantity;
            double amountPayable;
            Console.WriteLine("Enter Product ID");
            ProductID = Console.ReadLine();
            Console.WriteLine("Enter Product Name");
            ProductName = Console.ReadLine();
            Console.WriteLine("Enter Product Price");
            Price = Console.ReadLine();
            Console.WriteLine("Enter Product quantity");
            Quantity = Console.ReadLine();

            double price = Convert.ToDouble(Price);
            int quant = Convert.ToInt32(Quantity);
            amountPayable = price * quant;

            Console.WriteLine("Product Details");
            Console.WriteLine("Product ID : {0}", ProductID);
            Console.WriteLine("Product Name : {0}", ProductName);
            Console.WriteLine("Price : {0}", price);
            Console.WriteLine("Quantity : {0}", quant);
            Console.WriteLine("Amount Payable : {0}", amountPayable);
        }
    }
}
