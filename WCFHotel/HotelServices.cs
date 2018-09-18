using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace WCFHotel
{
    class HotelServices : IHotelService
    {
        public List<Hotel> GetAllHotels()
        {
            using (StreamReader hotelsFile = new StreamReader("../../../WCFHotel/hotels.json"))
            {
                string hotelsData = hotelsFile.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Hotel>>(hotelsData);
            }
        }

        public Hotel GetHotelById(int id)
        {
            using (StreamReader hotelsFile = new StreamReader("../../../WCFHotel/hotels.json"))
            {
                string hotelsData = hotelsFile.ReadToEnd();
                List<Hotel> hotels = JsonConvert.DeserializeObject<List<Hotel>>(hotelsData);
                Hotel hotel = hotels.SingleOrDefault(h => h.ID == id);
                if (hotel == null)
                    throw new InvalidOperationException("Hotel is not found");
                return hotel;
            }
        }
    }
}