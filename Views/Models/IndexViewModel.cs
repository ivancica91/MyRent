namespace My_Rent.Models
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using My_Rent.Views.Models;
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public List<PropertyViewModel> Properties { get; set; }
        public SelectList Categories { get; set; }
        public string PropertyCategory { get; set; }
        public string SearchString { get; set; }

    }
}
