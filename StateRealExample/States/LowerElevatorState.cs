using System;

namespace StateRealExample.States
{
    /// <summary>
    /// Реализация нижнего состояния (лифт в подвале)
    /// </summary>
    class LowerElevatorState : IElevatorState
    {
        public void Up(Elevator elevator)
        {
            Console.WriteLine("Поднимаемся на первый этаж");
            elevator.ElevatorState = new GroundElevatorState();
        }
 
        public void Down(Elevator elevator)
        {
            Console.WriteLine("Опускаемся ещё ниже");
        }
    }
}