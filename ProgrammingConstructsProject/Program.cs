namespace ProgrammingConstructsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (N): ");
            int N = int.Parse(Console.ReadLine());

            int sumOfSquares = 0;
            for (int i = 1; i <= N; i++)
            {
                sumOfSquares += i * i;
            }

            Console.WriteLine("The sum of squares of the first {0} numbers is: {1}", N, sumOfSquares);
        }

    }

    
}




    
