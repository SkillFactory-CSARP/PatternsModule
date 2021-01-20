using System;
using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple.Cars
{
    /// <summary>
    ///  Премиум - внедорожник
    /// </summary>
    public class Suv : ICar, IPremiumPack, ISportPack, IOffRoadPack
    {
        public void Drive()
        {
            Console.WriteLine("Едем");
        }
    
        public void CruiseControl()
        {
            Console.WriteLine("Включаем круиз-контроль");
        }

        public void FourWheelDrive()
        {
            Console.WriteLine("Включаем полный привод");
        }

        public void DriveDown()
        {
            Console.WriteLine("Включаем систему помощи при спуске");
        }

        public void LockDifferential()
        {
            Console.WriteLine("Включаем блокировку центрального дифференциала");
        }

        public void DescentAssist()
        {
            Console.WriteLine("Включаем систему помощи при спуске");
        }
    }
}