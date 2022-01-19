namespace ToyRobotGameCoreLibrary.Interface
{
    public interface IRobotAction
    {
        void RotateRight();
        void RotateLeft();
        string MoveRobot();
        string GetRobotPositionReport();
        string PlaceRobot(string command);
        bool isRobotPlacedOnTable { get; set; }
    }
}
