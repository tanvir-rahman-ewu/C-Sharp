using System;

namespace property
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();

            c.Name = "Ferrari";
            c.Price = 10000000;

            Console.WriteLine($"the price of {c.Name} is {c.Price}");

            Television tv = new Television();

            tv.set_name("Gold Star");
            tv.set_price(10000);

            Console.WriteLine($"The price of {tv.get_name()} is {tv.get_price()}");
        }
    }
}
