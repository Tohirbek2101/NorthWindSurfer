using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindSurfer.Services
{
    public class ProductsService
    {
        public class Product
        {
            // Primary Key
            public int ProductID { get; set; }

            // Mahsulot nomi
            public string ProductName { get; set; }

            // Foreign Keys
            public int SupplierID { get; set; }
            public int CategoryID { get; set; }

        }

    }
}
