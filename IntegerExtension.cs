using System;

namespace Data_Structures___Algorithms
{
    public static class IntegerExtensions
    {
        public static int Reverse(this int x) {
            long result = 0;
            
            while (x != 0) {
                result = result * 10 + x % 10;
                x /= 10;
            }

            return (result < int.MinValue || result > int.MaxValue) ? 0 : (int)result;
        }

        public static bool IsPalindrome(this int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0)) return false;
            else
            {
                int revertedNumber = 0;
                while (x > revertedNumber) {
                    revertedNumber = revertedNumber * 10 + x % 10;
                    x /= 10;
                }

                return x == revertedNumber || x == revertedNumber / 10;
            }
        }
    }
}