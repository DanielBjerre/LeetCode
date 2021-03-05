using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMarch2021 {
    class MissingNumber {
        public static int Number(int[] nums) {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++) {
                if(i != nums[i]) {
                    return i;
                }
            }
            return nums.Length;
        }
    }
}
