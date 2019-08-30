namespace Data_Structures___Algorithms
{
    public class Binary
    {
        public static int HammingWeight(uint n)
        {
            int result = 0;
            while (n != 0)
            {
                result++;
                n &= (n - 1);
            }
            return result;
        }

        public static int[] CountBits(int num)
        {
            int[] result = new int[num + 1];

            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0) result[i] = result[i / 2];
                else result[i] = result[i - 1] + 1;
            }

            return result;
        }

        public static int GetSum(int a, int b)
        {
            if (a == 0) return b;
            else if (b == 0) return a;
            else
            {
                return GetSum(a ^ b, (a & b) << 1);
            }
        }
    }
}