using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace ProgrammingConstructsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int headsCount = 0;
            int tailsCount = 0;
            Random random = new Random();

            while (headsCount < 20 && tailsCount < 20)
            {
                int flip = random.Next(2); // 0 represents heads, 1 represents tails

                if (flip == 0)
                {
                    headsCount++;
                    Console.WriteLine("Heads");
                }
                else
                {
                    tailsCount++;
                    Console.WriteLine("Tails");
                }

                if (headsCount == 20 || tailsCount == 20)
                {
                    break;
                }
            }

            if (headsCount == 20)
            {
                Console.WriteLine("Heads wins!");
            }
            else
            {
                Console.WriteLine("Tails wins!");
            }

            Console.ReadLine();
        }
    }
    






}




