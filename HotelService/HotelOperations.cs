using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HotelService
{
    class HotelOperations : IHotelOperations
    {
        public List<HotelData> GetAllHotels()
        {
            List<HotelData> hotelList = new List<HotelData>();
            var path = @"C:\Users\asood\Desktop\WCFHotel\HotelService\HotelList.json";
            using (StreamReader streamReader = new StreamReader(path))
            {
                  var readData = streamReader.ReadToEnd();
                hotelList = JsonConvert.DeserializeObject<List<HotelData>>(readData);
            }
            return hotelList;
        }

        public HotelData GetHotelById(int id)
        {
            var hotel = GetAllHotels().Find(x => x.ID == id);
            return hotel;
        }
    }
}
