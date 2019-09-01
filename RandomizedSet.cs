using System;
using System.Collections.Generic;

namespace Data_Structures___Algorithms
{
    public class RandomizedSet
    {
        private List<int> Set;

        /** Initialize your data structure here. */
        public RandomizedSet()
        {
            Set = new List<int>();
        }

        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val)
        {
            if (Set.Contains(val)) return false;
            else {
                Set.Add(val);
                return true;
            }
        }

        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val)
        {
            if (Set.Contains(val)) {
                Set.Remove(val);
                return true;
            }
            else return false;
        }

        /** Get a random element from the set. */
        public int GetRandom()
        {
            int result = 0;

            if (Set.Count == 1) {
                result = Set[0];
            }
            else if (Set.Count > 1)
            {
                Random Randomizer = new Random();
                int RandomIndex = Randomizer.Next(Set.Count);
                result = Set[RandomIndex];
            }

            return result;
        }
    }
}