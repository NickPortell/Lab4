using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string result, response = "y";
            bool valid;

            Console.WriteLine("Learn your squares and cubes!");

            while (response == "y")
            {
                Console.Write("\nEnter an integer: ");
                result = Console.ReadLine();

                valid = int.TryParse(result, out num);

                if (valid)
                {
                    Console.WriteLine("\nNumber \tSquared Cubed");
                    Console.WriteLine("====== \t====== \t======");

                    for(int i = 1; i <= num; i++)
                    {
                        Console.WriteLine(i + " \t" + (i * i) + " \t" + (i * i * i));
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an integer.");
                }

                Console.Write("\nContinue? (y/n): ");
                response = Console.ReadLine();
            }
        }
    }
}
