using System;
using System.Collections.Generic;

namespace Interface
{
    public interface IAnimal
    {
        void voice();
    }

    public class Animal : IAnimal
    {
        public Animal( string val)
        {
            name = val;
        }
        public string name { get; set; }
        public void voice()
        {
            Console.WriteLine("I am Animal");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
             IAnimal a = new Animal("Hati");

             a.voice();

            Animal cat = new Animal("Hamba");



            List<Animal> l = new List<Animal>
            {
                new Animal("goru"),
                new Animal("hash"),
                new Animal("murgi")
            };

            foreach( Animal b in l)
            {
                b.voice();
                Console.WriteLine(b.name);
            }
        }
    }
}
