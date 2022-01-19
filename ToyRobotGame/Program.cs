using Microsoft.Extensions.DependencyInjection;
using System;
using ToyRobotGameCoreLibrary.Interface;
using ToyRobotGameCoreLibrary.Robot;
using ToyRobotGameCoreLibrary.Table;

namespace ToyRobotGame
{
    class Program
    {
        private static IRobotCommand robotCommand;

        static void Main(string[] args)
        {
            ConfigureServices();

            const string instructions =
@"
  
                                ******************************************
                                *  TOY ROBOT GAME ON 6 x 6 Square Table  *
                                ******************************************
                                                                                                                   
      1. PLACE  >> Will put the toy robot on the table in position X,Y and facing NORTH, SOUTH, EAST or WEST.      
      2. LEFT   >> will rotate the robot 90 degrees to the left without changing the position of the robot.      
      3. RIGHT  >> will rotate the robot 90 degrees to the right without changing the position of the robot.     
      4. MOVE   >> Will move the toy robot one unit forward in the direction it is currently facing.             
      5. REPORT >> Will announce the X,Y and orientation of the robot.                                           
      6. EXIT   >> Will exit the application                                                                     
";

            Console.WriteLine(instructions);

            while (true)
            {
                Console.WriteLine("Enter Command >>");
                var command = Console.ReadLine();

                if (command == null) continue;

                if (command.ToUpper().Equals("EXIT"))
                {
                    break;
                }                    

                Console.WriteLine(robotCommand.RobotCommands(command));
                Console.WriteLine();                
            }                
        }

        private static void ConfigureServices()
        {
            var serviceCollection = new ServiceCollection()
                .AddSingleton<ITable, Table>()
                .AddSingleton<IRobotAction, RobotAction>()
                .AddSingleton<IRobotCommand, RobotCommand>()
                .BuildServiceProvider();

            robotCommand = serviceCollection.GetService<IRobotCommand>();
        }
    }
}
