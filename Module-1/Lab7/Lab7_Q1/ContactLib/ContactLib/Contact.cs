using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactLib
{
    public class Contact
    {
        private int contactNo;
        private string contactName;
        private string cellNo;

        public Contact(int contactNo, string contactName, string cellNo)
        {
            this.contactNo = contactNo;
            this.contactName = contactName;
            this.cellNo = cellNo;
        }
        public int ContactNo
        {
            get
            {
                return contactNo;
            }
            set
            {
                contactNo = value;
            }
        }

        public string ContactName
        {
            get
            {
                return contactName;
            }
            set
            {
                contactName = value;
            }
        }

        public string CellNo
        {
            get
            {
                return cellNo;
            }
            set
            {
                cellNo = value;
            }
        }
    }
}
