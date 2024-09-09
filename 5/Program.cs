using Services;

TreeNode root = new TreeNode(1)
{
    leftval = new TreeNode(2)
    {
        leftval = new TreeNode(3)
        {
            leftval = new TreeNode(4)
        }
    }
};

List<int> result = Solution.GetRightmostNodes(root);


Console.WriteLine(string.Join(", ", result));

