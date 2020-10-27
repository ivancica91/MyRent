using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace My_Rent.Models
{
    public class PropertyCategoryViewModel
    {
        public List<Property> Properties { get; set; }
        public SelectList Categories { get; set; }
        public string PropertyCategory { get; set; }
        public string SearchString { get; set; }

    }
}
