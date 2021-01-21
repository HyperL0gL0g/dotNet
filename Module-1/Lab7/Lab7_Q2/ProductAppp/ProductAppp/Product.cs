using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppp
{
    class Product
    {
        // ProductNo, Name, Rate and Stock
       private int productNo;
       private string productName;
       private double rate;
       private int stock;

       public Product(int productNo,string productName, double rate, int stock)
        {
            this.productNo = productNo;
            this.productName = productName;
            this.rate = rate;
            this.stock = stock;
        }

        public int ProductNo
        {
            get
            {
                return productNo; 
            }
            set
            {
                productNo = value;
            }
        }

        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }

        public double Rate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = value;
            }
        }

        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                stock = value;
            }
        }



    }
}
