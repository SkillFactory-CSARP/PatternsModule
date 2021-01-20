using System;

namespace DependencyInversionExample.Devices
{
    class Monitor : IHdmiInterface
    {
        public void Display(string text)
        {
            Console.WriteLine("Вывод на монитор");
        }
    }
}