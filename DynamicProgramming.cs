using System;
using System.Collections.Generic;
using System.Linq;

namespace Data_Structures___Algorithms
{
    public class DynamicProgramming
    {
        public static int Rob(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            if (nums.Length == 2) return Math.Max(nums[0], nums[1]);
            if (nums.Length == 3) return nums[1];

            int maxval = Math.Max(RobInternal(nums, nums.Length - 1), RobInternal(nums, nums.Length - 2));

            return maxval;
        }

        private static int RobInternal(int[] nums, int end)
        {
            int[] dp = new int[nums.Length + 1];
            dp[0] = nums[0];
            dp[1] = nums[1];
            dp[2] = nums[2] + nums[0];
            int maxval = Math.Max(dp[1], dp[2]);

            for (int i = 3; i < end; i++)
            {
                dp[i] = nums[i] + Math.Max(dp[i - 3], dp[i - 2]);
                if (maxval < dp[i]) maxval = dp[i];
            }

            return maxval;
        }

        public static int ClimbStairs(int n)
        {
            int result = n;

            if (n > 1)
            {
                int[] dp = new int[n + 1];
                dp[1] = 1;
                dp[2] = 2;

                for (int i = 3; i <= n; i++)
                {
                    dp[i] = dp[i - 1] + dp[i - 2];
                }

                result = dp[n];
            }

            return result;
        }

        public static int Fibonacci(int n)
        {
            int result = n;

            if (n > 1)
            {
                int[] dp = new int[n + 1];
                dp[1] = 1;
                dp[2] = 1;

                for (int i = 3; i <= n; i++)
                {
                    dp[i] = dp[i - 1] + dp[i - 2];
                }
                result = dp[n];
            }

            return result;
        }

        public static int CoinChange(int[] coins, int amount)
        {
            int result = 0;

            if (amount > 0)
            {
                for (int i = coins.Length - 1; i >= 0; i--)
                {
                    if (coins[i] <= amount)
                    {
                        result += amount / coins[i];
                        amount = amount % coins[i];
                    }
                }

                // if there is still remaining amount then 
                // no denomination found to turn remaining into coins
                if (amount > 0)
                {
                    result = -1;
                }
            }

            return result;
        }

        public static int coinChange(int[] coins, int amount)
        {
            int max = amount + 1;
            int[] dp = new int[amount + 1];
            System.Array.Fill(dp, max);

            dp[0] = 0;
            for (int i = 1; i <= amount; i++)
            {
                for (int j = 0; j < coins.Length; j++)
                {
                    if (coins[j] <= i)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
                    }
                }
            }
            return dp[amount] > amount ? -1 : dp[amount];
        }

        public static int LengthOfLIS(int[] nums)
        {
            int result = 0;

            if (nums.Length > 0)
            {
                int[] dp = new int[nums.Length];
                dp[0] = 1;
                result = 1;

                for (int i = 1; i < dp.Length; i++)
                {
                    int maxVal = 0;
                    for (int j = 0; j < i; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            maxVal = Math.Max(maxVal, dp[j]);
                        }
                    }

                    dp[i] = maxVal + 1;
                    result = Math.Max(result, dp[i]);
                }
            }

            return result;
        }

        public static bool WordBreak(string s, IList<string> wordDict)
        {
            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;

            for (int i = 1; i < dp.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int length = i - j;
                    if (dp[j] && wordDict.Contains(s.Substring(j, length)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[s.Length];
        }

        public static int CombinationSum4(int[] nums, int target)
        {
            if (nums.Length == 0 || target == 0) return 0;
            System.Array.Sort(nums);

            int[] dp = new int[target + 1];
            dp[0] = 1;

            for (int i = 1; i < dp.Length; i++)
            {
                int total = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] <= i)
                    {
                        total += (dp[i - nums[j]]);
                    }
                    else
                    {
                        break;
                    }
                }

                dp[i] = total;
            }

            return dp.Last();
        }
  
    }
}