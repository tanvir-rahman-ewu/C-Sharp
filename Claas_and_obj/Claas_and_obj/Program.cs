using System;

namespace Claas_and_obj
{
    class Television
    {
        private string name { get; set; }
        private int price { get; set; }

        public Television(string name, int price) //constructor
        {
            this.name = name;
            this.price = price;
        }

        public void display()
        {
            Console.WriteLine(this.price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Television tv = new Television("sda",10);
            tv.display();

            
        }
    }
}
