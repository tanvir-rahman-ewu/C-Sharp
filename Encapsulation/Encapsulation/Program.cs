using System;

namespace Encapsulation
{
    public class Car
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
    class Program
    {
        // to keep sensetive data make field as private and access them through public method of same class
        // this is called encapsulation
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car c = new Car();
            c.set_name("Ferrari");

            string name = c.get_name();

            Console.WriteLine(name);
        }
    }
}
