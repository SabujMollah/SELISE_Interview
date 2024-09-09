using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TreeNode
    {
        public int value;
        public TreeNode leftval;
        public TreeNode rightval;

        public TreeNode(int value)
        {
            this.value = value;
            leftval = null;
            rightval = null;
        }
    }

    public class Solution
    {
        public static List<int> GetRightmostNodes(TreeNode root)
        {
            List<int> result = new List<int>();
            if (root == null) return result;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode currentNode = queue.Dequeue();

                    if (i == levelSize - 1)
                    {
                        result.Add(currentNode.value);
                    }

                    if (currentNode.leftval != null)
                    {
                        queue.Enqueue(currentNode.leftval);
                    }

                    if (currentNode.rightval != null)
                    {
                        queue.Enqueue(currentNode.rightval);
                    }
                }
            }

            return result;
        }
    }
}
