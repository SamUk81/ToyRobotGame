using ToyRobotGameCoreLibrary.Interface;

namespace ToyRobotGameCoreLibrary.Table
{
    public class Table : ITable
    {                
        // Private properties
        private int tableSize_x { get; set; }
        private int tableSize_y { get; set; }

        // Public properties
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Table()
        {
            // Default Table sizes 6 x 6 
            tableSize_x = 6;
            tableSize_y = 6;
        }        

        public bool RobotValidationCheck()
        {
            if ((PositionY >= tableSize_y) || (PositionX >= tableSize_x))
            {
                return false;
            }                
            else if ((PositionY < 0) || (PositionX < 0))
            {
                return false;
            }
            else
            {
                return true;
            }                
        }
    }
}
