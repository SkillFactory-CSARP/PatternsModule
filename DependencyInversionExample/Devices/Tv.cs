using System;

namespace DependencyInversionExample.Devices
{
    class Tv : IHdmiInterface
    {
        public void Display(string text)
        {
            Console.WriteLine("Вывод на телевизор");
        }
    }
}