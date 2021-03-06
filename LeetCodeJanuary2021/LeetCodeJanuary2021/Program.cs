using System;

namespace LeetCodeJanuary2021 {
    class Program {
        static void Main(string[] args) {
            //CanFormArrayP();
            GetTargetCopyP();
        }
        private static void CanFormArrayP() {
            int[] arr = new int[] { 15, 88, 16, 22 };
            int[][] pieces = {
                new int[] {88},
                new int[] {15},
                new int[] {16, 22}
            };
            Console.WriteLine(CanFormArray.Check(arr, pieces));
        }
        private static void GetTargetCopyP() {


            TreeNode twoOne = new TreeNode { val = 6 };
            TreeNode twoTwo = new TreeNode { val = 19 };

            TreeNode oneOne = new TreeNode { val = 4 };
            TreeNode oneTwo = new TreeNode { val = 3, left = twoOne, right = twoTwo };

            TreeNode original = new TreeNode { val = 7, left = oneOne, right = oneTwo };

            TreeNode twoOneC = new TreeNode { val = 6 };
            TreeNode twoTwoC = new TreeNode { val = 19 };

            TreeNode oneOneC = new TreeNode { val = 4 };
            TreeNode oneTwoC = new TreeNode { val = 3, left = twoOneC, right = twoTwoC };

            TreeNode clone = new TreeNode { val = 7, left = oneOneC, right = oneTwoC };




            TreeNode res = GetTargetCopy.Copy(original, clone, oneTwo);





        }
    }

}
