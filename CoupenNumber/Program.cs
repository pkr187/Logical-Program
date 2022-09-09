using System.Text;

namespace CoupenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ALPHABET = "AG8FOLE2WVTCPY5ZH3NIUDBXSMQK7946";
            static string couponCode(uint number)
            {
                StringBuilder b = new StringBuilder();
                for (int i = 0; i < 6; ++i)
                {
                    b.Append(ALPHABET[(int)number & ((1 << 5) - 1)]);
                    number = number >> 5;
                }
                return b.ToString();
            }
            static uint codeFromCoupon(string coupon)
            {
                uint n = 0;
                for (int i = 0; i < 6; ++i)
                    n = n | (((uint)ALPHABET.IndexOf(coupon[i])) << (5 * i));
                return n;
            }
        }
    }
}