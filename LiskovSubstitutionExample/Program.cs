using System;
using System.Collections.Generic;
using System.Text;
using LiskovSubstitutionExample.Flights;

namespace LiskovSubstitutionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            // Новый список полётов
            var flightsList = new List<Flight>()
            {
                new DomesticFlight("Mow-32", new List<string>() {"Вася", "Петя"}),
                new DomesticFlight("SPB-14", new List<string>() {"Андрей"})
            };
            
            // Считаем пассажиров
            FlightPassengerCount(flightsList);
        }
        
        /// <summary>
        /// Метод для подсчёта количества пассажиров
        /// </summary>
        public static void FlightPassengerCount(List<Flight> flights)
        {
            foreach (var flight in flights)
               flight.CountPassengers();
        }
    }
}