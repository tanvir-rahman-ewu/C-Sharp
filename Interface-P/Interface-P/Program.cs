using System;
using Interface_P.Factory;

namespace Interface_P
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryCreate f = new FactoryCreate();

            Icalculator c = f.create();

            Console.WriteLine(c.add(5, 5));
        }
    }
}
