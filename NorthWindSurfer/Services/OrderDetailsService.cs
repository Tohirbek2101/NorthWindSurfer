using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindSurfer.Services
{
    public class OrderDetailsService
    {
        public class OrderDetail
        {
            // Composite Primary Key
            public int OrderID { get; set; }
            public int ProductID { get; set; }

            // Qo‘shimcha ma’lumotlar
            public decimal UnitPrice { get; set; }
            public short Quantity { get; set; }
            public float Discount { get; set; }
        }

    }
}
