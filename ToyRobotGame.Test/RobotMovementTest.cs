using NUnit.Framework;
using ToyRobotGameCoreLibrary.Robot;
using ToyRobotGameCoreLibrary.Table;

namespace ToyRobotGame.Test
{
    public class RobotMovementTest
    {
        private RobotCommand robotCommand;
        private RobotAction robotAction;
        private Table table;

        [Test]
        public void Robot_At_0_0_NORTH_Report_0_1_NORTH_AfterSingleMove()
        {
            // Arrange
            table = new Table();
            robotAction = new RobotAction(table);
            robotCommand = new RobotCommand(robotAction);

            // Act            
            string output = robotCommand.RobotCommands("PLACE 0,0,NORTH");
            output = robotCommand.RobotCommands("MOVE");
            output = robotCommand.RobotCommands("REPORT");

            // Assert
            Assert.AreEqual("0, 1, NORTH", output);
        }
    }
}
