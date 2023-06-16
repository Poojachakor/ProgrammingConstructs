namespace ProgrammingConstructsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value for n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Powers of 2 up to 2^{0}:", n);

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("2^{0} = {1}", i, Math.Pow(2, i));
            }

        }

    }



}
    
