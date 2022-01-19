namespace ToyRobotGameCoreLibrary.Interface
{
    public interface ITable
    {
        bool RobotValidationCheck();
        int PositionX { get; set; }
        int PositionY { get; set; }
    }
}
