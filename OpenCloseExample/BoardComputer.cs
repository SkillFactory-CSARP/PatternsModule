﻿using System;
using System.Text;

namespace OpenCloseExample
{
    class BoardComputer
    {
        public void GroundLanding()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("Опускаем руль высоты");
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("Выпускаем шасси");
            Console.WriteLine("Поднимаем руль высоты");
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("--ПОСАДКА--");
            Console.WriteLine("Выпускаем тормозной парашют");
        }
    }
}