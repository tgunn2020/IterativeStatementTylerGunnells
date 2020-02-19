using System;

namespace IterativeStatementTylerGunnells
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, " + "\n");

            Console.WriteLine("Please enter a Integer between 2 and 10.");

            int inputValue; 
            
            while (!int.TryParse(Console.ReadLine(), out inputValue))
            {
                if (inputValue <= 1 && inputValue >= 11)
                {
                    Console.Clear();
                    Console.WriteLine("\n" + "Please enter an integer between 2 and 10.");
                }  
            }

            if (inputValue % 2 == 1)
            {
                int j = 0;
                Console.WriteLine("\n" + "You Entered the Value: " + inputValue);

                while (j < inputValue -1)
                {
                    Console.WriteLine("You entered an odd number");
                    j++;
                }

            }

            else if (inputValue % 2 == 0)

            {
                int i = 0;
                Console.WriteLine("\n" + "You Entered the Value:" + inputValue);

                while (i < inputValue + 1)
                {
                    Console.WriteLine("You entered an even number");
                    i++;
                }
              
            }
        }
    }
}
