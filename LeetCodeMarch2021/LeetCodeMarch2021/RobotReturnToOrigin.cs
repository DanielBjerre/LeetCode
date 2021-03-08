using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMarch2021 {
    class RobotReturnToOrigin {
        public static bool JudgeCirlce(string moves) {
            int y = 0;
            int x = 0;
            int length = moves.Length;
            int count = 0;
            for (int i = 0; i < length; i++) {
                switch (moves[i]) {
                    case 'U':
                        y++;
                        break;
                    case 'D':
                        y--;
                        break;
                    case 'L':
                        x--;
                        break;
                    case 'R':
                        x++;
                        break;
                    default:
                        break;
                }
                count++;
                if (count > length / 2 && count != length) {
                    if (y > length / 2 || y < length / 2 || x > length / 2 || x < length / 2) {
                        return false;
                    }
                }
            }
            return y == 0 && x == 0;
        }
    }
}
