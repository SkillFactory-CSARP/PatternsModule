using ObserverRealExample.Observers;

namespace ObserverRealExample
{
    /// <summary>
    /// Интерфейс наблюдаемого объекта
    /// </summary>
    interface IObservable
    {
        // добавить наблюдателя
        void RegisterObserver(IObserver o);
        
        // удалить наблюдателя
        void RemoveObserver(IObserver o);
        
        // уведомление наблюдателей
        void NotifyObservers();
    }
}