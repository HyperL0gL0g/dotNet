using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Exceptions
{
    public class EmployeeAppException: ApplicationException
    {
        public EmployeeAppException() : base()
        {
            //
        }

        public EmployeeAppException(String message) : base(message)
        {
            //
        }

        public EmployeeAppException(String message,Exception innerException): base(message, innerException)
        {

        }
    }
}
