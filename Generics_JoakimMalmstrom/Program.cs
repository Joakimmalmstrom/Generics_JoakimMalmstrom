using System;
using System.Net.Http.Headers;

namespace Generics_JoakimMalmstrom
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var box = new Box<string>();
                //var box = new Box<int>();

                // Test with string
                box.AddToStack("Daniel");
                box.AddToStack("Johan");
                box.AddToStack("Bertil");
                box.AddToStack("Johanna");

                // Test with int
                //box.AddToStack(5);
                //box.AddToStack(2);
                //box.AddToStack(3);
                //box.AddToStack(1);
                //box.AddToStack(1);
                //box.AddToStack(15);

                Console.WriteLine($"The stack count is: {box.Count}");
                Console.WriteLine($"Element {box.Remove()} removed from the stack");
                Console.WriteLine($"The stack count is: {box.Count}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
