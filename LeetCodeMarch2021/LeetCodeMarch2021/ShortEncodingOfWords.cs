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
            Node root = new Node('\0');

            foreach (string word in words) {
                Insert(word);
            }

            void Insert(string word) {
                Node curr = root;
                for (int i = 0; i < word.Length; i++) {
                    char c = word[i];
                    if (curr.Children[c - 'a'] == null) {
                        curr.Children[c - 'a'] = new Node(c);
                    }
                    curr = curr.Children[c - 'a'];
                }
                curr.isWord = true;
            }
            return 0;
        }

        class Node {
            public char Val { get; set; }
            public bool isWord { get; set; } = false;
            public Node[] Children { get; } = new Node[26];
            
            public Node(char val) {
                this.Val = val;
            }
        }
    }
}
