using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    using System;
    using System.Collections.Generic;

    public class TreeNode
    {
        public int value;

        public TreeNode(int value)
        {
            this.value = value;
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
                }
            }

            return result;
        }
    }

}
