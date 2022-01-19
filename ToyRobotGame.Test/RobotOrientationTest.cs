using NUnit.Framework;
using ToyRobotGameCoreLibrary.Robot;
using ToyRobotGameCoreLibrary.Table;

namespace ToyRobotGame.Test
{
    public class RobotOrientationTest
    {
        private RobotCommand robotCommand;
        private RobotAction robotAction;
        private Table table;

        #region "Test left oreination"
        [Test]
        public void Robot_At_0_0_SOUTH_Report_0_0_EAST_AfterLeftCommand()
        {
            // Arrange
            table = new Table();
            robotAction = new RobotAction(table);
            robotCommand = new RobotCommand(robotAction);

            // Act            
            string output = robotCommand.RobotCommands("PLACE 0,0,SOUTH");
            output = robotCommand.RobotCommands("LEFT");
            output = robotCommand.RobotCommands("REPORT");

            // Assert
            Assert.AreEqual("0, 0, EAST", output);
        }

        [Test]
        public void Robot_At_0_0_NORTH_Report_0_0_WEST_AfterLeftCommand()
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
        public void Robot_At_0_0_EAST_Report_0_0_NORTH_AfterLeftCommand()
        {
            // Arrange
            table = new Table();
            robotAction = new RobotAction(table);
            robotCommand = new RobotCommand(robotAction);

            // Act            
            string output = robotCommand.RobotCommands("PLACE 0,0,EAST");
            output = robotCommand.RobotCommands("LEFT");
            output = robotCommand.RobotCommands("REPORT");

            // Assert
            Assert.AreEqual("0, 0, NORTH", output);
        }

        [Test]
        public void Robot_At_0_0_WEST_Report_0_0_SOUTH_AfterLeftCommand()
        {
            // Arrange
            table = new Table();
            robotAction = new RobotAction(table);
            robotCommand = new RobotCommand(robotAction);

            // Act            
            string output = robotCommand.RobotCommands("PLACE 0,0,WEST");
            output = robotCommand.RobotCommands("LEFT");
            output = robotCommand.RobotCommands("REPORT");

            // Assert
            Assert.AreEqual("0, 0, SOUTH", output);
        }
        #endregion

        #region "Test right oreination"
        [Test]
        public void Robot_At_0_0_SOUTH_Report_0_0_WEST_AfterRightCommand()
        {
            // Arrange
            table = new Table();
            robotAction = new RobotAction(table);
            robotCommand = new RobotCommand(robotAction);

            // Act            
            string output = robotCommand.RobotCommands("PLACE 0,0,SOUTH");
            output = robotCommand.RobotCommands("RIGHT");
            output = robotCommand.RobotCommands("REPORT");

            // Assert
            Assert.AreEqual("0, 0, WEST", output);
        }

        [Test]
        public void Robot_At_0_0_NORTH_Report_0_0_EAST_AfterRightCommand()
        {
            // Arrange
            table = new Table();
            robotAction = new RobotAction(table);
            robotCommand = new RobotCommand(robotAction);

            // Act            
            string output = robotCommand.RobotCommands("PLACE 0,0,NORTH");
            output = robotCommand.RobotCommands("RIGHT");
            output = robotCommand.RobotCommands("REPORT");

            // Assert
            Assert.AreEqual("0, 0, EAST", output);
        }

        [Test]
        public void Robot_At_0_0_WEST_Report_0_0_NORTH_AfterRightCommand()
        {
            // Arrange
            table = new Table();
            robotAction = new RobotAction(table);
            robotCommand = new RobotCommand(robotAction);

            // Act            
            string output = robotCommand.RobotCommands("PLACE 0,0,WEST");
            output = robotCommand.RobotCommands("RIGHT");
            output = robotCommand.RobotCommands("REPORT");

            // Assert
            Assert.AreEqual("0, 0, NORTH", output);
        }

        [Test]
        public void Robot_At_0_0_EAST_Report_0_0_SOUTH_AfterRightCommand()
        {
            // Arrange
            table = new Table();
            robotAction = new RobotAction(table);
            robotCommand = new RobotCommand(robotAction);

            // Act            
            string output = robotCommand.RobotCommands("PLACE 0,0,EAST");
            output = robotCommand.RobotCommands("RIGHT");
            output = robotCommand.RobotCommands("REPORT");

            // Assert
            Assert.AreEqual("0, 0, SOUTH", output);
        }
        #endregion
    }
}
