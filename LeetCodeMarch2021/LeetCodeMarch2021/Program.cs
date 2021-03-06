using System;
using System.Collections.Generic;

namespace LeetCodeMarch2021 {
    class Program {
        static void Main(string[] args) {
            //DistributeCandiesP(new int[] { 1, 1, 1, 1, 3, 3 });
            //SetMismatchP(new int[] { 1, 1});
            //MissingNumberP(new int[] { 0, 1 });
            //AverageLevelsP();
            ShortEncodingOfWordsP();
        }

        private static void ShortEncodingOfWordsP() {
            string[] words = new string[] {
                "time", "me", "bell"
            };
            ShortEncodingOfWords.Shortest2(words);
        }

        private static void AverageLevelsP() {
            TreeNode threeTwo = new TreeNode {
                val = 7
            };
            TreeNode threeOne = new TreeNode {
                val = 15
            };
            TreeNode twoOne = new TreeNode {
                val = 9
            };
            TreeNode twoTwo = new TreeNode {
                val = 20,
                left = threeOne,
                right = threeTwo
            };
            TreeNode root = new TreeNode {
                val = 3,
                left = twoOne,
                right = twoTwo
            };
            IList<double> res = AverageLevels.Average(root);
            foreach (double average in res) {
                Console.WriteLine(average);
            }
        }


        private static void MissingNumberP(int[] nums) {
            Console.WriteLine(MissingNumber.Number(nums));
        }

        private static void SetMismatchP(int[] nums) {
            int[] result = SetMismatch.MisMatch(nums);
            Console.WriteLine($"{result[0]}, {result[1]}");
        }

        private static void DistributeCandiesP(int[] candyType) {
            Console.WriteLine(DistributeCandies.Amount(candyType));
        }

    }
}
