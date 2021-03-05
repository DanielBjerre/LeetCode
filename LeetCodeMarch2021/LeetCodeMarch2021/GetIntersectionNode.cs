using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMarch2021 {
    class GetIntersectionNode {
        public static ListNode GetNode(ListNode headA, ListNode headB) {
            HashSet<ListNode> nodesInA = new HashSet<ListNode>();

            while (headA != null) {
                nodesInA.Add(headA);
                headA = headA.next;
            }

            while (headB != null) {
                if (nodesInA.Contains(headB)) {
                    return headB;
                }
                headB = headB.next;
            }
            return null;
        }
    }
}
