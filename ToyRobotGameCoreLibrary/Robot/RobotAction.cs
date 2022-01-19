using System;
using ToyRobotGameCoreLibrary.Enums;
using ToyRobotGameCoreLibrary.ErrorHandling;
using ToyRobotGameCoreLibrary.Interface;

namespace ToyRobotGameCoreLibrary.Robot
{
    public class RobotAction : IRobotAction
    {
        private readonly ITable table;
        
        public EnumOrientation orientation;

        public bool isRobotPlacedOnTable { get; set; } = false;

        public RobotAction(ITable table)
        {
            this.table = table;
        }

        // This function would rotate the robot 90 degrees to the right without changing current location
        public void RotateRight()
        {
            switch (orientation)
            {
                case EnumOrientation.WEST:
                    orientation = EnumOrientation.NORTH;
                    break;

                case EnumOrientation.NORTH:
                    orientation = EnumOrientation.EAST; 
                    break;                

                case EnumOrientation.EAST:
                    orientation = EnumOrientation.SOUTH;
                    break;

                case EnumOrientation.SOUTH:
                    orientation = EnumOrientation.WEST; 
                    break;                
            }
        }

        // This function would rotate the robot 90 degrees to the left without changing current location
        public void RotateLeft()
        {
            switch (orientation)
            {
                case EnumOrientation.WEST:
                    orientation = EnumOrientation.SOUTH;
                    break;

                case EnumOrientation.NORTH:
                    orientation = EnumOrientation.WEST; 
                    break;

                case EnumOrientation.EAST:
                    orientation = EnumOrientation.NORTH;
                    break;

                case EnumOrientation.SOUTH:
                    orientation = EnumOrientation.EAST; 
                    break;                
            }
        }

        // This function is to move the robot one step forward in it's direction
        public string MoveRobot()
        {
            string output = string.Empty;

            int initialPositionX = this.table.PositionX;
            int initialPositionY = this.table.PositionY;

            switch (orientation)
            {
                case EnumOrientation.EAST:
                    this.table.PositionX++;
                    break;

                case EnumOrientation.WEST:
                    this.table.PositionX--;
                    break;

                case EnumOrientation.SOUTH:
                    this.table.PositionY--;
                    break;

                case EnumOrientation.NORTH:
                    this.table.PositionY++; 
                    break;                                                
            }

            if (!table.RobotValidationCheck())
            {
                this.table.PositionX = initialPositionX;
                this.table.PositionY = initialPositionY;

                output = ErrorMessage.ROBOT_OUT_OF_BOUND;
            }

            return output;
        }

        public string GetRobotPositionReport()
        {
            return $"{this.table.PositionX}, {this.table.PositionY}, {orientation}";
        }

        private void PlacedRobotWithoutOrientation(string inputCommand, EnumOrientation robotOrientation)
        {
            char[] SplitChars = { ',', ' ' };
            
            // Split the input by both comma and space
            string[] commands = inputCommand.Split(SplitChars);
            
            // Assign x and y positions of robot
            this.table.PositionX = Int32.Parse(commands[1]);
            this.table.PositionY = Int32.Parse(commands[2]);

            if (orientation != EnumOrientation.UNDEFINED)
            {
                orientation = robotOrientation;
            }
        }

        // This function will put the robot on the table in position X, Y and facing NORTH, SOUTH, EAST or WEST.
        public string PlaceRobot(string inputCommand)
        {
            char[] SplitChars = { ',', ' ' };
            string output = string.Empty;
            
            string[] commands = inputCommand.Split(SplitChars);

            this.table.PositionX = Int32.Parse(commands[1]);
            this.table.PositionY = Int32.Parse(commands[2]);

            if (commands.Length == 3 && isRobotPlacedOnTable == true)
            {
                PlacedRobotWithoutOrientation(inputCommand, orientation);
            }
            else
            {
                switch (commands[3])
                {
                    case "NORTH":
                        orientation = EnumOrientation.NORTH;
                        break;

                    case "SOUTH":
                        orientation = EnumOrientation.SOUTH;
                        break;

                    case "EAST":
                        orientation = EnumOrientation.EAST;
                        break;

                    case "WEST":
                        orientation = EnumOrientation.WEST;
                        break;

                    default:
                        orientation = EnumOrientation.UNDEFINED;
                        break;

                }
            }                

            if (!this.table.RobotValidationCheck())
            {
                output = ErrorMessage.ROBOT_OUT_OF_BOUND;
            }
            else
            {
                isRobotPlacedOnTable = true;
            }                

            return output;
        }
    }
}
