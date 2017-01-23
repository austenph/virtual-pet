using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //fields

        private string petname;
        private string pet_type;
        private int energy;
        private int runningenergy;
        private int skilllevel;
        private int runningSkillLevel;
        private int food;
        private int runningfood;
        private  int hunger;
        private int runninghunger;
        private string play;
        private string train;
        private string hunt;
        private string feed;
        private string fly;
        private string sleepmethod;
        
        private int tracking;
        private int tracker;

        //properties

        public int Tracking
        {
            get { return this.tracker; }
            set { this.tracking = value; }
        }
        public int Energy
        {
            get { return this.runningenergy; }
            set { this.energy = value; }
        }
        public int SkillLevel
        {
            get { return this.runningSkillLevel; }
            set { this.skilllevel = value; }
        }
        public int Food
        {
            get { return this.runningfood; }
            set { this.food = value; }
        }
        public int Hunger
        {
            get { return this.runninghunger; }
            set { this.hunger = value; }
        }
        public int Selector { get; set; }

        public string GetName
        {
            get { return this.petname; }
            set { this.petname = value; }
        }

        public string GetPetType
        {
            get { return this.pet_type; }
            set { this.pet_type = value; }
        }

        //public LifeCycle MyLifeCycle { get; set; }
        //public string MyName { get; private set; }

        //this.MyLifeCycle = LifeCycle.Baby;
        //this.MyName = name;

        //constructors
        public VirtualPet()
        {

        }

        public VirtualPet(string pet_type)
        {
            this.pet_type = pet_type;
            this.energy = runningenergy;
            this.skilllevel = runningSkillLevel;
            this.food = runningfood;
            this.hunger = runninghunger;
            runningSkillLevel = 0;
            runningenergy = 8;
            runningfood = 0;
            runninghunger =3;
            this.play = "Play";
            this.train = "Train";
            this.hunt = "Hunt";
            this.feed = "Feed";
            this.fly = "Fly";
            this.sleepmethod = "Sleep";
        }

        //methods
        public int Track()
        {
            this.tracking = tracker++;
            return this.tracking;
        }
        public void PrintTrack()
        {
            if (this.tracking == 3)
            {
                Console.WriteLine("\n*****************GROWING UP*************************\nCongrats you are now a Teenage Dragon!\n****************************************************\n");
            }
            if (this.tracking == 7)
            {
                Console.WriteLine("\n*****************GROWING UP*************************\nWooh! You are now an Adult Dragon!\n****************************************************\n");
            }
            if (this.tracking == 13)
            {
                Console.WriteLine("\n*****************GROWING UP**********************************************\nDragons, they grow up so fast. You are now an Elder Dragon. 2 more Turns!\n*************************************************************************\n");
            }
            if (this.tracking == 15)
            {
                Console.WriteLine("\n******************************************************\nYour Dragon's lifecylce has ended!\n******************************************************");
            }
        }

        public void MenuDisplayNameandDragon()
        {
            Console.WriteLine("Interactive Menu: " + petname + " The " + pet_type);
        }
        public void StatusDisplay()
        {
            Console.WriteLine("\n" + petname + "'s Current Status\nENERGY LEVEL: 8= High 0= Low --------> " + Energy + "\nSKILL LEVEL: 0+ ---------------------> " + SkillLevel + "\nFOOD STOCK QUANTITY: 0+ -------------> " + Food + "\nHUNGER LEVEL: 3= Full 0= Starving ---> " + Hunger+ "\n");
        }

        public void Play()
        {
            Console.WriteLine("\nYou have chosen to " + play + " with " + petname + "!");
            int[] playtimes = { 10, 15, 20, 30, 60 };
            Random randomnum = new Random();
            int howMuchPlay = playtimes[randomnum.Next(playtimes.Length)];
            Console.WriteLine("After playing with " + petname + " for " + howMuchPlay + " minutes he/she is now: ");
            this.energy = runningenergy--;
            this.skilllevel = runningSkillLevel;
            this.food = runningfood;
            this.hunger = runninghunger--;
            EnergyLimits();
            HungerLimits();
            StatusDisplay();
            Warning();
        }
        public void Train()
        {
            Console.WriteLine("\nYou have chosen to " + train + " " + petname + "!");
            Console.WriteLine("Congrats, every time you train, you gain a new skill level!\nUnfortunately, training exhausts all of your Energy.");
            this.runningenergy = 0;
            this.energy = this.runningenergy;
            this.food = this.runningfood;
            this.hunger = this.runninghunger--;
            this.skilllevel =this. runningSkillLevel++;
            EnergyLimits();
            HungerLimits();
            StatusDisplay();
            Warning();
        }
        public void Hunt()
        {
            Console.WriteLine("\nYou have chosen for " + petname + " to " + hunt + "!\nYour Dragon finds food!");
            this.runningenergy = this.runningenergy - 2;
            this.energy = runningenergy;
            this.food = this.runningfood++;
            this.hunger = this.runninghunger;
            this.skilllevel = this.runningSkillLevel;
            EnergyLimits();
            HungerLimits();
            StatusDisplay();
            Warning();
        }
        public void Eat()
        {
            Console.WriteLine("\nYou have chosen to " + feed + " " + petname + "!\nYour Dragon is so full and energetic now.");
            this.runningenergy = runningenergy + 2;
            this.energy = runningenergy;
            this.food = this.runningfood--;
            runninghunger = 3;
            this.hunger = this.runninghunger;
            this.skilllevel = this.runningSkillLevel;
            EnergyLimits();
            HungerLimits();
            StatusDisplay();
            Warning();
        }
        public void Fly()
        {
            Console.WriteLine("\nYou have chosen for " + petname + " to " + fly + "!\nYour Dragon traveled to a new Land!");
            this.runningenergy = this.runningenergy - 2;
            this.energy = runningenergy;
            this.food = this.runningfood;
            this.hunger = this.runninghunger--;
            this.skilllevel = this.runningSkillLevel;
            EnergyLimits();
            HungerLimits();
            StatusDisplay();
            Warning();
        }
        public void SleepMethod()
        {
            Console.WriteLine("\nYou have chosen for " + petname + " to go to " + sleepmethod + "!\n"+ petname+ " now has full energy!");
            this.runningenergy = 8;
            this.energy = this.runningenergy;
            this.food = this.runningfood;
            this.hunger = this.runninghunger;
            this.skilllevel = this.runningSkillLevel;
            EnergyLimits();
            HungerLimits();
            StatusDisplay();
            Warning();
        }
        public void Warning()
        {
            if (this.runningenergy == 0)
            {
                Console.WriteLine("Warning! Your Dragons Energy is depleted. " + petname + " MUST Sleep or Eat!\n(*If it goes below zero, you will lose the game.)\n");
            }
            if(this.runningfood ==0)
            {
                Console.WriteLine("Warning! Your Dragon has no Food Stock! " +petname+ " needs to Hunt!\n(*If you eat without food stock you will lose the game.)\n");
            }
            if (this.runningSkillLevel== 0)
            {
                Console.WriteLine("Warning! Your Dragon has no Skills! Train " + petname + " to gain new skills.\n");
            }
            if (this.runninghunger <=1 && this.runninghunger >=0)
            {
                Console.WriteLine("Warning! Your Dragon is hungry! Feed " + petname + " to resolve hunger.\n(*If it goes below zero, you will lose the game.)\n");
            }
        }
        public int EnergyLimits()
        {
            if (this.energy > 8)
            {
                this.runningenergy = 8;
            }
            return this.runningenergy;
        }
        public int HungerLimits()
        {
            if (this.hunger > 3)
            {
                this.runninghunger = 3;
            }
            return this.runningenergy;
        }
        //public int FoodLimits()
        //{
        //    if (this.food <= 0)
        //    {
        //        this.runningfood = 0;
        //    }
        //    return this.runningfood;
        //}
    }
    }



