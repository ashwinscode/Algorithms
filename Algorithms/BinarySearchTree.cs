public class BinarySearchTree
{
    public TreeNode head;

    public BinarySearchTree()
    {
        head = new TreeNode(100);
        head.left = new TreeNode(50);
        head.left.left = new TreeNode(25);
        head.left.right = new TreeNode(35);
        head.left.right.left = new TreeNode(30);
        head.right = new TreeNode(150);
        head.right.left = new TreeNode(125);
        head.right.right = new TreeNode(175);
    }

    public void Insertion(int d)
    {
        if (head == null)
        {
            head = new TreeNode(d);
            return;
        }

        TreeNode travel = head;
        TreeNode parent = travel;
        while(travel != null)
        {
            parent = travel;
            if (d <= parent.d)
                travel = parent.left;
            else
                travel = parent.right;
        }

        if(d <= parent.d) 
            parent.left = new TreeNode(d);
        else
            parent.right = new TreeNode(d);
    }

    public int HeightOfTree(TreeNode node)
    {
        if (node == null) return 0;
        var leftHeight = HeightOfTree(node.left);
        var rightHeight = HeightOfTree(node.right);

        return Math.Max(leftHeight, rightHeight) + 1;
    }
}