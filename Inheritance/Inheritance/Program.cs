using System;

namespace Inheritance
{
    class Car //base class
    {
        private string name;

        public void set_name(string name)
        {
            this.name = name;
        }

        public string get_name()
        {
            return this.name;
        }
    }

    class Bus : Car
    {
        public void display()
        {
            Console.WriteLine(this.get_name()); //calling base class method to access private field of base class
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bus b = new Bus();
            b.set_name("hudai");
            b.display();
        }
    }
}
