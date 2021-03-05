using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMarch2021 {
    public class AverageLevels {
        public static IList<double> Average(TreeNode root) {
            IList<double> res = new List<double>();
            HashSet<TreeNode> current = new HashSet<TreeNode>();
            HashSet<TreeNode> next = new HashSet<TreeNode>();
            current.Add(root);

            while(current.Count > 0) { 
                double val = 0;
                foreach (TreeNode node in current.ToList()) {
                    val += node.val;
                    if (node.left != null) {
                        next.Add(node.left);
                    }
                    if (node.right != null) {
                        next.Add(node.right);
                    }
                }
                res.Add(val/current.Count);
                current = new HashSet<TreeNode>(next);
                next.Clear();

            }
            return res;
        }

    }
}
