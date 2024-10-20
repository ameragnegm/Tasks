namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the temperature in Celsius");
            double Celsius = double.Parse(Console.ReadLine());
            double F = Celsius*(9.0/5.0)+32 ;
            Console.WriteLine($"The temperature in Fahrenheit is {F}");
        }
    }
}
