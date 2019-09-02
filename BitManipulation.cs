namespace Data_Structures___Algorithms
{ 
    public class BitManipulation {
        
        public bool IsPowerOfTwo(int n)
        {
            if (n < 1) return false;
            else
            {
                long num = n;
                return (num & (2 * num - 1)) == num;
            }
        }

    }
}