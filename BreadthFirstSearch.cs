using System.Collections.Generic;
using System.Text;

namespace Data_Structures___Algorithms
{
    public class BreadthFirstSearch
    {
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            Dictionary<string, List<IList<string>>> results = new Dictionary<string, List<IList<string>>>();
            if (wordList.Contains(endWord) && beginWord.Length == endWord.Length)
            {
                Dictionary<string, HashSet<string>> patterns = new Dictionary<string, HashSet<string>>();
                patterns.Add(beginWord, ProducePatterns(beginWord));

                foreach (string word in wordList)
                {
                    if (!patterns.ContainsKey(word)) patterns.Add(word, ProducePatterns(word));
                }

                // breadth first search to store matching patterns
                Queue<string> Matches = new Queue<string>();
                HashSet<string> Matched = new HashSet<string>();

                Matches.Enqueue(beginWord);
                results.Add(beginWord, new List<IList<string>>() { new List<string>() { beginWord } });

                while (Matches.Count > 0)
                {
                    string current = Matches.Dequeue();

                    if (!current.Equals(endWord))
                    {
                        if (!Matched.Contains(current))
                        {
                            Matched.Add(current);

                            foreach (string pattern in patterns[current])
                            {
                                foreach (KeyValuePair<string, HashSet<string>> kvp in patterns)
                                {
                                    if (kvp.Value.Contains(pattern))
                                    {
                                        if (!Matched.Contains(kvp.Key))
                                        {
                                            foreach (var result in results[current])
                                            {
                                                List<string> list = new List<string>(result);
                                                list.Add(kvp.Key);

                                                if (!results.ContainsKey(kvp.Key))
                                                {
                                                    results.Add(kvp.Key, new List<IList<string>>() { list });
                                                }
                                                else if (results[kvp.Key][0].Count >= list.Count)
                                                {
                                                    results[kvp.Key].Add(list);
                                                }
                                            }

                                            Matches.Enqueue(kvp.Key);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        return results[endWord];
                    }
                }
            }

            return new List<IList<string>>();
        }

        private HashSet<string> ProducePatterns(string word)
        {
            HashSet<string> result = new HashSet<string>();
            for (int i = 0; i < word.Length; i++)
            {
                StringBuilder temp = new StringBuilder(word);
                temp[i] = '*';
                result.Add(temp.ToString());
            }
            return result;
        }
    }
}