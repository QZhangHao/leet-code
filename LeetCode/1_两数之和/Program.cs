using System;

namespace _1_两数之和
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in TwoSum(new int[] { 2, 7, 11, 15 },18))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 暴力枚举
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums,int target)
        {
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];
        }
    }
}
