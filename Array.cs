using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Data_Structures___Algorithms
{
    public class ArraySolution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[2];
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    int leftPos = mid;
                    while (leftPos > -1 && nums[leftPos] == target)
                    {
                        leftPos--;
                    }
                    result[0] = leftPos + 1;

                    int rightPos = mid;
                    while (rightPos < nums.Length && nums[rightPos] == target)
                    {
                        rightPos++;
                    }
                    result[1] = rightPos - 1;

                    return result;
                }
                else if (nums[mid] < target) left = mid + 1;
                else if (nums[mid] > target) right = mid - 1;
            }

            result[0] = -1;
            result[1] = -1;
            return result;
        }

        public int[] BubbleSort(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                        result++;
                    }
                }
            }
            return arr;
        }
        public List<List<int>> optimalUtilization(int deviceCapacity, List<List<int>> f, List<List<int>> b)
        {
            f.Sort();
            b.Sort();

            List<List<int>> result = new List<List<int>>();

            f = f.OrderBy(app => app[1]).ToList();

            return result;
        }

        public List<int> IDsOfSongs(int rideDuration, List<int> songDurations)
        {
            List<int> result = new List<int>(2);


            return result;
        }

        public int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];

            Dictionary<int, int> dict = new Dictionary<int, int>(numbers.Length);
            for (int i = 0; i < numbers.Length; i++)
            {
                int complement = target - numbers[i];
                if (dict.ContainsKey(complement))
                {
                    result[0] = ++dict[complement];
                    result[1] = ++i;
                    break;
                }
                dict.TryAdd(numbers[i], i);
            }

            return result;
        }

        public int FindTreasureIsland(char[][] island)
        {
            if (island == null || island.Length == 0) return 0;

            int[] treasureIsland = TreasureIsland(island);
            if (treasureIsland == null) return 0;
            return FindShortestRoute(island, treasureIsland);
        }

        private int FindShortestRoute(char[][] input, int[] treasureisland)
        {
            int route = 0;
            int row = 0;
            int col = 0;
            int targetX = treasureisland[0];
            int targetY = treasureisland[1];

            while (row >= 0 && row < input.Length && col >= 0 && col < input[row].Length)
            {
                if (row == targetX && col == targetY) break;
                else
                {
                    if (row < targetX && input[row + 1][col] != 'D' && row + 1 <= input.Length - 1)
                    {
                        row++;
                        route++;
                    }
                    else if (col < targetY && input[row][col + 1] != 'D' && col + 1 <= input[row].Length - 1)
                    {
                        col++;
                        route++;
                    }
                    else if (row > targetX && input[row - 1][col] != 'D' && row - 1 >= 0)
                    {
                        row--;
                        route++;
                    }
                    else if (col > targetY && input[row][col - 1] != 'D' && col - 1 >= 0)
                    {
                        col--;
                        route++;
                    }
                    else
                    {
                        col++;
                        route++;
                    }
                }
            }

            return route;
        }

        private int[] TreasureIsland(char[][] island)
        {
            int[] result = new int[2];
            for (int i = 0; i < island.Length; i++)
            {
                for (int j = 0; j < island[i].Length; j++)
                {
                    if (island[i][j] == 'X')
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }

        // Find an element from a and an element from b such that the sum
        // of their values is less than or equal to target and as closet as possible to target.
        public IList<IList<int>> GetSumClosestToTarget(IList<IList<int>> a, IList<IList<int>> b, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < a.Count; i++)
            {
                dict.Add(a[i][0], a[i][1]);
            }

            //int closestSum = 0;
            for (int j = 0; j < b.Count; j++)
            {
                int compliment = target - b[j][1];
            }

            return result;
        }

        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            GetSubset(0, nums, new List<int>(), result);
            return result;
        }

        private void GetSubset(int index, int[] nums, List<int> current, IList<IList<int>> result)
        {
            result.Add(new List<int>(current));
            for (int i = index; i < nums.Length; i++)
            {
                current.Add(nums[i]);
                GetSubset(i + 1, nums, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }

        // K Closest Points to Origin
        public int[][] KClosest(int[][] points, int K)
        {
            int[] dists = new int[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                dists[i] = distance(points[i]);
            }
            Array.Sort(dists);

            int distK = dists[K - 1];
            int[][] result = new int[K][];
            int index = 0;

            for (int i = 0; i < points.Length; ++i)
            {
                if (distance(points[i]) <= distK) result[index++] = points[i];
            }

            return result;
        }

        private int distance(int[] point)
        {
            return point[0] * point[0] + point[1] * point[1];
        }

        // remove the given value - val from the nums array
        // val could be appended to the end of given array
        public int RemoveElement(int[] nums, int val)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index++] = nums[i];
                }
            }
            return index;
        }

        public int SingleNumber(int[] nums)
        {
            if (nums.Length < 1) return 0;
            List<int> list = new List<int>();
            foreach (int num in nums)
            {
                if (list.Contains(num)) list.Remove(num);
                else list.Add(num);
            }

            return list[0];
        }

        public int SingleNumber2(int[] nums)
        {
            int result = 0;

            if (nums.Length == 1) result = nums[0];
            else if (nums.Length > 1)
            {
                int singleIndex = -1;
                Array.Sort(nums);
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] == nums[i + 1]) i++;
                    else
                    {
                        singleIndex = i;
                        break;
                    }
                }

                if (singleIndex == -1) singleIndex = nums.Length - 1;

                result = nums[singleIndex];
            }

            return result;
        }

        public void SetZeroes(int[][] matrix)
        {
            bool isColumn = false;
            int rowCount = matrix.Length;
            int columnCount = matrix[0].Length;

            for (int i = 0; i < rowCount; i++)
            {
                if (matrix[i][0] == 0) isColumn = true;

                for (int j = 1; j < columnCount; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            for (int i = 1; i < rowCount; i++)
            {
                for (int j = 1; j < columnCount; j++)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0) matrix[i][j] = 0;
                }
            }

            if (matrix[0][0] == 0)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    matrix[0][j] = 0;
                }
            }

            if (isColumn)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    matrix[i][0] = 0;
                }
            }
        }

        public static bool Exist(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == word[0] && Dfs(board, i, j, 0, word)) return true;
                }
            }

            return false;
        }

        private static bool Dfs(char[][] board, int i, int j, int count, string word)
        {
            if (count == word.Length) return true;
            if (i < 0 || i >= board.Length || j < 0 || j >= board[i].Length || board[i][j] != word[count]) return false;
            char temp = board[i][j];
            board[i][j] = ' ';
            bool found = Dfs(board, i + 1, j, count + 1, word)
            || Dfs(board, i - 1, j, count + 1, word)
            || Dfs(board, i, j + 1, count + 1, word)
            || Dfs(board, i, j - 1, count + 1, word);
            board[i][j] = temp;
            return found;
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n > 0)
            {
                foreach (int num in nums2)
                {
                    nums1[m++] = num;
                }
                Array.Sort(nums1);
            }
        }

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