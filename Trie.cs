using System.Collections.Generic;

namespace Data_Structures___Algorithms
{
    public class Trie
    {
        /** Initialize your data structure here. */
        private TrieNode _Root;

        public Trie()
        {
            _Root = new TrieNode();
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            TrieNode CurrentNode = _Root;

            foreach (char c in word)
            {
                if (!CurrentNode.ContainsKey(c))
                {
                    CurrentNode.Insert(c);
                }

                CurrentNode = CurrentNode[c];
            }

            CurrentNode.IsEnd = true;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            TrieNode node = RetrievePrefixNode(word);
            return node != null && node.IsEnd;
        }

        private TrieNode RetrievePrefixNode(string prefix)
        {
            TrieNode CurrentNode = _Root;

            foreach (char c in prefix)
            {
                if (CurrentNode.ContainsKey(c))
                {
                    CurrentNode = CurrentNode[c];
                }
                else
                {
                    CurrentNode = null;
                    break;
                }
            }

            return CurrentNode;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix) => RetrievePrefixNode(prefix) != null;
    }

    public class TrieNode
    {
        private Dictionary<char, TrieNode> _Nodes;

        public TrieNode this[char c]
        {
            get
            {
                TrieNode result = null;
                if (_Nodes.ContainsKey(c))
                {
                    result = _Nodes[c];
                }

                return result;
            }
            set
            {
                _Nodes[c] = value;
            }
        }

        public bool IsEnd { get; set; }

        public TrieNode()
        {
            _Nodes = new Dictionary<char, TrieNode>();
        }

        public bool ContainsKey(char c) => _Nodes.ContainsKey(c);

        public void Insert(char c) => _Nodes[c] = new TrieNode();
    }
}