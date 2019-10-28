using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Trie
    {
        TrieNode root;

        public Trie() 
        {
            root = new TrieNode();
        }

        public void Insert(string str)
        {
            TrieNode curNode = root;

            for (int i = 0; i < str.Length; i++)
            {
                int index = str[i] - 'a';

                if (curNode.children[index] == null)
                    curNode.children[index] = new TrieNode();

                curNode = curNode.children[index];
            }

            curNode.isEndOfWord = true;
        }

        public bool Contains(string str, bool fullWordSearch = false)
        {
            TrieNode curNode = root;

            for (int i = 0; i < str.Length; i++)
            {
                int index = str[i] - 'a';
                if (curNode.children[index] == null)
                    return false;

                curNode = curNode.children[index];
            }

            if(fullWordSearch)
                return curNode != null && curNode.isEndOfWord;

            return curNode != null;
        }
    }

    class TrieNode
    {
        public TrieNode[] children;
        public const int ALPHABET = 26;
        public bool isEndOfWord;

        public TrieNode()
        {
            children = new TrieNode[ALPHABET];
            isEndOfWord = false;
        }
    }
}
