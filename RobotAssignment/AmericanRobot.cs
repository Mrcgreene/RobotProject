using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAssignment
{
    public class AmericanRobot : Robot
    {
        public string audioVoice;
        public string hisTauntingWords;
        public string herTauntingWords;
        public string decisionOnOptimize;
        public int resetLevels = 100;
        
        public AmericanRobot(string AudioVoice)
        {
            robotModel = "Au-D";
            manufacturer = "Goldin PR Group";
            yearMade = 2016;
            encodingType = "NTSC";
            powerLevel = 7;
            energyLevel = 100;
            size = "Large";
            audioVoice = AudioVoice;
        }

         public void MaleTaunt() {
            Console.WriteLine("I am clearly superior,  you're better off discontinuing yourself.");
            Console.ReadLine();
        }
         public void FemaleTaunt()
        {
            Console.WriteLine("...and you call yourself a man.");
            Console.ReadLine();
        }

        public void Optimize()
        {
            if (energyLevel == 100)
            { Console.WriteLine("Your level is already full");
            } else if(energyLevel < 100)
            {
                energyLevel = resetLevels;
                Console.WriteLine("You are back at maximum energy.");
            }
    } 

            public void Speak()
        {
            Console.WriteLine("Greetings, I am the " + robotModel + " " + "and I was manufactured by " +
                manufacturer + " " + "in " + yearMade);
        }

       public void HeadButt()
        {
            powerLevel -= 1;
            energyLevel -= 10;
        } 
        
        }
    }
