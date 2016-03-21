using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAssignment
{
    public class JapaneseRobot : Robot
    {
        public string color;
        public int generationNumber;
        public int pushLimits = 15;
        public int enhanceEnergy = 150;
        public JapaneseRobot(string Color)
        {
            robotModel = "MTDEV";
            manufacturer = "Konami K.E. Intel";
            yearMade = 2015;
            encodingType = "NTSC";
            powerLevel = 5;
            energyLevel = 100;
            size = "Standard";
            color = Color;
            generationNumber = 2;

        }

        public void OverHaul()
        {
            powerLevel = pushLimits;
            energyLevel = enhanceEnergy;
            Console.WriteLine("You have now entered Steroid Mode.");
        }

        public void Punch()
        {
            powerLevel -= 1;
            energyLevel -= 5;
        }
    }
}
