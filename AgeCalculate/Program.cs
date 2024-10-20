namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth year :");
            int year = int.Parse(Console.ReadLine());
            int age = 2024 - year;
            Console.WriteLine($"You are {age} years old .");
        }
    }
}
