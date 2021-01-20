using System.Collections.Generic;

namespace LiskovSubstitutionExample.Flights
{
    /// <summary>
    /// Международные рейсы
    /// </summary>
    public class InternationalFlight : Flight
    {
        public InternationalFlight(string name, List<string> passengers = null) : base(name, passengers)
        {
        }
        
        // Какой-то специфичный для международных рейсов функционал
    }
}