namespace ProgrammingConstructsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input the marks obtained in Physics: ");
            int physicsMarks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry: ");
            int chemistryMarks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Mathematics: ");
            int mathMarks = Convert.ToInt32(Console.ReadLine());

            if (mathMarks >= 65 && physicsMarks >= 55 && chemistryMarks >= 50 && (mathMarks + physicsMarks + chemistryMarks) >= 180)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else if (mathMarks >= 65 && (physicsMarks + chemistryMarks) >= 140)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }

}