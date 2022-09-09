namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 123456789;
            int result = 0;
            int rem;
            while (num != 0)
            {
                rem = num % 10;
                result = result * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
       
    
