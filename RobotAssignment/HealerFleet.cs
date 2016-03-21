using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAssignment
{
    public class HealerFleet : Robot
    {
        public string dettachments;
        public int dettachmentCount;
        public int medicCount = 0;

        public HealerFleet(int DettachmentCount)
        {
            robotModel = "DR-MED";
            manufacturer = "4rom Atom Inc.";
            yearMade = 2016;
            encodingType = "NTSC";
            powerLevel = 3;
            energyLevel = 150;
            size = "Small";
            dettachments = "Replenishment Capsule";
            dettachmentCount = DettachmentCount;

        }

        public void GiveTreatment()
        {
            /*make function that counts dettachments (-20 on energy each used) and brings other robot energy level back to full, if
                   all gone healer energyLevel decreases and runs away*/
        }

    }
}
