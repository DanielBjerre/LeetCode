using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeJanuary2021 {
    class GetTargetCopy {
        public static TreeNode Copy(TreeNode original, TreeNode cloned, TreeNode target) {
            Queue<TreeNode> queueO = new Queue<TreeNode>();
            queueO.Enqueue(original);
            Queue<TreeNode> queueC = new Queue<TreeNode>();
            queueC.Enqueue(cloned);

            while (queueO.Count != 0) {
                TreeNode tempO = queueO.Dequeue();
                TreeNode tempC = queueC.Dequeue();

                if (tempO == target) {
                    return tempC;
                }
                if (tempO.left != null) {
                    queueO.Enqueue(tempO.left);
                    queueC.Enqueue(tempC.left);
                }
                if (tempO.right != null) {
                    queueO.Enqueue(tempO.right);
                    queueC.Enqueue(tempC.right);
                }
            }
            return null;
        }
    }
}
