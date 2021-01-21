using System;
using System.Text;
using StateRealExample.States;

namespace StateRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            // инициализируем лифт (находится на земле)
            Elevator elevator = new Elevator(new GroundElevatorState());
            
            elevator.Up();  // подъем наверх
            elevator.Down();  // спуск на землю
            elevator.Down(); // спуск в подвал
        }
    }
}