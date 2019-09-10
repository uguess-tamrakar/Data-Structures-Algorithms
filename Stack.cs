using System;
using System.Collections.Generic;

namespace Data_Structures___Algorithms
{
    public class StackSolution
    {
        public void Test()
        {
            int n = 65578;
            Stack<int> stack = new Stack<int>();
            while (n > 0)
            {
                stack.Push(n % 2);
                n = n / 2;
            }

            int consecutive = 0;
            int max = 0;
            while (stack.Count > 0)
            {
                if (stack.Pop() == 1)
                {
                    consecutive++;
                    max = Math.Max(max, consecutive);
                }
                else
                {
                    consecutive = 0;
                }
            }

            string Max = max.ToString();
        }
    }
}