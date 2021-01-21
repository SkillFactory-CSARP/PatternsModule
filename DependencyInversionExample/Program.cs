using System;
using System.Text;

namespace DependencyInversionExample.Devices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            //  выводим на монитор
            var connectedMonitor = new VideoAdapter(new Monitor());
            connectedMonitor.Display();
            
            //  выводим на телеыизор
            var connectedTv = new VideoAdapter(new Tv());
            connectedTv.Display();
        }
    }
}