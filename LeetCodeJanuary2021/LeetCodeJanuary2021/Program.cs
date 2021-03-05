using System;

namespace LeetCodeJanuary2021 {
    class Program {
        static void Main(string[] args) {
            int[] arr = new int[] { 15, 88, 16, 22 };
            int[][] pieces = {
                new int[] {88},
                new int[] {15},
                new int[] {16, 22}
            };

            Console.WriteLine(CanFormArray.Check(arr, pieces));
            Console.Read();
        }
    }
}
