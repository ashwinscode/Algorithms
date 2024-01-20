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

    public void BFS(TreeNode? node)
    {
        if(node == null) return;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(node);

        while(queue.Count > 0)
        {
            var n = queue.Dequeue();
            Console.Write(n.d + "->");
            if(n.left != null) queue.Enqueue(n.left);
            if(n.right != null)queue.Enqueue(n.right);
        }
    }
}