public class BinaryTree
{
    public TreeNode head;

    public BinaryTree()
    {
        head = new TreeNode(10);
        head.left = new TreeNode(12);
        head.right = new TreeNode(15);
        head.left.left = new TreeNode(25);
        head.left.right = new TreeNode(30);
        head.right.left = new TreeNode(36);
    }

    public void InOrder(TreeNode? node)
    {
        if(node  == null) return;
        InOrder(node.left);
        Console.Write(node.d + "->");
        InOrder(node.right);
    }

    public void PreOrder(TreeNode? node)
    {
        if (node == null) return;
        Console.Write(node.d + "->");
        PreOrder(node.left);
        PreOrder(node.right);
    }

    public void PostOrder(TreeNode? node)
    {
        if(node == null) return;
        PostOrder(node.left);
        PostOrder(node.right);
        Console.Write(node.d + "->");
    }
}