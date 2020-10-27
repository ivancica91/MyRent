using Abp.AutoMapper;
using My_Rent.Models;
using System.ComponentModel.DataAnnotations;

namespace My_Rent.Views.Models
{
    
    public class CreatePropertyViewModel
    {

        [Display(Name = "Property Name")]
        [Required]
        public string PropertyName { get; set; }

        [Required]
        public string Owner { get; set; }

        [Required]
        public string Address { get; set; }

        [Display(Name = "Price per Night")]
        [Required]
        public int PricePerNight { get; set; }

        [Display(Name = "Capacity")]
        [Required]
        public int MaxCapacity { get; set; }

        [Display(Name = "Bedrooms")]
        [Required]
        public int NumOfBedrooms { get; set; }

        [Display(Name = "Bathrooms")]
        [Required]
        public int NumOfBathrooms { get; set; }

        [Display(Name = "About")]
        [Required]
        public string ShortDescription { get; set; }

        [Display(Name = "Details")]
        [Required]
        public string LongtDescription { get; set; }

        [Display(Name = "Pool")]
        [Required]
        public bool HasPool { get; set; }

        [Display(Name = "WiFi")]
        [Required]
        public bool HasWiFi { get; set; }

        [Display(Name = "Parking")]
        [Required]
        public bool HasParking { get; set; }

        [Display(Name = "Thumbnail")]
        [Required]
        public string ImageThumbnailUrl { get; set; }

        [Display(Name = "Image")]
        [Required]
        public string ImageUrl { get; set; }

        [Display(Name = "Availability")]
        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        public string Category { get; set; }
    }
}
