using System;
using System.Collections.Generic;

namespace Data_Structures___Algorithms
{
    public class ArraySolution
    {

        public static int MaxSubArray(int[] nums)
        {
            int result = int.MinValue;
            int currentMax = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currentMax += nums[i];

                if (result < currentMax) result = currentMax;
                if (currentMax < 0) currentMax = 0;
            }

            return result;
        }

        public static bool CanJump(int[] nums)
        {
            if (nums.Length == 1) return true;
            else if (nums.Length == 2)
            {
                if (nums[0] > 0) return true;
                else return false;
            }
            else
            {
                int lastPos = nums.Length - 1;
                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    if (i + nums[i] >= lastPos)
                    {
                        lastPos = i;
                    }
                }
                return lastPos == 0;
            }
        }

        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;

            if (prices.Length > 1)
            {
                int minPrice = int.MaxValue;
                int currentPrice = minPrice;
                int currentProfit = 0;
                for (int i = 0; i < prices.Length; i++)
                {
                    currentPrice = prices[i];
                    currentProfit = currentPrice - minPrice;
                    if (currentPrice < minPrice)
                    {
                        minPrice = currentPrice;
                    }
                    else if (currentProfit > maxProfit)
                    {
                        maxProfit = currentProfit;
                    }
                }
            }

            return maxProfit;
        }

        public static int MaxProduct(int[] nums)
        {
            int result = nums[0];
            int max = 0;
            int min = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                if (num == 0)
                {
                    result = Math.Max(nums[i], result);
                    max = 0;
                    min = 0;
                    continue;
                }

                if (num > 0)
                {
                    max = max == 0 ? num : max * num;
                    min = min * num;
                }

                if (num < 0)
                {
                    int tempMax = max;
                    max = min * num;
                    min = tempMax == 0 ? num : tempMax * num;
                }

                if (max != 0)
                {
                    result = Math.Max(result, max);
                }
            }

            return result;
        }

        public static int FindMin(int[] nums)
        {
            int mid = nums.Length / 2;
            int left = 0;
            int right = nums.Length - 1;
            int min = nums[mid];

            if (nums[right] > nums[left] || mid == left)
            {
                return nums[0];
            }

            while (right >= left)
            {
                mid = left + (right - left) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    return nums[mid + 1];
                }

                if (nums[mid] < nums[mid - 1])
                {
                    return nums[mid];
                }

                if (nums[mid] > nums[0])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return min;
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> distinct = new HashSet<int>(nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                if (distinct.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    distinct.Add(nums[i]);
                }
            }
            return false;
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];

            result[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = nums[i - 1] * result[i - 1];
            }

            int prod = 1;
            for (int i = nums.Length - 1; i > -1; i--)
            {
                result[i] = prod * result[i];
                prod *= nums[i];
            }
            return result;
        }

        public static int MissingNumber(int[] nums)
        {
            int expectedSum = (nums.Length * (nums.Length + 1)) / 2;
            int actualSum = 0;
            foreach (int num in nums)
            {
                actualSum += num;
            }
            return expectedSum - actualSum;
        }

    }
}