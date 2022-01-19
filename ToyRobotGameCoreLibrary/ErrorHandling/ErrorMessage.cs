namespace ToyRobotGameCoreLibrary.ErrorHandling
{
    public class ErrorMessage
    {
        public const string ROBOT_OUT_OF_BOUND = "Invalid entry >> Robot is out of Bound";
        public const string INVALID_COMMAND = "Invalid entry >> Invalid command entered";
        public const string ROBOT_NOT_PLACED_ON_TABLE = "Invalid entry >> Please make sure to place robot first using the PLACE command, using the following format: PLACE X,Y,FACING";                
        public const string VALID_COMMAND = "Invalid command:  \nValid commands are:\n PLACE X,Y,FACING\n LEFT\n RIGHT\n MOVE\n PLACE X,Y\n REPORT";        
    }
}
