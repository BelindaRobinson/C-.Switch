using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numbergen = new Random();

            int num01 = numbergen.Next(1,11);
            int num02 = numbergen.Next(1,11);

            Console.WriteLine("what is " + num01 + "times" + num02 + "?");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == num01 * num02)
            {
                Console.WriteLine("Well done");
            }
            else
            {
                int response = numbergen.Next(1, 4);

                switch (response)
                {
                    case 1:
                        Console.WriteLine("Are you even trying?");
                        break;
                    case 2:
                        Console.WriteLine("incorrect");
                        break;
                    default:
                        Console.WriteLine("you can do better");
                        break;
                }
                
            }
            Console.ReadKey();
        }
    }
}
