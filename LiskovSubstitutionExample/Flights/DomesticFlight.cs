using System.Collections.Generic;

namespace LiskovSubstitutionExample.Flights
{
    /// <summary>
    /// Внутренние рейсы
    /// </summary>
    public class DomesticFlight : Flight
    {
        public DomesticFlight(string name, List<string> passengers = null) : base(name, passengers)
        {
        }
        
        // Какой-то специфичный для внутренних рейсов функционал
    }
}