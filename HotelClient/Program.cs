using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelClient.HotelServiceReference;
namespace HotelClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelOperationsClient hotelOperationsClient = new HotelOperationsClient("BasicHttpBinding_IHotelOperations");

            Console.WriteLine("Welcome User");
            while (true)
            {
                Console.WriteLine("1. Get All Hotels");
                Console.WriteLine("2. Get Hotel By Id");
                Console.WriteLine("3. Exit");
                int choice;
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        Console.Write("Hotel Id\t");
                        Console.Write("Hotel Name\t");
                        Console.Write("Hotel Address\t");
                        Console.WriteLine("Hotel Ratings\t");
                        foreach (HotelData hotel in hotelOperationsClient.GetAllHotels())
                        {
                            Console.Write(hotel.ID+"\t\t");
                            Console.Write(hotel.Name + "\t\t");
                            Console.Write(hotel.Address + "\t\t");
                            Console.WriteLine(hotel.Rating);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Hotel Id");
                        int hotelId;
                        int.TryParse(Console.ReadLine(), out hotelId);
                        Console.Write("Hotel Id\t");
                        Console.Write("Hotel Name\t");
                        Console.Write("Hotel Address\t");
                        Console.WriteLine("Hotel Ratings\t");
                        HotelData hotelData = hotelOperationsClient.GetHotelById(hotelId);
                        if (hotelData != null)
                        {
                            Console.Write(hotelData.ID + "\t\t");
                            Console.Write(hotelData.Name + "\t\t");
                            Console.Write(hotelData.Address + "\t\t");
                            Console.WriteLine(hotelData.Rating);
                        }
                        else
                        {
                            Console.WriteLine("Hotel Id doesn't exist");
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            }
        }
    }
}
