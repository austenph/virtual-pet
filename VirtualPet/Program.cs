using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
       

        static void Main(string[] args)
        {
          
            //This section sets the storyline up for the user
            Console.WriteLine("Welcome to Dragon Hatcher!");
            Console.WriteLine("The interactive pet game were you hatch and raise your very own dragon!");
            Console.WriteLine("Let's Start!");
            Enter();
            Console.WriteLine("\nWe are at the Dragon Egg Store.");
            int bank = Bank();
            Console.WriteLine("You have $" + bank + " in the bank.");
            Console.WriteLine("Please select which egg you want from the options below (enter a number 1-5): ");
            Console.WriteLine("1. Blue Egg for $50");
            Console.WriteLine("2. Purple Egg for $100");
            Console.WriteLine("3. Green Egg for $110");
            Console.WriteLine("4. White Egg for $150");
            Console.WriteLine("5. Gold Egg for $200");

            Console.Write("\nYour number is: ");  
            int option = int.Parse(Console.ReadLine());

            bool done = false;
            while (!done)
            { 
                switch (option)
                {
                    case 1:
                        if (bank <= 300)
                        {
                              Console.WriteLine("\nYou selected: Blue Egg for $50!");
                            done = true;
                        }
                        else
                        {
                            Console.WriteLine("\nYou can't afford this Egg, try again!");
                            Console.Write("Your number is: ");
                            option = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 2:
                        if (bank >= 100)
                        {
                            Console.WriteLine("\nYou selected: Purple Egg for $100!");
                            done = true;
                        }
                        else
                        {
                            Console.WriteLine("\nYou can't afford this Egg, try again!");
                            Console.Write("Your number is: ");
                            option = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 3:
                        if (bank >= 110)
                        {
                            Console.WriteLine("\nYou selected: Green Egg for $110!");
                            done = true;
                        }
                        else
                        {
                            Console.WriteLine("\nYou can't afford this Egg, try again!");
                            Console.Write("Your number is: ");
                            option = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 4:
                        if (bank >= 150)
                        {
                            Console.WriteLine("\nYou selected: White Egg for $150!");
                            done = true;
                        }
                        else
                        {
                            Console.WriteLine("\nYou can't afford this Egg, try again!");
                            Console.Write("Your number is: ");
                            option = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 5:
                        if (bank >= 200)
                        {
                            Console.WriteLine("\nYou selected: Gold Egg for $200!");
                            done = true;
                        }
                        else
                        {
                            Console.WriteLine("\nYou can't afford this Egg, try again!");
                            Console.Write("Your number is: ");
                            option = int.Parse(Console.ReadLine());
                        }
                        break;
                    default:
                        break;
                }
            } 


          Console.WriteLine("You are now the proud owner of a dragon egg!");
            Enter();
            Console.Write("\nA week has past and your egg is ready to Hatch. You must rub the egg three times");
            Console.Write("to hatch it. Type \"rub my egg\" to start hatching your dragon!  ");
            string hatch = Console.ReadLine();
            Hatch(hatch);
            Console.WriteLine("\nCrack!! Congrats, you have hatched your new baby dragon!");
            Enter();
            Console.WriteLine("Type \"Generate\" to see what color and gender your dragon is!");
            string generate = Console.ReadLine();
            GenerateDragon(generate);
            Console.WriteLine("\nNow it is time to start taking care of your new pet Dragon.");
            Console.WriteLine("Let's start by naming your pet! Enter the name you want for your dragon below: ");
            VirtualPet pet = new VirtualPet("Dragon", "High Energy", "No Skills Achieved", "No Food", "Hungry", "Not Sleepy");
            pet.GetName = Console.ReadLine();
            Console.WriteLine("You have named your dragon " + pet.GetName + "! Great Name!");
            Enter();
            Console.WriteLine("\nNow you can interact with " + pet.GetName + "! \nWe will choose from a menu of options in order to raise him. Let's Go!!" );
            Enter();
           do
            { 
                pet.MenuDisplayNameandDragon(); //always prints out dragons name and the words The Dragon
            Console.WriteLine("Please select which interaction you want from the options below\n(enter a number 1 - 5): ");
            Console.WriteLine("1.Play\n2.Train\n3.Hunt\n4.Feed\n5.Fly\n6.Sleep"); //menu of possible interactions

                pet.Selector= int.Parse(Console.ReadLine());//takes users input a gives it to switch case

                //switch case to activate the interaction methods in virtualpet class, based on user selection
            switch (pet.Selector)
            {
                case 1:
                    pet.Play();
                    break;
                case 2:
                    pet.Train();
                    break;
                case 3:
                    pet.Hunt();
                    break;
                case 4:
                    pet.Eat();
                    break;
                case 5:
                    pet.Fly();
                    break;
                case 6:
                    pet.SleepMethod();
                    break;
                default:
                    break;

            }
                Enter();
            } while(pet.Selector<7);
        }


        //hatch method
        static void Hatch (string hatch)
        {
            for (int i = 3; i > 0; i--)
            {
                if (i == 3) { Console.Write("\n" + i + ".....Rub Me Again! "); }
                else if(i==2) { Console.Write("\n" + i + "............One more rub! "); }
                else if (i == 1) { Console.Write("\n" + i + ".....................................\n"); break; }
                hatch = Console.ReadLine();
            }
        }
        //hit enter to continue method
     static void Enter ()
        {
            Console.Write("(hit enter to continue)\n");
            Console.ReadLine();
        }
        //random generated bank method
        static int Bank ()
        {
            Random randomMoney = new Random();
            int[] money = { 50, 100, 115, 120, 125, 130, 135, 150, 160, 180, 200, 300 };
            int bank = money[randomMoney.Next(money.Length)];
            return bank ;
        }
        //method generates dragons color and gender
        static void GenerateDragon(string generate)
        {
            string[] colorsArray = { "Blue Spotted", "Purple and Pink Striped", "Green and Yellow", "Orange, Red, and Black", "Magestic White", "Brown and Oliver Spotted" };
            string[] genderArray = { "Girl", "Boy" };
            Random colorrandom = new Random();
            Random genderrandom = new Random();
            string color = colorsArray[colorrandom.Next(colorsArray.Length)];
            string gender = genderArray[genderrandom.Next(genderArray.Length)];
            string dragonGenerator = "Your new pet is a " + color + " " + gender + " Dragon!";
            Console.WriteLine(dragonGenerator);
        }
    }
}
