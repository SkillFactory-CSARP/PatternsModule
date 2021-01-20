using System;

namespace CompositeExample.Components
{
    /// <summary>
    /// Представляет компонент самого низкого уровня
    /// Который не может содержать под-компонентов
    /// </summary>
    class File : Component
    {
        public File(string name)
            : base(name)
        {}
 
        public override void Display()
        {
            Console.WriteLine(Name);
        }
 
        // Метод для добавления под-компонентов не поддерживается
        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }
 
        // Метод для удаления под-компонентов не поддерживается
        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}