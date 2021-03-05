using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMarch2021 {
    class SetMismatch {
        public static int[] MisMatch(int[] nums) {
            HashSet<int> set = new HashSet<int>();
            int twice = 0;
            int missing = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (set.Contains(nums[i])) {
                    twice = nums[i];
                } else {
                    set.Add(nums[i]);
                }
            }
            for (int i = 1; i <= set.Count+1; i++) {
                if(!set.Contains(i)) {
                    missing = i;
                    break;
                }
            }
            return new int[] { twice, missing };
        }
    }
}
