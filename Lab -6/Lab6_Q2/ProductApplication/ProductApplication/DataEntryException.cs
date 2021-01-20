using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication
{
    class DataEntryException:ApplicationException
    {
        internal DataEntryException() : base()
        {
            // more information
        }

        internal DataEntryException(String message): base(message)
        {
            //more information
        }
    }
}
