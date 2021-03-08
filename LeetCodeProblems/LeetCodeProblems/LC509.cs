using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems {
    class LC509 {
        public static int Fib(int n) {
            int res = F(n);
            return res;
        }
        private static int F(int n) {
            if (n < 2) {
                return n;
            }
            return F(n - 1) + F(n - 2);
        }
    }
}

