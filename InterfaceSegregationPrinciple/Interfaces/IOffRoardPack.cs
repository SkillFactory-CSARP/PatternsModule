namespace InterfaceSegregationPrinciple.Interfaces
{
    /// <summary>
    ///  Интерфейс подключения офф-роуд систем для внедорожников
    /// </summary>
    public interface IOffRoadPack
    {
        void DriveDown();
        void LockDifferential();
        void DescentAssist();
    }
}