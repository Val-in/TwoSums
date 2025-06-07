namespace TwoSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums0 = { 2, 7, 11, 15 };
            int target0 = 9;

            int[] result0 = Solution.TwoSum0(nums0, target0);

            Console.WriteLine("[" + result0[0] + ", " + result0[1] + "]");

            int[] nums1 = { 3, 2, 4 };
            int target1 = 6;

            int[] result1 = Solution.TwoSum1(nums1, target1);

            Console.WriteLine("[" + result1[0] + ", " + result1[1] + "]");

            int[] nums2 = { 3, 3 };
            int target2 = 6;

            int[] result2 = Solution.TwoSum2(nums2, target2);

            Console.WriteLine("[" + result2[0] + ", " + result2[1] + "]");
        }

        public class Solution
        {
            static public int[] TwoSum0(int[] nums0, int target0)
            {
                for (int i = 0; i < nums0.Length; i++)
                {
                    for (int j = i + 1; j < nums0.Length; j++)
                    {
                        if (nums0[i] + nums0[j] == target0)
                        {
                            return new int[] { i, j }; //почему тут можно упростить?
                        }
                    }
                }
                return new int[] { }; //почему тут можно упростить?
            }

            static public int[] TwoSum1(int[] nums1, int target1)
            {
                for (int i = 0; i < nums1.Length; i++)
                {
                    for (int j = i + 1; j < nums1.Length; j++)
                    {
                        if (nums1[i] + nums1[j] == target1)
                        {
                            return new int[] { i, j }; //почему тут можно упростить?
                        }
                    }
                }
                return new int[] { }; //почему тут можно упростить?
            }

            static public int[] TwoSum2(int[] nums2, int target2)
            {
                for (int i = 0; i < nums2.Length; i++)
                {
                    for (int j = i + 1; j < nums2.Length; j++)
                    {
                        if (nums2[i] + nums2[j] == target2)
                        {
                            return new int[] { i, j }; //почему тут можно упростить?
                        }
                    }
                }
                return new int[] { }; //почему тут можно упростить?
            }
        }
    }
}
