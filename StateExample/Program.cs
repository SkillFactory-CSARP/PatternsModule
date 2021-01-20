namespace StateExample
{
    class Program
    {
        static void Main()
        {
            // создаем объет сразу в каким-то состоянии
            var contextObject = new ContextObject(new StateOne());
            
            contextObject.Switch(); // Переход в состояние StateTwo
            contextObject.Switch();  // Переход в состояние StateOne
        }
    }
    
    /// <summary>
    ///  Общий интерфейс, определяющий состояния
    /// </summary>
    abstract class State
    {
        public abstract void Handle(ContextObject contextObject);
    }
    
    /// <summary>
    /// Первое сояние
    /// </summary>
    class StateOne : State
    {
        public override void Handle(ContextObject contextObject)
        {
            contextObject.State = new StateTwo();
        }
    }
    
    /// <summary>
    /// Второе сояние
    /// </summary>
    class StateTwo : State
    {
        public override void Handle(ContextObject contextObject)
        { 
            contextObject.State = new StateOne();
        }
    }
 
    /// <summary>
    /// Сам объект, поведение которого должно изменяться
    /// </summary>
    class ContextObject
    {
        public State State { get; set; }
        public ContextObject(State state)
        {
            State = state;
        }
        
        public void Switch()
        {
            State.Handle(this);
        }
    }
}