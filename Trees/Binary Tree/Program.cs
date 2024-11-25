using Binary_Tree;

class Program
{
    static void Main(string[] args)
    {
       var binaryTree = new BinaryTree<int>();
        Console.WriteLine("Values to be inserted: 5,3,8,1,4,6,9\n");

        binaryTree.Insert(5);
        binaryTree.Insert(3);
        binaryTree.Insert(8);
        binaryTree.Insert(1);
        binaryTree.Insert(4);
        binaryTree.Insert(6);
        binaryTree.Insert(9);
        binaryTree.PrintTree();
     
        Console.WriteLine("\nPreOrder Traversal (Current-Left SubTree - Right SubTree):");
        binaryTree.PreOrderTraversal();

        Console.WriteLine("\nPostorder Traversal (Left SubTree - Right SubTree - Current):");
        binaryTree.PostOrderTraversal();

        Console.WriteLine("\nInOrder Traversal (Left SubTree - Current  - Right SubTree):");
        binaryTree.InOrderTraversal();


        Console.WriteLine("\nLevel Traversal (Level by Level):");
        binaryTree.LevelOrderTraversal();

        Console.WriteLine($"\nLevels in tree : {binaryTree.getLevelsCount()}");

        Console.WriteLine("\nLevel Traversal (Level by Level):");
        Console.WriteLine(string.Join(" , " , binaryTree.getNodesInLevel(3)));

        var bst = new BinarySearchTree<int>();
        Console.WriteLine("\nInserting : 45, 15, 79, 90, 10, 55, 12, 20, 50\r\n");

        bst.Insert(45);
        bst.Insert(15);
        bst.Insert(79);
        bst.Insert(90);
        bst.Insert(10);
        bst.Insert(55);
        bst.Insert(12);
        bst.Insert(20);
        bst.Insert(50);

        bst.PrintTree();

        Console.WriteLine($"Find 79 :{ bst.Search(79)}" );
        Console.WriteLine($"Find 80 :{bst.Search(80)}");


        Console.ReadKey();

    }
}
