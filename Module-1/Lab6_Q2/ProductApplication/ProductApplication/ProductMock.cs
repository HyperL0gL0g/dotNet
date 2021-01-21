using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication
{
    class ProductMock 
    {
        internal int productID;
        internal string productName;
        internal double price;

        internal ProductMock(int productID,string productName,double price)
        {
            if (productID <= 0)
                throw new DataEntryException("Product ID must be greater than zero");
            else
                this.productID = productID;
            if (productName == "")
                throw new DataEntryException("Product name can't be blank");
            else if (!productName.All(Char.IsLetterOrDigit))
                throw new DataEntryException("Product Name should have alphabets and numbers only");
            else
                this.productName = productName;
            if (price <= 0)
                throw new DataEntryException("Price must be greater than zero");
            else
                this.price = price;
        }

        internal int ProductID
        {
            get
            {
                return productID;
            }
            set
            {
                if (value <= 0)
                    throw new DataEntryException("Product ID must be greater than zero");
                else
                    this.productID = value;
            }
        }

        internal string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                if (value == "")
                    throw new DataEntryException("Product name can't be blank");
                else if (!productName.All(Char.IsLetterOrDigit))
                    throw new DataEntryException("Product Name should have alphabets and numbers only");
                else
                    this.productName = value;
            }
        }

        internal double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value <= 0)
                    throw new DataEntryException("Price must be greater than zero");
                else
                    this.price = value;
            }
        }
    }
}
