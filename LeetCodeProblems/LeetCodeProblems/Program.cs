using System;

namespace LeetCodeProblems {
    class Program {
        static void Main(string[] args) {
            DefangIPaddrP();
            LC509p();
        }

        private static void LC509p() {
            Console.WriteLine(LC509.Fib(4));
        }

        private static void DefangIPaddrP() {
            Console.WriteLine(DefangIPaddr.Defang("255.100.50.0"));
        }
    }
}
