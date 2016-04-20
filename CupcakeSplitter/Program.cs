using System;

namespace CupcakeSplitter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
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
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't split cupcakes with zero people!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please type a whole number!");
            }
            finally
            {
                Console.WriteLine("Thanks for playing!");
            }

            Console.WriteLine("Now the program is ending");

        }
    }
}
