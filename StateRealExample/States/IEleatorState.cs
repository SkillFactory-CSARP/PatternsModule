namespace StateRealExample.States
{
    /// <summary>
    /// Интерфе1с состояния лифта
    /// </summary>
    interface IElevatorState
    {
        void Up(Elevator elevator);
        void Down(Elevator elevator);
    }
}