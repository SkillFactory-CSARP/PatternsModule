using System;

namespace SingletonExample
{
    class Singleton
    {
        // Статическая переменная - ссылка на конкретный экземпдяр объекта
        private static Singleton Instance;
 
        // Приватный конструктор
        private Singleton()
        {}
 
        // Здесь конструктор вызывается для создания объекта, если он отсутствует или равен null 
        public static Singleton GetInstance()
        {
            if (Instance == null)
                Instance = new Singleton();
            
            return Instance;
        }
    }
}