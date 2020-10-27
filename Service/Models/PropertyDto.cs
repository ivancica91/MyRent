namespace My_Rent.Service.Models
{
    public class PropertyDto
    {
        public int Id { get; set; }

        public string PropertyName { get; set; }

        public string Owner { get; set; }

        public string Address { get; set; }

        public int PricePerNight { get; set; }

        public int MaxCapacity { get; set; }

        public int NumOfBedrooms { get; set; }

        public int NumOfBathrooms { get; set; }

        public string ShortDescription { get; set; }

        public string LongtDescription { get; set; }

        public bool HasPool { get; set; }

        public bool HasWiFi { get; set; }

        public bool HasParking { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public string ImageUrl { get; set; }

        public bool IsAvailable { get; set; }

        public string Category { get; set; }
    }
}
