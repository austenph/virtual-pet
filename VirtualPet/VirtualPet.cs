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
        private string energy;
        private int skilllevel;
        private string food;
        private string sleep;
        private string hunger;
        private string play;
        private string train;
        private string hunt;
        private string feed;
        private string fly;
        private string sleepmethod;
        private int runningSkillLevel;
        private int tracking;
        private int tracker;

        //properties
        
      public int Tracking
        {
            get { return this.tracker; }
            set { this.tracking = value; }
        }
        public string Energy
        {
            get { return this.energy; }
            set { this.energy = value; }
        }
        public int SkillLevel
        {
            get { return this.runningSkillLevel; }
            set { this.skilllevel = value; }
        }
        public string Food
        {
            get { return this.food; }
            set { this.food = value; }
        }
        public string Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }
        public string Sleep
        {
            get { return this.sleep; }
            set { this.sleep = value; }
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
        }
        public VirtualPet(string pet_type, string energy, int skilllevel, string food, string hunger, string sleep)
        {
            this.pet_type = pet_type;
            this.energy = energy;
            this.skilllevel = skilllevel;
            this.food = food;
            this.hunger = hunger;
            this.sleep = sleep;
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
        public void PrintTrack ()
        { 
                if(this.tracking==2)
                {
                    Console.WriteLine("***Congrats you are now a Teenager Dragon!***\n");
                }
                if (this.tracking == 5)
                {
                    Console.WriteLine("***Wooh! You are now an Adult Dragon!***\n");
                }
                    if(this.tracking == 8)
                    {
                        Console.WriteLine("***Dragons, they grow up so fast. You are now an Elder Dragon.***\n");
                    }
            }

        public void MenuDisplayNameandDragon()
        {
            Console.WriteLine("Interactive Menu: " + petname + " The " + pet_type);
        }
        public void StatusDisplay()
        {
            Console.WriteLine("\n" + petname + "'s Current Status\nEnergy Level: " + Energy + "\nSkill Level: " + SkillLevel + "\nFood Stock Level: " + Food + "\nHunger Level: " + Hunger + "\nSleep Level: " + Sleep + "\n");
        }

        public void Play()
        {
            Console.WriteLine("You have chosen to " + play + " with " + petname + "!");
            int[] playtimes = { 10, 15, 20, 30, 60 };
            Random randomnum = new Random();
            int howMuchPlay = playtimes[randomnum.Next(playtimes.Length)];
            Console.WriteLine("\nAfter playing with " + petname + " for " + howMuchPlay + " minutes he/she is now: ");
            this.energy = "Medium Energy";
            this.skilllevel = runningSkillLevel;
            this.food = "No Change";
            this.hunger = "Hungry";
            this.sleep = "Sleepy";
            StatusDisplay();
            Console.WriteLine("Base on " + petname + "'s Status, what would you like to do now?");
        }
        public void Train()
        {
            Console.WriteLine("You have chosen to " + train + " " + petname + "!");
            Console.WriteLine("Congrats, every time you train, you gain a new skill level!");
            this.energy = "Medium Energy";
            this.food = "No Change";
            this.hunger = "Hungry";
            this.sleep = "No Change";
            this.skilllevel = runningSkillLevel++;
            StatusDisplay();
           
            Console.WriteLine("Base on " + petname + "'s Status, what would you like to do now?");
           
        }
        public void Hunt()
        {
            Console.WriteLine("You have chosen for " + petname + " to " + hunt + "!");
            this.energy = "Drained Energy";
            this.skilllevel = runningSkillLevel;
            this.food = "Full Food Storage";
            this.hunger = "Hungry";
            this.sleep = "No Change";
            StatusDisplay();
            Console.WriteLine("Base on " + petname + "'s Status, what would you like to do now?");
        }
        public void Eat()
        {
            Console.WriteLine("You have chosen to " + feed + " " + petname + "!");
            this.energy = "Full Energy";
            this.skilllevel = runningSkillLevel;
            this.food = "No Food Storage";
            this.hunger = "Full";
            this.sleep = "Sleepy";
            StatusDisplay();
            Console.WriteLine("Base on " + petname + "'s Status, what would you like to do now?");
        }
        public void Fly()
        {
            Console.WriteLine("You have chosen for " + petname + " to " + fly + "!");
            this.energy = "Drained Energy";
            this.skilllevel = runningSkillLevel;
            this.food = "No Change";
            this.hunger = "No Change";
            this.sleep = "No Change";
            StatusDisplay();
            Console.WriteLine("Base on " + petname + "'s Status, what would you like to do now?");
        }
        public void SleepMethod()
        {
            Console.WriteLine("You have chosen for " + petname + " to go to " + sleepmethod + "!");
            this.energy = "Full Energy";
            this.skilllevel = runningSkillLevel;
            this.food = "No Change";
            this.hunger = "No Change";
            this.sleep = "Not Sleepy";
            StatusDisplay();
            Console.WriteLine("Base on " + petname + "'s Status, what would you like to do now?");
        }
     
        }
    }


