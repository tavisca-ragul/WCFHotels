using HotelClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelClient
{
    class Home
    {
        public void Display()
        {
            var sc = new HotelServiceClient("BasicHttpBinding_IHotelService");
            Console.WriteLine("\n1.Get All Hotels\n2.Search Hotel by ID\nEnter your choice");
            var choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        try
                        {
                            List<Hotel> hotels = sc.GetAllHotels().ToList();
                            Console.WriteLine("Hotels");
                            foreach (var hotel in hotels)
                            {
                                Console.WriteLine($"\nID:{hotel.ID}\nName:{hotel.Name}\nAddress:{hotel.Address}\nStar Rating:{hotel.StarRating}");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Internal Server error");
                        }
                        Display();
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter ID:");
                        var id = int.Parse(Console.ReadLine());
                        try
                        {
                            var hotel = sc.GetHotelById(id);
                            Console.WriteLine($"\nID:{hotel.ID}\nName:{hotel.Name}\nAddress:{hotel.Address}\nStar Rating:{hotel.StarRating}");
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Internal Server error");
                        }
                        Display();
                        break;
                    }
            }
        }
    }
}