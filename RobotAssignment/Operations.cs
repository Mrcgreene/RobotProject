using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAssignment
{
    public class Operations
    {
        public int selection;
        public int fleetChoice;

        public void Greeting() {

            Console.WriteLine("Welcome to the Robot Training Arena. Choose a robot to use.");
            Console.WriteLine("1 - American Robot");
            Console.WriteLine("2 - Japanese Robot");
            Console.WriteLine("3 - Down Under Robot");
            Console.WriteLine("4 - Fusion Robot");
            Console.WriteLine("5 - Maybe Next Time - Exit");
            
            selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case '1':
                    Console.WriteLine("You have chosen the American Robot named Charlie");
                    AmericanRobot charlie = new AmericanRobot("male");
                    break;
                case '2':
                    Console.WriteLine("You have chosen the Japanese Robot named Yamato");
                    JapaneseRobot yamato = new JapaneseRobot("Silver");
                    break;
                case '3':
                    Console.WriteLine("You have chosen William the Down Under Robot");
                    DownUnderRobot william = new DownUnderRobot(1);
                    break;
                case '4':
                    Console.WriteLine("You have chosen the new Fusion Robot named Brutus");
                    FusionRobot brutus = new FusionRobot(7, "giant", "modifications underway");
                    break;
                default:
                    Console.WriteLine("There was not a valid robot selected");
                    break;
            }

       }     
        
        
        public void SummonFleet()
    {
        int fleetChoice;

        Console.WriteLine("Which support do you need?");
        Console.WriteLine("1 - Suicide Fleet");
        Console.WriteLine("2 - Healer Fleet");
        fleetChoice  = Convert.ToInt32(Console.ReadLine());                               //console entry recognized as 

        if (fleetChoice == 1)
        {
            SuicideFleet suicide = new SuicideFleet("EXP50 Cube");
            Console.WriteLine("How many units are needed: 1-10");
            if (Console.ReadLine() > 10)                                //console entry recognized as
            {
                Console.WriteLine("Invalid nummber, choose less");      //need loop to go through until a number in range is chosen
            }
        }
        else (fleetChoice == 2)
        {
            HealerFleet shaman = new HealerFleet(5);
        }

    }
        

        

       
    }
}
