using Services;

TreeNode root = new TreeNode(1)
{
    rightval = new TreeNode(2)
    {
        rightval = new TreeNode(3)
        {
            rightval = new TreeNode(4)
        }
    }
};



List<int> result = Solution.GetRightmostNodes(root);

Console.WriteLine(string.Join(", ", result));
