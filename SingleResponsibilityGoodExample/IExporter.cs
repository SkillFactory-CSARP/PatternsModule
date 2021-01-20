namespace SingleResponsibilityGoodExample
{
    /// <summary>
    /// Общий интерфейс для классов - экспортеров
    /// </summary>
    interface IExporter
    {
        void Export(string text);
    }
}