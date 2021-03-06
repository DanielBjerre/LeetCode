using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMarch2021 {
    class ShortEncodingOfWords {
        public static int Shortest(string[] words) {
            Array.Sort(words, (x, y) => y.Length.CompareTo(x.Length));
            string res = "";
            int len = words.Length;
            for (int i = 0; i < len; i++) {
                if (!res.Contains($"{words[i]}#")) {
                    res += ($"{words[i]}#");
                }
            }
            return res.Length;
        }

        public static int Shortest2(string[] words) {
            TrieNode root = new TrieNode { Val = '#' };
            

            string res = "";
            int len = words.Length;
            int[] indices = new int[len];
            for (int i = 0; i < len; i++) {
                int index = res.IndexOf($"{words[i]}#");
                if (index != -1) {
                    indices[i] = index;
                } else {
                    indices[i] = res.Length;
                    res += ($"{words[i]}#");
                }
            }
            return res.Length;
        }

        internal class TrieNode {
            public char Val { get; set; }
            public HashSet<TrieNode> Children { get; }
            public bool EndOfWord { get; set; }
        }
    }
}
