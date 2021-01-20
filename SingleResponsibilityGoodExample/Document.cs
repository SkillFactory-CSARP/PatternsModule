using System;

namespace SingleResponsibilityGoodExample
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

        /// <summary>
        ///  Экспорт в любые форматы 
        /// </summary>
        public void Export(IExporter exporter)
        {
            exporter.Export(Text);
        }
    } 
}