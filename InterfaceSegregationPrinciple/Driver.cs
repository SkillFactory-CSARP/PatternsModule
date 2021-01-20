using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple
{
    public class Driver
    {
        public void Drive(ICar car)
        {
            car.Drive();
        }
    }
}