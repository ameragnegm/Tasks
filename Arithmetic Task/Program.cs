namespace Arithmetic_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine(" Enter your numbers");
            num1 =   Convert.ToDouble(Console.ReadLine());
            num2= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The sum: {num1 + num2}\nThe difference: {num1 - num2}\nThe product: {num1 * num2}\nThe division: {num1 / num2}");

        }
    }
}
 