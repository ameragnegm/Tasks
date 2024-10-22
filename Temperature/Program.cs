namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the temperature in Celsius");
            double Celsius = Convert.ToDouble(Console.ReadLine());
            double F = Celsius*(9.0/5.0)+32 ;
            Console.WriteLine($"{Celsius} degrees Celsius is {F} degrees Fahrenheit.");
        }
    }
}
