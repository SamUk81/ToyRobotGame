using System;
using ToyRobotGameCoreLibrary.ErrorHandling;
using ToyRobotGameCoreLibrary.Interface;

namespace ToyRobotGameCoreLibrary.Robot
{
    public class RobotCommand : IRobotCommand
    {
        private readonly IRobotAction robotAction;

        public RobotCommand(IRobotAction robotAction)
        {
            this.robotAction = robotAction;            
        }

        public string RobotCommands(string input)
        {
            string command = input.ToUpper();
            string output = string.Empty;

            try
            {
                if (command.Contains("PLACE"))
                {
                    output = robotAction.PlaceRobot(command);
                }
                else if (!robotAction.isRobotPlacedOnTable)
                {
                    output = ErrorMessage.ROBOT_NOT_PLACED_ON_TABLE;
                }                
                else if (command.Contains("MOVE"))
                {
                    output = robotAction.MoveRobot();
                }                
                else if (command.Contains("RIGHT"))
                {
                    robotAction.RotateRight();
                }
                else if (command.Contains("LEFT"))
                {
                    robotAction.RotateLeft();
                }
                else if (command.Contains("REPORT"))
                {
                    output = robotAction.GetRobotPositionReport();
                }
                else
                {
                    output = ErrorMessage.INVALID_COMMAND;
                }                    
            }
            catch (Exception e)
            {
                output = ErrorMessage.VALID_COMMAND;
            }

            return output;
        }
    }
}
