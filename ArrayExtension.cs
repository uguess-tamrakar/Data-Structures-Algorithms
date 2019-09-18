using System;
using System.Collections.Generic;
using System.Linq;

namespace Data_Structures___Algorithms
{
    public static class ArrayExtensions
    {
        public static bool HasIncreasingTriplet(this int[] nums) {
            bool result = false;

            int smallest = int.MaxValue;
            int smaller = int.MaxValue;
            foreach (int num in nums)
            {
                if (num <= smallest) smallest = num;
                else if (num < smaller) smaller = num;
                else if (num > smaller) result = true;
            }

            return result;
        }

        public static IList<IList<int>> ThreeSumToZero(this int[] nums) {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);
            // Call recursive function to find three nums sum to zero
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    ThreeSumInternal(i, i + 1, nums.Length - 1, nums, result);
                }
            }
            if (result == null) result.Add(new List<int>());
            return result;
        }

        private static void ThreeSumInternal(int current, int left, int right, int[] nums, IList<IList<int>> triplets)
        {
            if (left < right)
            {
                int sum = nums[left] + nums[current] + nums[right];
                // if sum of three nums is zero then add the triplets to the list
                if (sum == 0)
                {
                    triplets.Add(new List<int>() { nums[left], nums[current], nums[right] });
                    left++;
                    right--;
                    while (left < right && nums[left] == nums[left - 1]) left++;
                    while (left < right && nums[right] == nums[right + 1]) right--;
                    ThreeSumInternal(current, left, right, nums, triplets);
                }
                // if sum is greater than 0 and there index is not at first go left index by one less step
                else if (sum > 0) ThreeSumInternal(current, left, --right, nums, triplets);
                // if sum is less than 0 and there index is not at last go right index by one more step
                else if (sum < 0) ThreeSumInternal(current, ++left, right, nums, triplets);
            }
        }
    }
}