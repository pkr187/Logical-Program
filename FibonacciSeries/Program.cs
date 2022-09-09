namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1, num3, range;
            Console.WriteLine("Enter tne range : ");
            range = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + " ");
            Console.WriteLine(num2 + " ");
            while (range > 1)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3 + " ");
                num1 = num2;
                num2 = num3;
                range--;
            }
            Console.ReadLine();
        }
    }
}
    
