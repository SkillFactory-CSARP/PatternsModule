using System;
using System.Text;

namespace SingleResponsibilityGoodExample
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            IExporter exporter = new PdfExporter();
            Document doc = new Document();
            doc.Text = "Hello Wolrd";
            doc.Export(exporter);
        }
    }
}