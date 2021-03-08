using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems {
    class DefangIPaddr {
        public static string Defang(string address) {
            return address.Replace(".", "[.]");
        }
    }
}
