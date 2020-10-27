using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using My_Rent.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Rent.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcPropertyContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcPropertyContext>>()))
            {
                // Look for any properties.
                if (context.Property.Any())
                {
                    return;   // DB has been seeded
                }

                context.Property.AddRange(
                    new Property
                    {
                        PropertyName = "Villa Maria",
                        Owner = "Maria Garcia",
                        Address = "Marijin prilaz 86",
                        PricePerNight = 275,
                        MaxCapacity = 12,
                        NumOfBathrooms = 3,
                        NumOfBedrooms = 6,
                        ShortDescription = "Best Villa around here!",
                        LongtDescription = "If you find yourself around Marijin prilaz, Villa Maria is a place for you and your friends. We are sure you will not be disappointed by our luxurious place made just for you. There are 3 bathrooms, 6 bedrooms, free WiFi, big pool, parking space, and a little gym.",
                        HasPool = true,
                        HasWiFi = true,
                        HasParking = true,
                        ImageThumbnailUrl = "https://images.unsplash.com/photo-1580587771525-78b9dba3b914?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1267&q=80",
                        ImageUrl = "https://cf.bstatic.com/images/hotel/max1024x768/237/237459583.jpg",
                        IsAvailable = true,
                        Category = "Villa"

                    },
                    new Property
                    {
                        PropertyName = "Apartment Karolina",
                        Owner = "Karolina Gulan",
                        Address = "Kornatska 86",
                        PricePerNight = 70,
                        MaxCapacity = 5,
                        NumOfBathrooms = 1,
                        NumOfBedrooms = 2,
                        ShortDescription = "Enjoy your stay at this lovely apartment.",
                        LongtDescription = " Situated in a nicest part of Croatia, just 100m from sea, we are sure you will enjoy your stay at our apartment. Local market is very close, post office, big supermarket and everything else you need...",
                        HasPool = false,
                        HasWiFi = true,
                        HasParking = true,
                        ImageThumbnailUrl = "https://images.unsplash.com/photo-1575540291670-8d3b26f7d327?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1410&q=80",
                        ImageUrl = "https://87stairs.com/wp-content/uploads/2019/10/DSC_0603-e1571992862772.jpg",
                        IsAvailable = true,
                        Category = "Apartment"

                    },
                    new Property
                    {
                        PropertyName = " Hotel room 1408",
                        Owner = "Dolphin Hotel",
                        Address = "New York",
                        PricePerNight = 2,
                        MaxCapacity = 1,
                        NumOfBathrooms = 1,
                        NumOfBedrooms = 1,
                        ShortDescription = "Enter.",
                        LongtDescription = " I'm sure you heard of our room. Room 1408, come in anytime, stay, enjoy. :) ",
                        HasPool = false,
                        HasWiFi = false,
                        HasParking = false,
                        ImageThumbnailUrl = "https://images.unsplash.com/photo-1584406445076-88e095f28f4c?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=675&q=80",
                        ImageUrl = "https://i.ytimg.com/vi/DmLn2l8WJOQ/maxresdefault.jpg",
                        IsAvailable = true,
                        Category = "Hotel Room"

                    },
                    new Property
                    {
                        PropertyName = " Luxury Bungalow Laguna",
                        Owner = "Petar Perić",
                        Address = "Zagrebačka cesta 23",
                        PricePerNight = 40,
                        MaxCapacity = 4,
                        NumOfBathrooms = 1,
                        NumOfBedrooms = 1,
                        ShortDescription = "Discover joy of staying in bungalows.",
                        LongtDescription = "Luxury bungalow Laguna is on a beautiful Croatian island. With a private pool, it is ideal for a group of young people.    ",
                        HasPool = true,
                        HasWiFi = false,
                        HasParking = true,
                        ImageThumbnailUrl = "https://images.unsplash.com/photo-1582719388123-e03e25d06d51?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1350&q=80",
                        ImageUrl = "https://www.vipholidaybooker.com/storage/app/uploads/public/5d9/f84/213/5d9f84213079c878343284.jpg",
                        IsAvailable = false,
                        Category = "Luxury Bungalow"

                    },
                     new Property
                     {
                         PropertyName = "Villa Jadran",
                         Owner = "Ivan Ivic",
                         Address = "Jadran 46",
                         PricePerNight = 90,
                         MaxCapacity = 10,
                         NumOfBathrooms = 4,
                         NumOfBedrooms = 5,
                         ShortDescription = "Adriaticas finest",
                         LongtDescription = "Luxury Villa on Jadran. You will love it when you see it.    ",
                         HasPool = true,
                         HasWiFi = true,
                         HasParking = true,
                         ImageThumbnailUrl = "https://images.unsplash.com/photo-1596036435403-cdb01867592d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1489&q=80",
                         ImageUrl = "https://www.vipholidaybooker.com/storage/app/uploads/public/5d9/f8e/3f0/thumb_7900_800_533_0_0_crop.jpg",
                         IsAvailable = true,
                         Category = "Villa"

                     },
                      new Property
                      {
                          PropertyName = " Luxury Bungalow Sand",
                          Owner = "Ivo Jankić",
                          Address = "More more 104",
                          PricePerNight = 25,
                          MaxCapacity = 4,
                          NumOfBathrooms = 1,
                          NumOfBedrooms = 1,
                          ShortDescription = "Pretty bungalows.",
                          LongtDescription = "Luxury bungalow Sand is on a beautiful Croatian island. It has everything you need and want.   ",
                          HasPool = true,
                          HasWiFi = true,
                          HasParking = true,
                          ImageThumbnailUrl = "https://images.unsplash.com/photo-1560106360-c9826869f0fc?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=675&q=80",
                          ImageUrl = "https://www.propertyturkey.com/uploads/realestate/larg/ortakent_villa_2_2.jpg",
                          IsAvailable = true,
                          Category = "Luxury Bungalow"

                      },
                       new Property
                       {
                           PropertyName = " Hotel room SweetDreams",
                           Owner = "Zagreb Hotel",
                           Address = "Zagreb 888",
                           PricePerNight = 200,
                           MaxCapacity = 2,
                           NumOfBathrooms = 1,
                           NumOfBedrooms = 1,
                           ShortDescription = "Can't get better than this.",
                           LongtDescription = " In our hotel room SweetDreams you will enjoy your night rest, or... Come and see for yourself. ",
                           HasPool = false,
                           HasWiFi = true,
                           HasParking = true,
                           ImageThumbnailUrl = "https://images.unsplash.com/photo-1564078516393-cf04bd966897?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80",
                           ImageUrl = "https://images.unsplash.com/photo-1574118140238-fd751a59eabb?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1350&q=80",
                           IsAvailable = true,
                           Category = "Hotel Room"

                       }

                 );
                context.SaveChanges();

            }
        }
    }

}
