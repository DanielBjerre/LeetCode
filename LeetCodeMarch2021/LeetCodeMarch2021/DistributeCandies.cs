using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMarch2021 {
    class DistributeCandies {
        public static int Amount(int[] candyType) {
            HashSet<int> candyTypes = new HashSet<int>(candyType);
            if(candyType.Length / 2 <= candyTypes.Count) {
                return candyType.Length / 2;
            } else {
                return candyTypes.Count;
            }  
        } 
    }
}
