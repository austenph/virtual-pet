using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
       public enum LifeCycle {Baby, Tween, Teen, Adult};

        //fields
        private string petname;
        private string pet_type;
        private string energy;
        private string skilllevel;
        private string food;
        private string sleep;
        private string hunger;
        private string play;
        private string train;
        private string hunt;
        private string feed;
        private string fly;
        private string sleepmethod;
       
        //properties
        public string Energy
        {
            get { return this.energy; }
            set { this.energy = value; }
        }
        public string SkillLevel
        { get { return this.skilllevel; }
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
            get {return this.petname; }
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
        public VirtualPet (string pet_type)
        {
            this.pet_type = pet_type;
        }
        public VirtualPet (string pet_type, string energy, string skilllevel, string food, string hunger, string sleep)
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
        

        public void MenuDisplayNameandDragon ()
        {
            Console.WriteLine("Interactive Menu: " + petname + " The " + pet_type);
        }
        public void StatusDisplay ()
        {
            Console.WriteLine("\n" + petname+ "'s Current Status\nEnergy Level: " + Energy + "\nSkill Level: " + SkillLevel + "\nFood Stock Level: " + Food + "\nHunger Level: " + Hunger + "\nSleep Level: " + Sleep +"\n");
    }
        
        public void Play()
        {
             Console.WriteLine("\nYou have chosen to " + play + " with " + petname + "!");
            int[] playtimes = { 10, 15, 20, 30, 60 };
            Random randomnum = new Random();
            int howMuchPlay = playtimes[randomnum.Next(playtimes.Length)];
            Console.WriteLine("\nAfter playing with " + petname + " for " + howMuchPlay + " minutes he/she is now: ");
            StatusDisplay();
            Console.WriteLine("Base on " + petname + "'s Status, what would you like to do now?");
            this.energy = "Medium Energy";
            this.skilllevel = "No Change";
            this.food = "No Change";
            this.hunger = "Hungry";
            this.sleep = "Sleepy";

    }
        public void Train()
        {
            Console.WriteLine("\nYou have chosen to " + train+  " " + petname + "!");
            StatusDisplay();
            Console.WriteLine("Base on " + petname + "'s Status, what would you like to do now?");
            this.energy = "Medium Energy";
            this.skilllevel = "New Skill Level Achieved!";
            this.food = "No Change";
            this.hunger = "Hungry";
            this.sleep = "No Change";
        }
        public void Hunt()
        {
            Console.WriteLine("\nYou have chosen for " + petname + " to " + hunt+ "!");
            StatusDisplay();
            Console.WriteLine("Base on " + petname + "'s Status, what would you like to do now?");
            this.energy = "Drained Energy";
            this.skilllevel = "No Change";
            this.food = "Full Food Storage";
            this.hunger = "Hungry";
            this.sleep = "No Change";
        }
        public void Eat()
        {
            Console.WriteLine("\nYou have chosen to " + feed + " " + petname + "!");
            StatusDisplay();
            Console.WriteLine("Base on " + petname + "'s Status, what would you like to do now?");
            this.energy = "Full Energy";
            this.skilllevel = "No Change";
            this.food = "No Food Storage";
            this.hunger = "Full";
            this.sleep = "Sleepy";
        }
        public void Fly()
        {
            Console.WriteLine("\nYou have chosen for " + petname + " to " +fly+ "!");
            StatusDisplay();
            Console.WriteLine("Base on " + petname + "'s Status, what would you like to do now?");
            this.energy = "Drained Energy";
            this.skilllevel = "New Skill Level Achieved!";
            this.food = "No Change";
            this.hunger = "No Change";
            this.sleep = "No Change";
        }
        public void SleepMethod()
        {
            Console.WriteLine("\nYou have chosen for " + petname + " to go to "+sleep + "!");
            StatusDisplay();
            Console.WriteLine("Base on " + petname + "'s Status, what would you like to do now?");
            this.energy = "Full Energy";
            this.skilllevel = "No Change";
            this.food = "No Change";
            this.hunger = "No Change";
            this.sleep = "Not Sleepy";
        }
    }
}

