using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMarch2021 {
    class MyHashMap {
        /** Initialize your data structure here. */
        readonly List<Kvp> data;


        public MyHashMap() {
            data = new List<Kvp>();
        }

        /** value will always be non-negative. */
        public void Put(int key, int value) {
            foreach (Kvp kvp in data) {
                if (kvp.Key == key) {
                    kvp.Value = value;
                    return;
                } 
            }
            data.Add(new Kvp { Key = key, Value = value });
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key) {
            foreach (Kvp kvp in data) {
                if(kvp.Key == key) {
                    return kvp.Value;
                }
            }
            return -1;
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key) {
            foreach (Kvp kvp in data) {
                if (kvp.Key == key) {
                    data.Remove(kvp);
                    return;
                }
            }
        }
        class Kvp {
            public int Key { get; set; }
            public int Value { get; set; }
        }
    }
}
