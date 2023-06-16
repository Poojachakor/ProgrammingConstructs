namespace ProgrammingConstructsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial = CalculateFactorial(number);

            Console.WriteLine("Factorial of {0} is: {1}", number, factorial);
        }

        static int CalculateFactorial(int n)
        {
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }

}


        
