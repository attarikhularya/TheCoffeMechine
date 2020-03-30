using System;
using TheCoffeMechine;

namespace TheCoffeMenchine
{
    class Program
    {
        static void Main(string[] args)
        {

            CoffePowder coffe = new CoffePowder(100);
            WaterMilk milk = new WaterMilk(100);
            WaterGalon water = new WaterGalon(1000);
            CoffeMechine yummyCoffe = new CoffeMechine(coffe, water, milk);

            Console.WriteLine("check "+ yummyCoffe.checkAvailabili());
            String result = yummyCoffe.makeCappucino();
            Console.WriteLine("result "+result);

            Console.WriteLine("check " + yummyCoffe.checkAvailabili());
            result = yummyCoffe.makeCappucino();
            Console.WriteLine("result " + result);

            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            Console.WriteLine("check " + yummyCoffe.checkAvailability());

        }
    }
}
