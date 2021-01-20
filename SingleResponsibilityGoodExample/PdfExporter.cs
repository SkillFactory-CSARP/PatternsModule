using System;

namespace SingleResponsibilityGoodExample
{
    /// <summary>
    /// Экспорт в PDF
    /// </summary>
    class PdfExporter : IExporter
    {
        public void Export(string text)
        {
            Console.WriteLine($"{text}  => Экспортировано в PDF");
        }
    }
}