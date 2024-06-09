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

//как упростить код?
// Can you come up with an algorithm that is less than time complexity?O(n2)
//Hint 1
//A really brute force way would be to search for all possible pairs of numbers but that would be too slow. Again, it's best to try out brute
//force solutions for just for completeness. It is from these brute force solutions that you can come up with optimizations.
//Hint 2
//So, if we fix one of the numbers, say, we have to scan the entire array to find the next number which is where value is the input parameter.
//Can we change our array somehow so that this search becomes faster?xyvalue - x
//Hint 3
//The second train of thought is, without changing the array, can we use additional space somehow? Like maybe a hash map to speed up the search?
