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

        //properties
        public string Energy { get; set; }
        public string SkillLevel { get; set; }
        public string Food { get; set; }
        public string Hunger { get; set; }
        public string Tired { get; set; }

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

        //methods
       
        public void MenuDisplayNameandDragon ()
        {
            Console.WriteLine("Interaction Menu: " + petname + " The " + pet_type);
        }
        public void Play ()
        {

        }
        public void Train ()
        {

        }
        public void Hunt ()
        {

        }
        public void Eat ()
        {

        }
        public void Fly()
        {

        }
        public void Sleep ()
        {

        }
        public void Bathroom()
        {

        }
    }
}

