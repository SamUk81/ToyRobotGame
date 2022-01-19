using NUnit.Framework;
using ToyRobotGameCoreLibrary.Robot;
using ToyRobotGameCoreLibrary.Table;

namespace ToyRobotGame.Test
{
    public class RobotOutOfBoundTest
    {
        private RobotCommand robotCommand;
        private RobotAction robotAction;
        private Table table;

        [Test]
        public void RobotOutOfBound_Case_1()
        {
            // Arrange
            table = new Table();
            robotAction = new RobotAction(table);
            robotCommand = new RobotCommand(robotAction);

            // Act            
            string output = robotCommand.RobotCommands("PLACE 1,2,EAST");            
            output = robotCommand.RobotCommands("MOVE");
            output = robotCommand.RobotCommands("LEFT");
            output = robotCommand.RobotCommands("MOVE");
            output = robotCommand.RobotCommands("PLACE 3,1");            
            output = robotCommand.RobotCommands("MOVE");
            output = robotCommand.RobotCommands("REPORT");

            // Assert
            Assert.AreEqual("3, 2, NORTH", output);
        }

        [Test]
        public void RobotOutOfBound_Case_2()
        {
            // Arrange
            table = new Table();
            robotAction = new RobotAction(table);
            robotCommand = new RobotCommand(robotAction);

            // Act
            string output = robotCommand.RobotCommands("PLACE 0,0,NORTH");
            output = robotCommand.RobotCommands("LEFT");
            output = robotCommand.RobotCommands("REPORT");

            // Assert
            Assert.AreEqual("0, 0, WEST", output);
        }

        [Test]
        public void RobotOutOfBound_Case_3()
        {
            // Arrange
            table = new Table();
            robotAction = new RobotAction(table);
            robotCommand = new RobotCommand(robotAction);

            // Act
            string output = robotCommand.RobotCommands("PLACE 0,0,NORTH");
            output = robotCommand.RobotCommands("MOVE");
            output = robotCommand.RobotCommands("REPORT");

            //assert
            Assert.AreEqual("0, 1, NORTH", output);
        }

        [Test]
        public void RobotOutOfBound_Case_4()
        {
            // Arrange
            table = new Table();
            robotAction = new RobotAction(table);
            robotCommand = new RobotCommand(robotAction);

            // Act
            string output = robotCommand.RobotCommands("PLACE 1,2,EAST");
            output = robotCommand.RobotCommands("MOVE");
            output = robotCommand.RobotCommands("MOVE");
            output = robotCommand.RobotCommands("LEFT");
            output = robotCommand.RobotCommands("MOVE");
            output = robotCommand.RobotCommands("REPORT");
            
            // Assert
            Assert.AreEqual("3, 3, NORTH", output);
        }
    }
}