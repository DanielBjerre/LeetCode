using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeJanuary2021 {
    class CanFormArray {
        public static bool Check(int[] arr, int[][] pieces) {
            HashSet<int> usedPieceIndex = new();
            int currentArrIndex = 0;
            bool pieceFits;

            for (int i = 0; i < pieces.Length;) {
                pieceFits = false;
                if (!usedPieceIndex.Contains(i)) {
                    for (int j = 0; j < pieces[i].Length; j++) {
                        if (pieces[i][j] == arr[currentArrIndex]) {
                            pieceFits = true;
                            currentArrIndex++;
                        } else if (pieceFits) {
                            return false;
                        } else {
                            break;
                        }
                    }
                }
                if (pieceFits) {
                    usedPieceIndex.Add(i);
                    if (usedPieceIndex.Count == pieces.Length) {
                        return true;
                    }
                    i = 0;
                } else {
                    i++;
                }

            }
            return false;
        }

    }
}
