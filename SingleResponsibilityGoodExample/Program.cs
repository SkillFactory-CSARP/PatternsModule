namespace SingleResponsibilityGoodExample
{
    class Program
    {
        static void Main()
        {
            IExporter exporter = new PdfExporter();
            Document doc = new Document();
            doc.Text = "Hello Wolrd";
            doc.Export(exporter);
        }
    }
}