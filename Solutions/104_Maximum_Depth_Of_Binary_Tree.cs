//https://leetcode.com/problems/maximum-depth-of-binary-tree/description/
namespace Algorithms.Solutions
{
    public class Maximum_Depth_Of_Binary_Tree
    {
        public int MaxDepth(TreeNode root)
        {
            var counterLeft = 0;
            var counterRight = 0;

            if (root == null)
            {
                return 0;
            }

            if (root.left == null && root.right == null)
            {
                return
                1;
            }

            if (root.left != null)
            {
                counterLeft += 1;
            }

            if (root.right != null)
            {
                counterRight += 1;
            }

            return MaxDepth(root, counterLeft, counterRight);
        }

        public int MaxDepth(TreeNode root, int counterLeft, int counterRight)
        {
            if (root.left != null)
            {
                counterLeft = MaxDepth(root.left, counterLeft + 1, counterRight);
            }
            if (root.right != null)
            {
                counterRight = MaxDepth(root.right, counterLeft, counterRight + 1);
            }

            return counterRight > counterLeft ? counterRight : counterLeft;
        }

        public int Correct_MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);

            return Math.Max(left, right) + 1;
        }
    }
}


 public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         this.val = val;
         this.left = left;
         this.right = right;
     }
 }
 