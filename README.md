# Toy Robot Game
This is console application is to allow for a simulation of a toy robot moving on a 6 x 6 square tabletop. This application was built using C# .NET 5.0. 

The code consists of three projects.
1. ToyRobotGame - The main console application, which should be your startup project.
2. ToyRobotGameCoreLibrary - Library, which consists of all business logic and functionalities of the toy robot.
3. ToyRobotGame.Test - Test project to test couple of scenarios.  

# Installing and Running the Code

1. Clone the repository https://github.com/SamUk81/ToyRobotGame.git
2. Open the solution in Visual Studio 2019
3. Compile the project but selecting Build >> Build Solution from top menu.
4. Make sure your startup project is set to ToyRobotGame console application.
5. Run the project by pressing F5 or by clicking on Debug >> Start Debugging from top menu.

Once you follow all above steps you will be presented with following console application:

![image](https://user-images.githubusercontent.com/96857899/150067582-405dc3e2-9d1f-4a17-b316-df415acf74fb.png)

# Rules of the game
1. There are no obstructions on the table surface.
2. The robot is free to roam around the surface of the table, but must be prevented from falling to destruction. Any movement that would result in this must be prevented, however further valid movement commands must still be allowed.
3. PLACE will put the toy robot on the table in position X,Y and facing NORTH, SOUTH, EAST or WEST.
4. (0,0) can be considered as the SOUTH WEST corner and (5,5) as the NORTH EAST corner.
5. The first valid command to the robot is a PLACE command. After that, any sequence of commands may be issued, in any order, including another PLACE command. The library should discard all commands in the sequence until a valid PLACE command has been executed.
6. The PLACE command should be discarded if it places the robot outside of the table surface.
7. Once the robot is on the table, subsequent PLACE commands could leave out the direction and only provide the coordinates. When this happens, the robot moves to the new coordinates without changing the direction.
8. MOVE will move the toy robot one unit forward in the direction it is currently facing.
9. LEFT and RIGHT will rotate the robot 90 degrees in the specified direction without changing the position of the robot.
10. REPORT will announce the X,Y and orientation of the robot.
11. A robot that is not on the table can choose to ignore the MOVE, LEFT, RIGHT and REPORT commands.

# Playing the game
1. Example 1 Input
>PLACE 0,0,NORTH
> 
> MOVE
> 
> REPORT
> 
Output: 0,1,NORTH

2. Example 2 Input
> PLACE 0,0,NORTH
> 
> LEFT
> 
> REPORT
> 
Output: 0,0,WEST

3. Example 3 Input
> PLACE 1,2,EAST
> 
> MOVE
> 
> MOVE
> 
> LEFT
> 
> MOVE
> 
> REPORT
> 
Output: 3,3,NORTH

4. Example 4 Input
> PLACE 1,2,EAST
> 
> MOVE
> 
> LEFT
> 
> MOVE
> 
> PLACE 3,1
> 
> MOVE
> 
> REPORT
> 
Output: 3,2,NORTH
