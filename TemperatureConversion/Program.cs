namespace TemperatureConversion
{
    internal class TemperatureConversion
    {
        static void Main(string[] args)
        {
            TemperatureConversion  temp = new TemperatureConversion();
            Console.Write("please provide celsius Temp");
            string val1 = Console.ReadLine();
            double Fehrenheit = temp.CelsiusToFehrenheit(val1);
            Console.WriteLine($"the value to {val1} celsius is {Fehrenheit}Fehrenheit");

            Console.Write("please provide celsius Temp:");
            string val2 = Console.ReadLine();
            double celsius = temp.CelsiusToFehrenheit(val2);
            Console.WriteLine($"the value to {val2} celsius is {celsius}Fehrenheit");
        }

        private double CelsiusToFehrenheit(string? val2)
        {
            throw new NotImplementedException();
        }
    }
}
        
    
