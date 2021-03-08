using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMarch2021 {
    class MyHashMap2 {
        /** Initialize your data structure here. */
        readonly int?[] data;

        public MyHashMap2() {
            data = new int?[1000001];
        }

        /** value will always be non-negative. */
        public void Put(int key, int value) {
            data[key] = value;
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key) {
            return data[key] == null ? -1 : data[key].Value;
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key) {
            data[key] = null;
        }
    }
}
