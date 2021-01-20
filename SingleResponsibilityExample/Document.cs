using System;

namespace SingleResponsibilityExample
{
    /// <summary>
    /// Класс документа
    /// </summary>
    class Document
    {
        public string Text { get; set; }
        
        public void ScrollUp()
        {
            Console.WriteLine($"Прокрутка вверх");
        }
 
        public void ScrollDown()
        {
            Console.WriteLine($"Прокрутка вниз");
        }
 
        public void ZoomIn()
        {
            Console.WriteLine("Увелчиваем масштаб");
        }
 
        public void ExportToPdf()
        {
            Console.WriteLine("Экспортируем текст в PDF");
            Console.WriteLine(Text);
        }
    }
}