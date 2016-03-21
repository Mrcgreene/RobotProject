using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAssignment
{
    public class DownUnderRobot : Robot
    {
        public int speedRate;

        public DownUnderRobot(int SpeedRate)
        {
            robotModel = "KIWI";
            manufacturer = "Andru Corp";
            yearMade = 2016;
            encodingType = "PAL";
            powerLevel = 7;
            energyLevel = 100;
            size = "Large";
            speedRate = SpeedRate;

        }
        
        public void Shock()
        {
            powerLevel -= 2;
            energyLevel -= 20;
            //shock as a function that damages until level reaches a certain point
        }
               
        public void Run(){

            }
            //moveBackward as a function

    }
}
