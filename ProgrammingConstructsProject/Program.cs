namespace ProgrammingConstructsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());

            int largestNumber = GetLargestNumber(number1, number2, number3);
            Console.WriteLine("The largest number is: " + largestNumber);
        }

        static int GetLargestNumber(int num1, int num2, int num3)
        {
            int largest = num1;

            if (num2 > largest)
            {
                largest = num2;
            }

            if (num3 > largest)
            {
                largest = num3;
            }

            return largest;
        }
    }

    
    
}