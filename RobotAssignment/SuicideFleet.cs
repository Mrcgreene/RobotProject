using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAssignment
{
    public class SuicideFleet : Robot
    {
        public string attachment;

        public SuicideFleet(string Attachment)
        {
            robotModel = "KAZI";
            manufacturer = "Fluorine Elements";
            yearMade = 2016;
            encodingType = "NTSC";
            powerLevel = 5;
            energyLevel = 100;
            size = "Standard";
            attachment = Attachment;

        }
        public void Explode()
        {
            Console.WriteLine("Boom!!!!! Model " + robotModel + " " + "launches a " + attachment + " " 
                + "and destroys all items within a radius of 50 feet.");
        }
    }
}
