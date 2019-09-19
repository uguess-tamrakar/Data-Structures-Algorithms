using System.Collections.Generic;
using System.Linq;

namespace Data_Structures___Algorithms
{
    public class TimeMap
    {
        private Dictionary<string, SortedList<int, string>> _Map;
        /** Initialize your data structure here. */
        public TimeMap()
        {
            _Map = new Dictionary<string, SortedList<int, string>>();
        }

        public void Set(string key, string value, int timestamp)
        {
            if (!_Map.ContainsKey(key)) _Map.Add(key, new SortedList<int, string>());
            _Map[key].Add(timestamp, value);
        }

        public string Get(string key, int timestamp)
        {
            if (!_Map.ContainsKey(key)) return string.Empty;
            else {
                int closestMatch = BinarySearch(_Map[key].Keys, timestamp);
                if (closestMatch != -1) return _Map[key][closestMatch];
                else return string.Empty;
            }
        }

        public int BinarySearch(IList<int> timestamps, int target)
        {
            int result = -1;
            int left = 0;
            int right = timestamps.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int midTimeStamp = timestamps[mid];

                if (midTimeStamp == target)
                {
                    result = midTimeStamp;
                    break;
                }
                else if (midTimeStamp < target)
                {
                    result = midTimeStamp;
                    left = mid + 1;
                }
                else right = mid - 1;
            }

            return result;
        }
    }
}