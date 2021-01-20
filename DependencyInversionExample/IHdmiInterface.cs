namespace DependencyInversionExample.Devices
{
    /// <summary>
    /// Универсальный интерфейс для вывода изображения
    /// </summary>
    public interface IHdmiInterface
    {
        void Display( string text);
    }
}