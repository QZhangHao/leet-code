using System;

namespace _7_整数反转
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(reverse(231));
        }

        public static int reverse(int num)
        {
            int ans = 0;
            while (num != 0)
            {
                if ((ans * 10) / 10 != ans)
                {
                    ans =0;
                    break;
                }
                ans = ans * 10 + num % 10;
                num = num / 10;
            }
            return ans;
        }
    }
}
