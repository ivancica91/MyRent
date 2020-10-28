using System.ComponentModel.DataAnnotations;

namespace My_Rent.Views.Models
{
    public class UpdatePropertyViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Property Name")]
        public string PropertyName { get; set; }

        public string Owner { get; set; }

        public string Address { get; set; }

        [Display(Name = "Price per Night")]
        public int PricePerNight { get; set; }

        [Display(Name = "Capacity")]
        public int MaxCapacity { get; set; }

        [Display(Name = "Bedrooms")]
        public int NumOfBedrooms { get; set; }

        [Display(Name = "Bathrooms")]
        public int NumOfBathrooms { get; set; }

        [Display(Name = "About")]
        public string ShortDescription { get; set; }

        [Display(Name = "Details")]
        public string LongtDescription { get; set; }

        [Display(Name = "Pool")]
        public bool HasPool { get; set; }

        [Display(Name = "WiFi")]
        public bool HasWiFi { get; set; }

        [Display(Name = "Parking")]
        public bool HasParking { get; set; }

        [Display(Name = "Image")]
        public string ImageThumbnailUrl { get; set; }

        [Display(Name = "Image_2")]
        public string ImageUrl { get; set; }

        [Display(Name = "Availability")]
        public bool IsAvailable { get; set; }

        public string Category { get; set; }
    }
}
