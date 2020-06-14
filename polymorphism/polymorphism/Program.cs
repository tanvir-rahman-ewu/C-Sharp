using System;

namespace polymorphism
{
    //we cant create instance of abstract class rather we can use it as reference
    abstract class Animal //its quite like interface
    {
        public abstract void sound();
    }

    class Cow : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Hambaaaa");
        }
    }

    class Goat : Animal
    {
        public override void sound()
        {
            Console.WriteLine("mee mee");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Animal cow = new Cow();
            Animal goat = new Goat();
            

            cow.sound();
            goat.sound();
        }
    }
}
