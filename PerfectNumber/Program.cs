namespace PerfectNumber
{
    public class PerfectNum
    {
        public static int Find_Factors(int input)
        {
            int sum = 0;
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    sum = sum = i;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("please provide input value");
            int input = int.Parse(Console.ReadLine());
            int result = Find_Factors(input);
            if (input == result)
            {
                Console.WriteLine($"{input} is perfect number");
            }
            else
            {
                Console.WriteLine($"{input} is not perfect number");

            }

        }
    }
}
    
