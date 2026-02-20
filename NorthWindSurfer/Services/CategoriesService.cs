using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindSurfer.Services
{
    public class CategoriesService
    {

        public class Category
        {
            // Primary Key
            public int CategoryID { get; set; }

            // Category nomi
            public string CategoryName { get; set; }

            // Category haqida qisqacha tavsif
            public string Description { get; set; }

        }

    }
}
