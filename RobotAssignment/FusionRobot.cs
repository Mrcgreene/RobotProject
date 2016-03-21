using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAssignment
{
    public class FusionRobot : Robot
    {
        public string rechargePort;
        public int backupEnergy;

        public FusionRobot(int PowerLevel, string Size, string RechargePort)
        {
            robotModel = "HIDDEN";
            manufacturer = "United M.I.6";
            yearMade = 2016;
            encodingType = "UNIV";
            energyLevel = 100;
            size = Size;             
            rechargePort = RechargePort;
            backupEnergy = 100;
            if (size == "small".ToUpper())
            {
                powerLevel = 3;
                //Console.WriteLine("You have chosen Small and your power level will be set at 3");
            }
            if (size == "standard".ToUpper())
            {
                powerLevel = 5;
                //Console.WriteLine("You have chosen Standard and your power level will be set at 5");
            }
            if (size == "large".ToUpper())
            {
                powerLevel = 7;
                //Console.WriteLine("You have chose Large and your power level will be set at 7");
            }
            if (size == "giant".ToUpper())
            {
                powerLevel = 15;
                //Console.WriteLine("You have chosen Giant and your power level will be set at 15");
                {
            powerLevel = PowerLevel;
                }

            
                //backupEnergyTank as part of second energyLevel the construtor 
                //shoot rocket as functions
                //salvageEnergy in function
            }
            

            }
        
    }
}
