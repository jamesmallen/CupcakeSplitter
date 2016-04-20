using System;

namespace CupcakeSplitter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many cupcakes do you have?");
            int cupcakes = int.Parse(Console.ReadLine());
            Console.WriteLine("How many people are sharing?");
            int people = int.Parse(Console.ReadLine());

            int cupcakesPerPerson = cupcakes / people;

            int remainingCupcakes = cupcakes % people;

            Console.WriteLine("Each person gets {0} cupcakes, and there are {1} left over.",
                              cupcakesPerPerson, remainingCupcakes);

        }
    }
}
