using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProductAppp
{
    class ProductComparer:IComparer
    {
        int IComparer.Compare(Object o1,Object o2)
        {
            Product product1 = o1 as Product;
            Product product2 = o2 as Product;
            return product1.ProductNo.CompareTo(product2.ProductNo);
        }
    }
}
