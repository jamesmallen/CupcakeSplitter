using System;

namespace CupcakeSplitter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("How many cupcakes do you have?");
            int cupcakes = -1;
            while (!(int.TryParse(Console.ReadLine(), out cupcakes) && cupcakes > 0))
            {
                Console.WriteLine("Please enter a whole number!");
            }

            Console.WriteLine("How many people are sharing?");
            int people = 0;

            while (!(int.TryParse(Console.ReadLine(), out people) && people > 0))
            {
                Console.WriteLine("Please enter a whole number!");
            }


            try
            {
                int cupcakesPerPerson = cupcakes / people;

                int remainingCupcakes = cupcakes % people;

                Console.WriteLine("Each person gets {0} cupcakes, and there are {1} left over.",
                    cupcakesPerPerson, remainingCupcakes);
            }
            finally
            {
                Console.WriteLine("Thanks for playing!");
            }
                
        }
    }
}
