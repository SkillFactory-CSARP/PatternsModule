using System;
using System.Runtime.InteropServices;
using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple.Cars
{
    /// <summary>
    /// У нас премиум-седан, поэтому кроме обычных систем подключаем системы комфорта
    /// </summary>
    public class Sedane : ICar, IPremiumPack
    {
        public void Drive()
        {
            Console.WriteLine("Едем");
        }
    
        public void CruiseControl()
        {
            Console.WriteLine("Включаем круиз-контроль");
        }
    }
}
