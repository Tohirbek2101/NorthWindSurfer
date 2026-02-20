using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindSurfer.Services
{
    public class OrdersService
    {
        public class Order
        {
            // Primary Key
            public int OrderID { get; set; }

            // Foreign Keys
            public string CustomerID { get; set; }
            public int EmployeeID { get; set; }

        }

    }
}
