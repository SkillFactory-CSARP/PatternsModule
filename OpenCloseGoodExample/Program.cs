using System;
using System.Text;
using OpenCloseGoodExample.Profiles;

namespace OpenCloseGoodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            var boardComputer = new BoardComputer();
            
            //  посадка на землю
            boardComputer.PerformLanding(new GroundLandingProfile());

            Console.WriteLine();
            
            //  посадка на воду
            boardComputer.PerformLanding(new WaterLandingProfile());
        }
    }
}