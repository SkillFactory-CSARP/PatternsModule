namespace DependencyInversionExample.Devices
{
    /// <summary>
    /// Адаптер для вывода изображений
    /// </summary>
    class VideoAdapter
    {
        public string Text { get; set; }
        public IHdmiInterface HdmiInterface { get; set; }

        public VideoAdapter(IHdmiInterface hdmiInterface)
        {
            HdmiInterface = hdmiInterface;
        }
 
        /// <summary>
        /// Метод вывода
        /// </summary>
        public void Display()
        {
            HdmiInterface.Display(Text);
        }
    }
}