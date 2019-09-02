using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Data_Structures___Algorithms
{
    public class CombinationSum
    {
        public int[] TwoSumBruteForce(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result = new int[] { i, j };
                        break;
                    }
                }
            }

            return result;
        }

        public int[] TwoSumTwoPassHashTable(int[] nums, int target)
        {
            int[] result = new int[2];

            Dictionary<int, int> dict = new Dictionary<int, int>(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                dict.TryAdd(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (dict.ContainsKey(complement) && i != dict[complement])
                {
                    result = new int[] { i, dict[complement] };
                    break;
                }
            }

            return result;
        }

        public int[] TwoSumOnePassHashTable(int[] nums, int target)
        {
            int[] result = new int[2];

            Dictionary<int, int> dict = new Dictionary<int, int>(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                {
                    result = new int[] { dict[complement], i };
                    break;
                }

                dict.TryAdd(nums[i], i);
            }

            return result;
        }

        public int HourglassSum(int[][] arr)
        {
            int result = int.MinValue;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr[i].Length - 2; j++)
                {
                    int sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2];
                    sum += arr[i + 1][j + 1];
                    sum += arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    if (sum > result)
                    {
                        result = sum;
                    }
                }
            }

            return result;
        }

        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            // sort the candidates such that 
            System.Array.Sort(candidates);
            BackTrack(candidates, result, new List<int>(), 0, target);
            return result;
        }

        private void BackTrack(int[] candidates, IList<IList<int>> result, List<int> currentCombination, int startIndex, int target)
        {
            // if target is 0, we found our combination
            if (target == 0)
            {
                result.Add(new List<int>(currentCombination));
                return;
            }

            // loop through candidates and find combination that sums to target
            for (int i = startIndex; i < candidates.Length; i++)
            {
                if (i == startIndex || candidates[i] != candidates[i - 1])
                {
                    int newTarget = target - candidates[i];
                    // if new target is still positive, recursively continue to find other combinations
                    if (newTarget >= 0)
                    {
                        currentCombination.Add(candidates[i]);
                        BackTrack(candidates, result, currentCombination, i + 1, newTarget);
                        currentCombination.RemoveAt(currentCombination.Count - 1);
                    }
                    // else combination sum is already greater than target, so break
                    else
                    {
                        break;
                    }
                }
            }
        }

        public int CombinationSum4(int[] nums, int target)
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

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (nums.Length >= 3)
            {
                Array.Sort(nums);

                for (int i = 0; i < nums.Length; i++)
                {
                    if (i != 0 && nums[i - 1] == nums[i]) continue;
                    int left = i + 1;
                    int right = nums.Length - 1;
                    int num = nums[i];

                    while (left < right)
                    {
                        int sum = (nums[left] + num + nums[right]);
                        if (sum == 0)
                        {
                            result.Add(new List<int>() { nums[left], num, nums[right] });
                            while (left < right && nums[left] == nums[left + 1]) left++;
                            while (left < right && nums[right] == nums[right - 1]) right--;
                            left++;
                            right--;
                        }
                        else if (sum < 0) left++;
                        else right--;
                    }
                }

                if (result == null) result.Add(new List<int>());
            }

            return result;
        }

        private void FindCombination(int[] nums, IList<IList<int>> result, List<int> currentCombination, int index)
        {
             // if current combination count is 3 and...
            if (currentCombination.Count == 3)
            {
                // sum is zero then add to result
                if (currentCombination[0] + currentCombination[1] + currentCombination[2] == 0) result.Add(new List<int>(currentCombination));
                return;
            }

            // loop through nums and add to current combination 
            for (int i = index; i < nums.Length; i++)
            {
                if (i == index || nums[i] != nums[i - 1])
                {
                    // add till the total until total is 3
                    if (currentCombination.Count < 3)
                    {
                        currentCombination.Add(nums[i]);
                        FindCombination(nums, result, currentCombination, i + 1);
                        currentCombination.RemoveAt(currentCombination.Count - 1);
                    }
                    // else break
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}